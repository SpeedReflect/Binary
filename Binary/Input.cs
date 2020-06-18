using System;
using System.Windows.Forms;
using Binary.Properties;



namespace Binary
{
	public partial class Input : Form
	{
		private const string invalid = "Invalid input";
		private const string input = "Input value";
		private readonly Predicate<string> _input_check;
		private readonly string _error_message;
		public string Value { get; private set; } = String.Empty;

		public Input() : this(input, null, invalid) { }

		public Input(string text) : this(text, null, invalid) { }

		public Input(string text, Predicate<string> inputcheck) : this(text, inputcheck, invalid) { }

		public Input(string text, Predicate<string> inputcheck, string error)
		{
			this.InitializeComponent();
			this.ToggleTheme();
			this.InputLabel.Text = text;
			this._input_check = inputcheck;
			this._error_message = error;
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
			this.InputButtonOK.BackColor = Theme.Light.ButtonBackColor;
			this.InputButtonOK.ForeColor = Theme.Light.ButtonForeColor;
			this.InputButtonOK.FlatAppearance.BorderColor = Theme.Light.ButtonFlatColor;
			this.InputButtonCancel.BackColor = Theme.Light.ButtonBackColor;
			this.InputButtonCancel.ForeColor = Theme.Light.ButtonForeColor;
			this.InputButtonCancel.FlatAppearance.BorderColor = Theme.Light.ButtonFlatColor;
			this.InputTextBox.BackColor = Theme.Light.TextBoxBackColor;
			this.InputTextBox.ForeColor = Theme.Light.TextBoxForeColor;
			this.InputLabel.ForeColor = Theme.Light.LabelTextColor;
		}

		private void ToggleDarkTheme()
		{
			this.BackColor = Theme.Dark.MainBackColor;
			this.ForeColor = Theme.Dark.MainForeColor;
			this.InputButtonOK.BackColor = Theme.Dark.ButtonBackColor;
			this.InputButtonOK.ForeColor = Theme.Dark.ButtonForeColor;
			this.InputButtonOK.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.InputButtonCancel.BackColor = Theme.Dark.ButtonBackColor;
			this.InputButtonCancel.ForeColor = Theme.Dark.ButtonForeColor;
			this.InputButtonCancel.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.InputTextBox.BackColor = Theme.Dark.TextBoxBackColor;
			this.InputTextBox.ForeColor = Theme.Dark.TextBoxForeColor;
			this.InputLabel.ForeColor = Theme.Dark.LabelTextColor;
		}

		private void InputButtonOK_Click(object sender, EventArgs e)
		{
			if (!this._input_check?.Invoke(this.InputTextBox.Text) ?? false)
			{

				MessageBox.Show(this._error_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			this.Value = this.InputTextBox.Text;
			this.Close();
		}

		private void InputButtonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
