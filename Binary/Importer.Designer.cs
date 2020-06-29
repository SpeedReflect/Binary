namespace Binary
{
	partial class Importer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importer));
			this.ImporterType = new System.Windows.Forms.ComboBox();
			this.ImporterLabel = new System.Windows.Forms.Label();
			this.ImporterButton = new System.Windows.Forms.Button();
			this.ImporterToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// ImporterType
			// 
			this.ImporterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ImporterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ImporterType.FormattingEnabled = true;
			this.ImporterType.Items.AddRange(new object[] {
            "Negate",
            "Synchronize",
            "Override"});
			this.ImporterType.Location = new System.Drawing.Point(49, 12);
			this.ImporterType.Name = "ImporterType";
			this.ImporterType.Size = new System.Drawing.Size(176, 23);
			this.ImporterType.TabIndex = 0;
			// 
			// ImporterLabel
			// 
			this.ImporterLabel.AutoSize = true;
			this.ImporterLabel.Location = new System.Drawing.Point(12, 15);
			this.ImporterLabel.Name = "ImporterLabel";
			this.ImporterLabel.Size = new System.Drawing.Size(31, 15);
			this.ImporterLabel.TabIndex = 1;
			this.ImporterLabel.Text = "Type";
			// 
			// ImporterButton
			// 
			this.ImporterButton.AutoSize = true;
			this.ImporterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ImporterButton.Location = new System.Drawing.Point(231, 9);
			this.ImporterButton.Name = "ImporterButton";
			this.ImporterButton.Size = new System.Drawing.Size(94, 27);
			this.ImporterButton.TabIndex = 2;
			this.ImporterButton.Text = "Import";
			this.ImporterButton.UseVisualStyleBackColor = true;
			this.ImporterButton.Click += new System.EventHandler(this.ImporterButton_Click);
			// 
			// Importer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(341, 50);
			this.Controls.Add(this.ImporterButton);
			this.Controls.Add(this.ImporterLabel);
			this.Controls.Add(this.ImporterType);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Importer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Importer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ImporterType;
		private System.Windows.Forms.Label ImporterLabel;
		private System.Windows.Forms.Button ImporterButton;
		private System.Windows.Forms.ToolTip ImporterToolTip;
	}
}