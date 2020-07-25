using System;
using System.Windows.Forms;
using Binary.Properties;
using Nikki.Utils;
using CoreExtensions.Text;



namespace Binary.Interact
{
	public partial class ModderPass : Form
	{
		private static readonly byte[] password = new byte[]
		{
			0x48, 0x55, 0x46, 0x46, 0x01, 0x10, 0x00, 0x00,
			0x1D, 0x00, 0x00, 0x00, 0x27, 0x00, 0x00, 0x00,
			0x30, 0xFB, 0x00, 0x00, 0x1D, 0x7A, 0x93, 0x24,
			0x90, 0xE3, 0x03, 0xF2, 0x8C, 0x2E, 0x06, 0x6C,
			0x99, 0x8E, 0xD4, 0xAF, 0x67, 0x92, 0xF6, 0xC4,
			0x90, 0x0E, 0x79, 0x9C, 0x90, 0x8A, 0x73, 0xAE,
			0xB2, 0x6E, 0x22, 0x75, 0x5A, 0x7E, 0x40
		};

		public ModderPass()
		{
			this.InitializeComponent();
			this.ToggleTheme();
			this.ModderPassPictureBox.Image = Resources.Discord;
		}

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.ModderPassButtonConfirm.BackColor = Theme.ButtonBackColor;
			this.ModderPassButtonConfirm.ForeColor = Theme.ButtonForeColor;
			this.ModderPassButtonConfirm.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.ModderPassButtonExit.BackColor = Theme.ButtonBackColor;
			this.ModderPassButtonExit.ForeColor = Theme.ButtonForeColor;
			this.ModderPassButtonExit.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.ModderPassLabel.ForeColor = Theme.LabelTextColor;
			this.ModderPassPictureBox.BackColor = Theme.MainBackColor;
			this.ModderPassTextBox.BackColor = Theme.TextBoxBackColor;
			this.ModderPassTextBox.ForeColor = Theme.TextBoxForeColor;
		}

		private void ModderPassButtonConfirm_Click(object sender, EventArgs e)
		{
			var checkpass = Interop.Decompress(password).GetString();
			if (checkpass == this.ModderPassTextBox.Text)
			{

				Configurations.Default.PassPassed = true;
				Configurations.Default.Save();
				this.DialogResult = DialogResult.OK;
				this.Close();

			}
			else
			{

				MessageBox.Show("Incorrect password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.ModderPassTextBox.Text = String.Empty;

			}
		}

		private void ModderPassButtonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ModderPassPictureBox_Click(object sender, EventArgs e)
		{
			Utils.OpenBrowser("https://discord.gg/jzksXXn");
		}
	}
}
