using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
			this.InputLabel.Text = text;
			this._input_check = inputcheck;
			this._error_message = error;
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
