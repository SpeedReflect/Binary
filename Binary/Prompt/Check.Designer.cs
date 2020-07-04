namespace Binary.Prompt
{
	partial class Check
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
			this.CheckBoxSelection = new System.Windows.Forms.CheckBox();
			this.CheckButtonCancel = new System.Windows.Forms.Button();
			this.CheckButtonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CheckBoxSelection
			// 
			this.CheckBoxSelection.Location = new System.Drawing.Point(12, 12);
			this.CheckBoxSelection.Name = "CheckBoxSelection";
			this.CheckBoxSelection.Size = new System.Drawing.Size(344, 44);
			this.CheckBoxSelection.TabIndex = 0;
			this.CheckBoxSelection.Text = "Custom Text";
			// 
			// CheckButtonCancel
			// 
			this.CheckButtonCancel.AutoSize = true;
			this.CheckButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CheckButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CheckButtonCancel.Location = new System.Drawing.Point(262, 62);
			this.CheckButtonCancel.Name = "CheckButtonCancel";
			this.CheckButtonCancel.Size = new System.Drawing.Size(94, 27);
			this.CheckButtonCancel.TabIndex = 1;
			this.CheckButtonCancel.Text = "Cancel";
			this.CheckButtonCancel.UseVisualStyleBackColor = true;
			this.CheckButtonCancel.Click += new System.EventHandler(this.CheckButtonCancel_Click);
			// 
			// CheckButtonOK
			// 
			this.CheckButtonOK.AutoSize = true;
			this.CheckButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CheckButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CheckButtonOK.Location = new System.Drawing.Point(162, 62);
			this.CheckButtonOK.Name = "CheckButtonOK";
			this.CheckButtonOK.Size = new System.Drawing.Size(94, 27);
			this.CheckButtonOK.TabIndex = 1;
			this.CheckButtonOK.Text = "OK";
			this.CheckButtonOK.UseVisualStyleBackColor = true;
			this.CheckButtonOK.Click += new System.EventHandler(this.CheckButtonOK_Click);
			// 
			// Check
			// 
			this.AcceptButton = this.CheckButtonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.CheckButtonCancel;
			this.ClientSize = new System.Drawing.Size(368, 99);
			this.Controls.Add(this.CheckButtonOK);
			this.Controls.Add(this.CheckButtonCancel);
			this.Controls.Add(this.CheckBoxSelection);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Check";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prompt Selection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox CheckBoxSelection;
		private System.Windows.Forms.Button CheckButtonCancel;
		private System.Windows.Forms.Button CheckButtonOK;
	}
}