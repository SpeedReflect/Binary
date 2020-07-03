using System;
using System.Text;
using System.Windows.Forms;
using Binary.Properties;
using Nikki.Utils;



namespace Binary.Interact
{
	public partial class ModderPass : Form
	{
		private static readonly byte[] password = new byte[]
		{
			0x48, 0x55, 0x46, 0x46, 0x01, 0x10, 0x00, 0x00,
			0x1A, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00,
			0x30, 0xFB, 0x00, 0x00, 0x1A, 0x3A, 0xB3, 0x7C,
			0x34, 0xB8, 0x08, 0x07, 0x80, 0xF9, 0x83, 0xDD,
			0xD1, 0xF6, 0x2E, 0xC4, 0x88, 0xB6, 0xF4, 0x80,
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
			var checkpass = Encoding.UTF8.GetString(Interop.Decompress(password));
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
