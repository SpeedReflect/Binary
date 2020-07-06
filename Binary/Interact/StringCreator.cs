using System;
using System.Windows.Forms;
using System.ComponentModel;
using Nikki.Utils;
using Nikki.Support.Shared.Parts.STRParts;
using CoreExtensions.Text;
using CoreExtensions.Native;



namespace Binary.Interact
{
	public partial class StringCreator : Form
	{
		public string Key { get; private set; }
		public string Label { get; private set; }
		public string Value { get; private set; }

		public StringCreator()
		{
			this.InitializeComponent();
			this.ToggleTheme();
			this.StringTextBoxKey.Text = "0x00000000";
		}

		public StringCreator(StringRecord record) : this()
		{
			this.StringTextBoxKey.Text = $"0x{record.Key:X8}";
			this.StringTextBoxLabel.Text = record.Label;
			this.StringTextBoxText.Text = Utils.UTF8toISO(record.Text);

			if (record.Key != record.Label.BinHash())
			{

				this.StringCheckBoxCustom.Checked = true;

			}
		}

		#region Theme

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.StringButtonOK.BackColor = Theme.ButtonBackColor;
			this.StringButtonOK.ForeColor = Theme.ButtonForeColor;
			this.StringButtonOK.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.StringButtonCancel.BackColor = Theme.ButtonBackColor;
			this.StringButtonCancel.ForeColor = Theme.ButtonForeColor;
			this.StringButtonCancel.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.StringTextBoxKey.BackColor = Theme.TextBoxBackColor;
			this.StringTextBoxKey.ForeColor = Theme.TextBoxForeColor;
			this.StringTextBoxLabel.BackColor = Theme.TextBoxBackColor;
			this.StringTextBoxLabel.ForeColor = Theme.TextBoxForeColor;
			this.StringTextBoxText.BackColor = Theme.TextBoxBackColor;
			this.StringTextBoxText.ForeColor = Theme.TextBoxForeColor;
			this.StringCheckBoxCustom.ForeColor = Theme.LabelTextColor;
			this.StringCheckBoxReversed.ForeColor = Theme.LabelTextColor;
			this.label1.ForeColor = Theme.LabelTextColor;
			this.label2.ForeColor = Theme.LabelTextColor;
		}

		#endregion

		private void StringButtonOK_Click(object sender, EventArgs e)
		{
			if (this.StringCheckBoxReversed.Checked)
			{

				var key = Convert.ToUInt32(this.StringTextBoxKey.Text, 16);
				this.Key = $"0x{key.Reverse():X8}";

			}
			else
			{

				this.Key = this.StringTextBoxKey.Text;

			}

			this.Label = this.StringTextBoxLabel.Text ?? String.Empty;
			this.Value = this.StringTextBoxText.Text ?? String.Empty;
			this.Close();
		}

		private void StringButtonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StringTextBoxLabel_TextChanged(object sender, EventArgs e)
		{
			if (!this.StringCheckBoxCustom.Checked)
			{

				var key = this.StringTextBoxLabel.Text.BinHash();
				this.StringTextBoxKey.Text = this.StringCheckBoxReversed.Checked
					? $"0x{key.Reverse():X8}"
					: $"0x{key:X8}";

			}
		}

		private void StringCheckBoxCustom_CheckedChanged(object sender, EventArgs e)
		{
			this.StringTextBoxKey.Enabled = this.StringCheckBoxCustom.Checked;
			
			if (!this.StringTextBoxKey.Enabled)
			{

				this.StringTextBoxKey.Text = $"0x{this.StringTextBoxLabel.Text.BinHash():X8}";

			}
		}

		private void StringCheckBoxReversed_CheckedChanged(object sender, EventArgs e)
		{
			var key = Convert.ToUInt32(this.StringTextBoxKey.Text, 16);
			this.StringTextBoxKey.Text = $"0x{key.Reverse():X8}";
		}

		private void StringTextBoxKey_Validating(object sender, CancelEventArgs e)
		{
			if (!this.StringTextBoxKey.Text.IsHexString())
			{

				MessageBox.Show("Key entered should be a hexadecimal hash that starts with 0x", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.Cancel = true;

			}
		}
	}
}
