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
			0x1C, 0x00, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x00,
			0x30, 0xFB, 0x00, 0x00, 0x1C, 0x3A, 0x97, 0x30,
			0x76, 0x0F, 0xD8, 0x04, 0x02, 0x49, 0x24, 0x80,
			0x34, 0xD2, 0xEB, 0x89, 0x71, 0x7B, 0xB2, 0xF2,
			0xA9, 0xF2, 0x03, 0xE4
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
