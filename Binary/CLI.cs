using CoreExtensions.Management;
using Endscript.Commands;
using Endscript.Core;
using Endscript.Enums;
using Endscript.Profiles;
using Nikki.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class CLI
    {
        eUsage m_usageMode;
        BaseProfile m_profile;

        public CLI(eUsage usage)
        {
            m_usageMode = usage;
        }

		void PrintExceptions(string[] exceptions)
        {
			string print = "";

			foreach (var exception in exceptions)
			{
				print += $"Exception: {exception}\n";
			}

			Console.WriteLine(print);
		}

        public void LoadProfile(string path)
        {
            Launch.Deserialize(path, out Launch launch);
            launch.ThisDir = Path.GetDirectoryName(path);

            Editor.FixLaunchDirectory(launch, path);

            if (launch.UsageID != eUsage.Modder)
            {

                throw new Exception($"Usage type of the endscript is stated to be {launch.Usage}, while should be Modder");
            }

            if (launch.GameID == GameINT.None)
            {

                throw new Exception($"Invalid stated game type named {launch.Game}");
            }

            if (!Directory.Exists(launch.Directory))
            {

                throw new DirectoryNotFoundException($"Directory named {launch.Directory} does not exist");
            }

            m_profile = BaseProfile.NewProfile(launch.GameID, launch.Directory);

            var watch = new Stopwatch();
            watch.Start();

            var exceptions = m_profile.Load(launch);

            watch.Stop();

			PrintExceptions(exceptions);
			Console.WriteLine($"Completed in {watch.Elapsed.TotalSeconds} seconds");
		}

        public void ImportEndscript(string path)
        {
            var parser = new EndScriptParser(path);

			BaseCommand[] commands;

			try
			{

				commands = parser.Read();

			}
			catch (Exception ex)
			{

				var error = $"Error has occured -> File: {parser.CurrentFile}, Line: {parser.CurrentIndex}" +
					Environment.NewLine + $"Command: [{parser.CurrentLine}]" + Environment.NewLine +
					$"Error: {ex.GetLowestMessage()}";

				Console.WriteLine(error);
				return;

			}

			var manager = new EndScriptManager(m_profile, commands, path);

			try
			{

				manager.CommandChase();
				manager.ProcessScript();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Error: " + ex.GetLowestMessage());
				return;
			}

			var script = Path.GetFileName(path);

			if (manager.Errors.Any())
			{
				Utils.WriteErrorsToLog(manager.Errors, path);
				Console.WriteLine($"Script {script} has been applied, however, {manager.Errors.Count()} errors " +
					$"have been detected. Check EndError.log for more information.");
			}
			else
			{

				Console.WriteLine($"Script {script} has been successfully applied.");
			}
		}

		public void Save()
        {
			Console.WriteLine("Saving... Please wait...");

			var watch = new Stopwatch();
			watch.Start();

			var exceptions = m_profile.Save();

			watch.Stop();

			PrintExceptions(exceptions);
			Console.WriteLine($"Complete in {watch.Elapsed.TotalSeconds} seconds.");

		}
    }
}
