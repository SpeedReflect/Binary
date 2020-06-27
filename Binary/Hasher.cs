using System;
using System.Windows.Forms;

using CoreExtensions.Native;

using Nikki.Utils;



namespace Binary
{
    public partial class Hasher : Form
    {
        public Hasher()
        {
            this.InitializeComponent();
            this.ToggleTheme();
        }

        private void ToggleTheme()
		{
            this.BackColor = Theme.MainBackColor;
            this.ForeColor = Theme.MainForeColor;
            this.StringTextbox.BackColor = Theme.TextBoxBackColor;
            this.StringTextbox.ForeColor = Theme.TextBoxForeColor;
            this.BinHashTextbox.BackColor = Theme.TextBoxBackColor;
            this.BinHashTextbox.ForeColor = Theme.TextBoxForeColor;
            this.BinFileTextbox.BackColor = Theme.TextBoxBackColor;
            this.BinFileTextbox.ForeColor = Theme.TextBoxForeColor;
            this.VltHashTextbox.BackColor = Theme.TextBoxBackColor;
            this.VltHashTextbox.ForeColor = Theme.TextBoxForeColor;
            this.VltFileTextbox.BackColor = Theme.TextBoxBackColor;
            this.VltFileTextbox.ForeColor = Theme.TextBoxForeColor;
            this.CopyString.BackColor = Theme.ButtonBackColor;
            this.CopyString.ForeColor = Theme.ButtonForeColor;
            this.CopyString.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyBinHash.BackColor = Theme.ButtonBackColor;
            this.CopyBinHash.ForeColor = Theme.ButtonForeColor;
            this.CopyBinHash.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyBinFile.BackColor = Theme.ButtonBackColor;
            this.CopyBinFile.ForeColor = Theme.ButtonForeColor;
            this.CopyBinFile.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyVltHash.BackColor = Theme.ButtonBackColor;
            this.CopyVltHash.ForeColor = Theme.ButtonForeColor;
            this.CopyVltHash.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyVltFile.BackColor = Theme.ButtonBackColor;
            this.CopyVltFile.ForeColor = Theme.ButtonForeColor;
            this.CopyVltFile.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.label1.ForeColor = Theme.LabelTextColor;
            this.label2.ForeColor = Theme.LabelTextColor;
            this.label3.ForeColor = Theme.LabelTextColor;
            this.label4.ForeColor = Theme.LabelTextColor;
            this.label5.ForeColor = Theme.LabelTextColor;
        }

        private void StringTextbox_TextChanged(object sender, EventArgs e)
        {
            var str = this.StringTextbox.Text;

            uint result = 0;
            string _0x = "0x";

            // Bin memory hash
            result = str.BinHash();
            this.BinHashTextbox.Text = $"{_0x}{result:X8}";

            // Bin file hash
            result = result.Reverse();
            this.BinFileTextbox.Text = $"{_0x}{result:X8}";

            // Vlt memory hash
            result = str.VltHash();
            this.VltHashTextbox.Text = $"{_0x}{result:X8}";

            // Vlt file hash
            result = result.Reverse();
            this.VltFileTextbox.Text = $"{_0x}{result:X8}";
        }

        private void CopyString_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.StringTextbox?.Text ?? String.Empty);
        }

        private void CopyBinHash_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.BinHashTextbox?.Text ?? String.Empty);
        }

        private void CopyBinFile_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.BinFileTextbox?.Text ?? String.Empty);
        }

        private void CopyVltHash_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.VltHashTextbox?.Text ?? String.Empty);
        }

        private void CopyVltFile_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.VltFileTextbox?.Text ?? String.Empty);
        }
    }
}
