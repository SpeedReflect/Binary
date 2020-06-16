using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Nikki.Core;
using Binary.Enums;
using Binary.Endscript;
using Binary.Properties;



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
		}

		private void IntroPictureUser_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog()
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

				MessageBox.Show($"Usage type of the endscript is stated to be {launch.Usage}, " +
					$"while should be User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			if (launch.GameID == GameINT.None)
			{

				MessageBox.Show($"Invalid stated game type named {launch.Game}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			var browser = new FolderBrowserDialog()
			{
				Description = $"Select Need for Speed: {launch.Game} directory to modify.",
				RootFolder = Environment.SpecialFolder.MyComputer,
				UseDescriptionForTitle = true,
				AutoUpgradeEnabled = false,
			};

			if (browser.ShowDialog() != DialogResult.OK) return;

			launch.Directory = browser.SelectedPath;

			MessageBox.Show("Success, boi", "Success");
		}

		private void IntroPictureModder_Click(object sender, EventArgs e)
		{

		}
	}
}
