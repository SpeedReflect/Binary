using System;
using System.IO;
using System.Windows.Forms;
using Endscript.Core;



namespace Binary.Interact
{
	public partial class LanMaker : Form
	{
		private bool IsValidDirectoryChosen => Directory.Exists(this.LanMakerTextBoxDir.Text);

		public LanMaker()
		{
			this.InitializeComponent();
			this.ToggleTheme();
		}

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.LanMakerGame.BackColor = Theme.TextBoxBackColor;
			this.LanMakerGame.ForeColor = Theme.TextBoxForeColor;
			this.LanMakerUsage.BackColor = Theme.TextBoxBackColor;
			this.LanMakerUsage.ForeColor = Theme.TextBoxForeColor;
			this.LanMakerTextBoxDir.BackColor = Theme.TextBoxBackColor;
			this.LanMakerTextBoxDir.ForeColor = Theme.TextBoxForeColor;
			this.LanMakerButtonDir.BackColor = Theme.ButtonBackColor;
			this.LanMakerButtonDir.ForeColor = Theme.ButtonForeColor;
			this.LanMakerButtonDir.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.LanMakerButtonSave.BackColor = Theme.ButtonBackColor;
			this.LanMakerButtonSave.ForeColor = Theme.ButtonForeColor;
			this.LanMakerButtonSave.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.LanMakerButtonHelp.BackColor = Theme.ButtonBackColor;
			this.LanMakerButtonHelp.ForeColor = Theme.ButtonForeColor;
			this.LanMakerButtonHelp.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
		}

		private void ChangeSaveButtonEnabledState()
		{
			this.LanMakerButtonSave.Enabled = this.IsValidDirectoryChosen &&
				!String.IsNullOrEmpty(this.LanMakerGame.Text) &&
				!String.IsNullOrEmpty(this.LanMakerUsage.Text);
		}

		private void LanMakerButtonDir_Click(object sender, EventArgs e)
		{
			using var browser = new FolderBrowserDialog()
			{
				AutoUpgradeEnabled = false,
				Description = "Select any Need for Speed game directory",
				RootFolder = Environment.SpecialFolder.MyComputer,
			};

			if (browser.ShowDialog() == DialogResult.OK)
			{

				this.LanMakerTextBoxDir.Text = browser.SelectedPath;
				this.LanMakerButtonSave.Enabled = true;

			}

			this.ChangeSaveButtonEnabledState();
		}

		private void LanMakerButtonSave_Click(object sender, EventArgs e)
		{
			using var dialog = new SaveFileDialog()
			{
				AddExtension = true,
				AutoUpgradeEnabled = true,
				CheckPathExists = true,
				DefaultExt = ".end",
				Filter = "Endscript Files|*.end",
				OverwritePrompt = true,
				SupportMultiDottedExtensions = true,
				Title = "Select directory and filename of the endscript to be saved",
			};

			if (dialog.ShowDialog() == DialogResult.OK)
			{

				var directory = this.LanMakerTextBoxDir.Text;
				var game = this.LanMakerGame.Text;
				var usage = this.LanMakerUsage.Text;
				var launch = Utils.GenerateSample(directory, game, usage);
				Launch.Serialize(dialog.FileName, launch);
				MessageBox.Show($"File {dialog.FileName} has been saved.", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void LanMakerUsage_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.ChangeSaveButtonEnabledState();
		}

		private void LanMakerGame_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.ChangeSaveButtonEnabledState();
		}

		private void LanMakerButtonHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Launcher is a Version 1 .end file that is used for loading game files, " +
				"linked files, main endscript and game selection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LanMakerTextBoxDir_TextChanged(object sender, EventArgs e)
		{
			this.ChangeSaveButtonEnabledState();
		}
	}
}
