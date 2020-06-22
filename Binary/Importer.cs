using System;
using System.Windows.Forms;



namespace Binary
{
	public partial class Importer : Form
	{
		public int SerializationIndex { get; private set; } = 0;

		public Importer()
		{
			this.InitializeComponent();
			this.ToggleTheme();
			this.ImporterType.SelectedIndex = 0;

			string tip =
				"Serialazed import type of the collection. See Readme/Tutorials for more details.";
			this.ImporterToolTip.SetToolTip(this.ImporterLabel, tip);
			this.ImporterToolTip.SetToolTip(this.ImporterType, tip);
		}

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.ImporterButton.BackColor = Theme.ButtonBackColor;
			this.ImporterButton.ForeColor = Theme.ButtonForeColor;
			this.ImporterButton.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.ImporterLabel.BackColor = Theme.MainBackColor;
			this.ImporterLabel.ForeColor = Theme.LabelTextColor;
			this.ImporterType.BackColor = Theme.TextBoxBackColor;
			this.ImporterType.ForeColor = Theme.TextBoxForeColor;
		}

		private void ImporterButton_Click(object sender, EventArgs e)
		{
			this.SerializationIndex = this.ImporterType.SelectedIndex;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
