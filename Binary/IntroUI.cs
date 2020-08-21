using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using Binary.Interact;
using Binary.Properties;
using Binary.Prompt;
using Endscript.Core;
using Endscript.Enums;
using Endscript.Profiles;
using Endscript.Commands;
using Nikki.Core;
using CoreExtensions.Management;



namespace Binary
{
	public partial class IntroUI : Form
	{
		public IntroUI()
		{
			this.InitializeComponent();
			this.IntroPictureUser.Image = Resources.User;
			this.IntroPictureModder.Image = Resources.Modder;
			this.PictureBoxDiscord.Image = Resources.Discord;
			this.PictureBoxUpdates.Image = Resources.Update;

			this.PictureBoxAutoBackups.Image = Configurations.Default.AutoBackups
				? Resources.EnableBackups : Resources.DisableBackups;

			this.PictureBoxMaximized.Image = Configurations.Default.StartMaximized
				? Resources.EnableMaximize : Resources.DisableMaximize;

			this.PictureBoxTheme.Image = Configurations.Default.DarkTheme
				? Resources.EnableTheme : Resources.DisableTheme;

			this.PictureBoxSoon.Image = Configurations.Default.SoonFeature
				? Resources.EnableSoon : Resources.DisableSoon;

			this.IntroToolTip.SetToolTip(this.IntroPictureUser, "Launch Binary for Users");
			this.IntroToolTip.SetToolTip(this.IntroPictureModder, "Launch Binary for Modders");
			this.IntroToolTip.SetToolTip(this.PictureBoxUpdates, "Check updates for Binary");
			this.IntroToolTip.SetToolTip(this.PictureBoxDiscord, "Join official Discord server");
			this.IntroToolTip.SetToolTip(this.PictureBoxTheme, "Turn on Dark Theme");
			this.IntroToolTip.SetToolTip(this.PictureBoxMaximized, "Start editor in maximized mode");
			this.IntroToolTip.SetToolTip(this.PictureBoxAutoBackups, "Enable auto backups");
			this.IntroToolTip.SetToolTip(this.PictureBoxSoon, "Coming Soon TM");

			this.ToggleTheme();
		}

		#region Theme

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.IntroPanelModder.BackColor = Theme.ButtonBackColor;
			this.IntroPanelUser.BackColor = Theme.ButtonBackColor;
			this.LabelBinary.ForeColor = Theme.LabelTextColor;
		}

		#endregion

