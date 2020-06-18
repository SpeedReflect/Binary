using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Binary.Enums;
using Binary.Endscript;
using Binary.Properties;
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
			this.IntroToolTip.SetToolTip(this.IntroPictureUser, "Launch Binary for Users");
			this.IntroToolTip.SetToolTip(this.IntroPictureModder, "Launch Binary for Modders");
			this.ToggleTheme();
		}

		private void IntroPictureUser_Click(object sender, EventArgs e)
		{
			try
			{

				this.UserInteract();

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
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
			GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, true, true);
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

			Parser.Deserialize(dialog.FileName, out Launch launch);

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

			MessageBox.Show("Is this Peng?", "Yeah");

		}
	
		private void ModderInteract()
		{
			this.Hide();

			using (var editor = new Editor())
			{

				editor.ShowDialog();
			
			}

			this.Show();
		}
	
		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.IntroPanelModder.BackColor = Theme.ButtonBackColor;
			this.IntroPanelUser.BackColor = Theme.ButtonBackColor;
		}
	}
}
