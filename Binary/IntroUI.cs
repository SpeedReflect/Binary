using System;
using System.IO;
using System.Windows.Forms;
using Binary.Interact;
using Binary.Properties;
using Endscript.Core;
using Endscript.Enums;
using Nikki.Core;
using CoreExtensions.Management;
using Endscript.Profiles;
using Endscript.Commands;
using Binary.Prompt;

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
			// If password check was not done yet
			if (!Configurations.Default.PassPassed)
			{
				using var form = new ModderPass();
				
				if (form.ShowDialog() != DialogResult.OK)
				{

					return;

				}
			
			}

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

			var commands = parser.Read();
			var profile = BaseProfile.NewProfile(launch.GameID, launch.Directory);
			profile.Load(launch);
			var manager = new EndScriptManager(profile, commands, endscript);

			while (!manager.ProcessScript())
			{

				var command = manager.CurrentCommand;

				if (command is CheckboxCommand checkbox)
				{

					using var input = new Check(checkbox.Description, true);
					input.ShowDialog();
					checkbox.Choice = input.Value ? 1 : 0;

				}
				else if (command is ComboboxCommand combobox)
				{

					using var input = new Combo(combobox.Options, combobox.Description, true);
					input.ShowDialog();
					combobox.Choice = input.Value < 0 ? 0 : input.Value;

				}
			
			}

			int aaa = 0;

			MessageBox.Show($"Script {Path.GetFileName(dialog.FileName)} has been applied");
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
			MessageBox.Show("Binary by MaxHwoy v2.0.0.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