		private void IntroPictureUser_Click(object sender, EventArgs e)
		{
			#if !DEBUG
			try
			{
			#endif

				this.UserInteract();
				ForcedX.GCCollect();

			#if !DEBUG
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			#endif
		}

		private void IntroPictureModder_Click(object sender, EventArgs e)
		{
			// If password check was not done yet (deprecated)
			/*
			if (!Configurations.Default.PassPassed)
			{
				using var form = new ModderPass();
				
				if (form.ShowDialog() != DialogResult.OK)
				{
			
					return;
			
				}
			
			}
			*/

			this.ModderInteract();
			ForcedX.GCCollect();
		}

		private void UserInteract()
		{
			using var dialog = new OpenFileDialog()
			{
				CheckFileExists = true,
				Filter = "Endscript Files|*.end",
				Multiselect = false,
				Title = "Select main Endscript (.end) file to install",
			};

			if (dialog.ShowDialog() != DialogResult.OK) return;

			Launch.Deserialize(dialog.FileName, out Launch launch);

			if (launch.UsageID != eUsage.User)
			{

				throw new Exception($"Usage type of the endscript is stated to be {launch.Usage}, while should be User");

			}

			if (launch.GameID == GameINT.None)
			{

				throw new Exception($"Invalid stated game type named {launch.Game}");

			}

			using var browser = new FolderBrowserDialog()
			{
				Description = $"Select Need for Speed: {launch.Game} directory to modify.",
				RootFolder = Environment.SpecialFolder.MyComputer,
				UseDescriptionForTitle = true,
				AutoUpgradeEnabled = false,
			};

			if (browser.ShowDialog() != DialogResult.OK) return;

			launch.Directory = browser.SelectedPath;
			launch.ThisDir = Path.GetDirectoryName(dialog.FileName);
			launch.CheckEndscript();
			launch.CheckFiles();
			launch.LoadLinks();

			var endscript = Path.Combine(launch.ThisDir, launch.Endscript);
			var parser = new EndScriptParser(endscript);
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

				MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			var profile = BaseProfile.NewProfile(launch.GameID, launch.Directory);
			profile.Load(launch);
			this.EnsureBackups(profile);
			var manager = new EndScriptManager(profile, commands, endscript);

			try
			{

				while (!manager.ProcessScript())
				{

					var command = manager.CurrentCommand;

					if (command is CheckboxCommand checkbox)
					{

						using var input = new Check(checkbox.Description, true);
						input.ShowDialog();
						checkbox.Choice = input.Value ? 1 : 0;

						#if DEBUG
						Console.WriteLine($"Checkbox pending : option {input.Value} was chosen by user");
						#endif

					}
					else if (command is ComboboxCommand combobox)
					{

						var options = new string[combobox.Options.Length];
						for (int i = 0; i < options.Length; ++i) options[i] = combobox.Options[i].Name;
						using var input = new Combo(options, combobox.Description, true);
						input.ShowDialog();
						combobox.Choice = input.Value < 0 ? 0 : input.Value;

						#if DEBUG
						Console.WriteLine($"Checkbox pending : option {input.Value} was chosen by user");
						#endif

					}

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show("Execution has been interrupted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}

			var script = Path.GetFileName(dialog.FileName);

			if (manager.Errors.Any())
			{

				Utils.WriteErrorsToLog(manager.Errors, dialog.FileName);
				MessageBox.Show($"Script {script} has been applied, however, {manager.Errors.Count()} errors " +
					$"has been detected. Check EndError.log for more information", "Information",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{

				MessageBox.Show($"Script {script} has been successfully applied",
					"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}

			var save = MessageBox.Show("Would you like to save files?", "Prompt", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (save == DialogResult.Yes)
			{

				profile.Save();
				this.AskForGameRun(profile);

			}
		}
	
		private void ModderInteract()
		{
			this.Hide();
			var start = FormStartPosition.CenterScreen;
			var state = Configurations.Default.StartMaximized
				? FormWindowState.Maximized
				: FormWindowState.Normal;

			using (var editor = new Editor() { StartPosition = start, WindowState = state })
			{

				editor.ShowDialog();
			
			}

			this.Show();
		}
	
		private void EnsureBackups(BaseProfile profile)
		{
			foreach (var sdb in profile)
			{

				var orig = sdb.FullPath;
				var back = $"{orig}.bacc";
				if (!File.Exists(back)) File.Copy(orig, back, true);

			}
		}

		private void AskForGameRun(BaseProfile profile)
		{
			var result = MessageBox.Show("Do you wish to run the game?", "Prompt",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{

				try
				{

					var path = profile.Directory;
					var game = profile.GameINT;
					var exe = path;

					exe += game switch
					{
						GameINT.Carbon => @"\NFSC.EXE",
						GameINT.MostWanted => @"\SPEED.EXE",
						GameINT.Prostreet => @"\NFS.EXE",
						GameINT.Undercover => @"\NFS.EXE",
						GameINT.Underground1 => @"\SPEED.EXE",
						GameINT.Underground2 => @"\SPEED2.EXE",
						_ => throw new Exception($"Game {game} is an invalid game type")
					};

					Process.Start(new ProcessStartInfo(exe) { WorkingDirectory = path });

				}
				catch (Exception e)
				{

					MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
		}

		private void PictureBoxDiscord_Click(object sender, EventArgs e)
		{
			Utils.OpenBrowser("https://discord.gg/jzksXXn");
		}

		private void PictureBoxUpdates_Click(object sender, EventArgs e)
		{
			MessageBox.Show("No updates yet, follow discord server for news", "Updates");
		}

		private void PictureBoxAutoBackups_Click(object sender, EventArgs e)
		{
			Configurations.Default.AutoBackups = !Configurations.Default.AutoBackups;
			Configurations.Default.Save();
			this.PictureBoxAutoBackups.Image = Configurations.Default.AutoBackups
				? Resources.EnableBackups : Resources.DisableBackups;
		}

		private void PictureBoxMaximized_Click(object sender, EventArgs e)
		{
			Configurations.Default.StartMaximized = !Configurations.Default.StartMaximized;
			Configurations.Default.Save();
			this.PictureBoxMaximized.Image = Configurations.Default.StartMaximized
				? Resources.EnableMaximize : Resources.DisableMaximize;
		}

		private void PictureBoxTheme_Click(object sender, EventArgs e)
		{
			Configurations.Default.DarkTheme = !Configurations.Default.DarkTheme;
			Configurations.Default.Save();
			this.ToggleTheme();
			this.PictureBoxTheme.Image = Configurations.Default.DarkTheme
				? Resources.EnableTheme : Resources.DisableTheme;
		}

		private void PictureBoxSoon_Click(object sender, EventArgs e)
		{
			Configurations.Default.SoonFeature = !Configurations.Default.SoonFeature;
			Configurations.Default.Save();
			this.PictureBoxSoon.Image = Configurations.Default.SoonFeature
				? Resources.EnableSoon : Resources.DisableSoon;
		}

		private void LabelBinary_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Binary by MaxHwoy v2.1.2", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
