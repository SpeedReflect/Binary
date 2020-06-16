using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using CoreExtensions.Management;



namespace Binary.Endscript
{
	public static class Parser
	{
		private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
		{
			AllowTrailingCommas = true,
			IgnoreReadOnlyProperties = true,
			ReadCommentHandling = JsonCommentHandling.Skip,
			WriteIndented = true,
		};

		public static void GenerateSample() => GenerateSample(String.Empty);

		public static void GenerateSample(string directory)
		{
			var launch = new Launch()
			{
				Directory = directory,
				Files = new List<string>()
				{
					$"GLOBAL\\GLOBALA.BUN",
					$"GLOBAL\\GLOBALB.LZC",
				},
				Links = new List<string>()
				{
					$"GLOBAL\\attributes.bin",
					$"GLOBAL\\fe_attrib.bin",
					$"LANGUAGES\\Labels_Global.bin",
					$"LANGUAGES\\Labels.bin",
				},
			};

			Serialize("launch.end", launch);
		}
	
		public static void Serialize(string filename, Launch launch)
		{
			try
			{

				var settings = JsonSerializer.Serialize(launch, options);
				settings = settings.Replace(@"\\", @"\");
				File.WriteAllText(filename, settings);

			}
			catch (Exception e)
			{

				MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		public static void Deserialize(string filename, out Launch launch)
		{
			try
			{

				var settings = File.ReadAllText(filename);
				launch = JsonSerializer.Deserialize<Launch>(settings, options);

			}
			catch (Exception e)
			{

				launch = null;
				MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
