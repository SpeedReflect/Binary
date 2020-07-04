using System;
using System.Windows.Forms;
using Nikki.Core;
using CoreExtensions.Text;
using CoreExtensions.Native;



namespace Binary.Tools
{
    public partial class Raider : Form
    {
        public Raider()
        {
            this.InitializeComponent();
            this.ToggleTheme();
        }

        private void ToggleTheme()
		{
            this.BackColor = Theme.MainBackColor;
            this.ForeColor = Theme.MainForeColor;
            this.ChooseSearchMode.BackColor = Theme.TextBoxBackColor;
            this.ChooseSearchMode.ForeColor = Theme.TextBoxForeColor;
            this.BinHashInput.BackColor = Theme.TextBoxBackColor;
            this.BinHashInput.ForeColor = Theme.TextBoxForeColor;
            this.BinFileInput.BackColor = Theme.TextBoxBackColor;
            this.BinFileInput.ForeColor = Theme.TextBoxForeColor;
            this.StringGuessed.BackColor = Theme.TextBoxBackColor;
            this.StringGuessed.ForeColor = Theme.TextBoxForeColor;
            this.CopyBinHash.BackColor = Theme.ButtonBackColor;
            this.CopyBinHash.ForeColor = Theme.ButtonForeColor;
            this.CopyBinHash.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyBinFile.BackColor = Theme.ButtonBackColor;
            this.CopyBinFile.ForeColor = Theme.ButtonForeColor;
            this.CopyBinFile.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyString.BackColor = Theme.ButtonBackColor;
            this.CopyString.ForeColor = Theme.ButtonForeColor;
            this.CopyString.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.label1.ForeColor = Theme.LabelTextColor;
            this.label2.ForeColor = Theme.LabelTextColor;
            this.label3.ForeColor = Theme.LabelTextColor;
            this.label4.ForeColor = Theme.LabelTextColor;
        }

        private void ChooseSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ChooseSearchMode.SelectedIndex == 0)
            {
                this.BinHashInput.ReadOnly = false;
                this.BinFileInput.ReadOnly = true;
            }
            else
            {
                this.BinHashInput.ReadOnly = true;
                this.BinFileInput.ReadOnly = false;
            }
        }

        private void BinHashInput_TextChanged(object sender, EventArgs e)
        {
            if (!this.BinHashInput.ReadOnly && this.BinHashInput.Text.IsHexString())
            {
                if (this.BinHashInput.Text.Length > 10) return;

                var key = Convert.ToUInt32(this.BinHashInput.Text, 16);
                this.BinFileInput.Text = $"0x{key.Reverse():X8}";

                this.StringGuessed.Text = Map.BinKeys.TryGetValue(key, out var value)
                    ? value
                    : "N/A";

            }
        }

        private void BinFileInput_TextChanged(object sender, EventArgs e)
        {
            if (!this.BinFileInput.ReadOnly && this.BinFileInput.Text.IsHexString())
            {

                if (this.BinHashInput.Text.Length > 10) return;

                var key = Convert.ToUInt32(this.BinFileInput.Text, 16);
                key = key.Reverse();
                this.BinHashInput.Text = $"0x{key:X8}";

                this.StringGuessed.Text = Map.BinKeys.TryGetValue(key, out var value)
                    ? value
                    : "N/A";
            }
        }

        private void CopyBinHash_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.BinHashInput.Text))
            {

                Clipboard.SetText(this.BinHashInput.Text);

            }
        }

        private void CopyBinFile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.BinFileInput.Text))
            {

                Clipboard.SetText(this.BinFileInput.Text);

            }
        }

        private void CopyString_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.StringGuessed.Text))
            {

                Clipboard.SetText(this.StringGuessed.Text);

            }
        }
    }
}
