namespace Binary.Prompt
{
	partial class Combo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combo));
			this.ComboButtonCancel = new System.Windows.Forms.Button();
			this.ComboButtonOK = new System.Windows.Forms.Button();
			this.ComboBoxSelection = new System.Windows.Forms.ComboBox();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ComboButtonCancel
			// 
			this.ComboButtonCancel.AutoSize = true;
			this.ComboButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ComboButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboButtonCancel.Location = new System.Drawing.Point(262, 76);
			this.ComboButtonCancel.Name = "ComboButtonCancel";
			this.ComboButtonCancel.Size = new System.Drawing.Size(94, 27);
			this.ComboButtonCancel.TabIndex = 1;
			this.ComboButtonCancel.Text = "Cancel";
			this.ComboButtonCancel.UseVisualStyleBackColor = true;
			this.ComboButtonCancel.Click += new System.EventHandler(this.ComboButtonCancel_Click);
			// 
			// ComboButtonOK
			// 
			this.ComboButtonOK.AutoSize = true;
			this.ComboButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.ComboButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboButtonOK.Location = new System.Drawing.Point(162, 76);
			this.ComboButtonOK.Name = "ComboButtonOK";
			this.ComboButtonOK.Size = new System.Drawing.Size(94, 27);
			this.ComboButtonOK.TabIndex = 1;
			this.ComboButtonOK.Text = "OK";
			this.ComboButtonOK.UseVisualStyleBackColor = true;
			this.ComboButtonOK.Click += new System.EventHandler(this.ComboButtonOK_Click);
			// 
			// ComboBoxSelection
			// 
			this.ComboBoxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxSelection.FormattingEnabled = true;
			this.ComboBoxSelection.Location = new System.Drawing.Point(12, 47);
			this.ComboBoxSelection.Name = "ComboBoxSelection";
			this.ComboBoxSelection.Size = new System.Drawing.Size(344, 23);
			this.ComboBoxSelection.TabIndex = 2;
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Location = new System.Drawing.Point(12, 19);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(73, 15);
			this.DescriptionLabel.TabIndex = 3;
			this.DescriptionLabel.Text = "Custom Text";
			// 
			// Combo
			// 
			this.AcceptButton = this.ComboButtonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.ComboButtonCancel;
			this.ClientSize = new System.Drawing.Size(368, 115);
			this.Controls.Add(this.DescriptionLabel);
			this.Controls.Add(this.ComboBoxSelection);
			this.Controls.Add(this.ComboButtonOK);
			this.Controls.Add(this.ComboButtonCancel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Combo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prompt Selection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button ComboButtonCancel;
		private System.Windows.Forms.Button ComboButtonOK;
		private System.Windows.Forms.ComboBox ComboBoxSelection;
		private System.Windows.Forms.Label DescriptionLabel;
	}
}