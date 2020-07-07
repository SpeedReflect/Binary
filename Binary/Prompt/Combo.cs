using System;
using System.Windows.Forms;



namespace Binary.Prompt
{
	public partial class Combo : Form
	{
		public int Value { get; private set; } = 0;

		public Combo()
		{
			this.InitializeComponent();
			this.ToggleTheme();
		}

		public Combo(string[] options, string desc, bool prompt) : this()
		{
			this.ComboButtonCancel.Enabled = !prompt;
			this.ControlBox = !prompt;
			this.DescriptionLabel.Text = desc ?? String.Empty;
			if (options == null) return;
			this.ComboBoxSelection.Items.AddRange(options);
			this.ComboBoxSelection.SelectedIndex = 0;
		}

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.ComboButtonOK.BackColor = Theme.ButtonBackColor;
			this.ComboButtonOK.ForeColor = Theme.ButtonForeColor;
			this.ComboButtonOK.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.ComboButtonCancel.BackColor = Theme.ButtonBackColor;
			this.ComboButtonCancel.ForeColor = Theme.ButtonForeColor;
			this.ComboButtonCancel.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.ComboBoxSelection.BackColor = Theme.TextBoxBackColor;
			this.ComboBoxSelection.ForeColor = Theme.TextBoxForeColor;
			this.DescriptionLabel.ForeColor = Theme.LabelTextColor;
		}

		private void ComboButtonOK_Click(object sender, EventArgs e)
		{
			this.Value = this.ComboBoxSelection.SelectedIndex;
			this.Close();
		}

		private void ComboButtonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
