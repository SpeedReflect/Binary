using System;
using System.Text;
using System.Windows.Forms;
using Binary.Properties;
using Nikki.Utils;



namespace Binary
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

		private void ToggleTheme()
		{
			if (Configurations.Default.DarkTheme) this.ToggleDarkTheme();
			else this.ToggleLightTheme();
		}

		private void ToggleLightTheme()
		{
			this.BackColor = Theme.Light.MainBackColor;
			this.ForeColor = Theme.Light.MainForeColor;
			this.ModderPassButtonConfirm.BackColor = Theme.Light.ButtonBackColor;
			this.ModderPassButtonConfirm.ForeColor = Theme.Light.ButtonForeColor;
			this.ModderPassButtonExit.BackColor = Theme.Light.ButtonBackColor;
			this.ModderPassButtonExit.ForeColor = Theme.Light.ButtonForeColor;
			this.ModderPassLabel.ForeColor = Theme.Light.LabelTextColor;
			this.ModderPassPictureBox.BackColor = Theme.Light.MainBackColor;
			this.ModderPassTextBox.BackColor = Theme.Light.TextBoxBackColor;
			this.ModderPassTextBox.ForeColor = Theme.Light.TextBoxForeColor;
		}

		private void ToggleDarkTheme()
		{
			this.BackColor = Theme.Dark.MainBackColor;
			this.ForeColor = Theme.Dark.MainForeColor;
			this.ModderPassButtonConfirm.BackColor = Theme.Dark.ButtonBackColor;
			this.ModderPassButtonConfirm.ForeColor = Theme.Dark.ButtonForeColor;
			this.ModderPassButtonExit.BackColor = Theme.Dark.ButtonBackColor;
			this.ModderPassButtonExit.ForeColor = Theme.Dark.ButtonForeColor;
			this.ModderPassLabel.ForeColor = Theme.Dark.LabelTextColor;
			this.ModderPassPictureBox.BackColor = Theme.Dark.MainBackColor;
			this.ModderPassTextBox.BackColor = Theme.Dark.TextBoxBackColor;
			this.ModderPassTextBox.ForeColor = Theme.Dark.TextBoxForeColor;
		}
	}
}
