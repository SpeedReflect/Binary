namespace Binary.Interact
{
	partial class StringCreator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringCreator));
			this.StringTextBoxText = new System.Windows.Forms.TextBox();
			this.StringTextBoxLabel = new System.Windows.Forms.TextBox();
			this.StringTextBoxKey = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.StringCheckBoxCustom = new System.Windows.Forms.CheckBox();
			this.StringCheckBoxReversed = new System.Windows.Forms.CheckBox();
			this.StringButtonCancel = new System.Windows.Forms.Button();
			this.StringButtonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StringTextBoxText
			// 
			this.StringTextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StringTextBoxText.Location = new System.Drawing.Point(12, 70);
			this.StringTextBoxText.Multiline = true;
			this.StringTextBoxText.Name = "StringTextBoxText";
			this.StringTextBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.StringTextBoxText.Size = new System.Drawing.Size(501, 132);
			this.StringTextBoxText.TabIndex = 0;
			// 
			// StringTextBoxLabel
			// 
			this.StringTextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StringTextBoxLabel.Location = new System.Drawing.Point(53, 41);
			this.StringTextBoxLabel.Name = "StringTextBoxLabel";
			this.StringTextBoxLabel.Size = new System.Drawing.Size(294, 23);
			this.StringTextBoxLabel.TabIndex = 1;
			this.StringTextBoxLabel.TextChanged += new System.EventHandler(this.StringTextBoxLabel_TextChanged);
			// 
			// StringTextBoxKey
			// 
			this.StringTextBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StringTextBoxKey.Enabled = false;
			this.StringTextBoxKey.Location = new System.Drawing.Point(53, 12);
			this.StringTextBoxKey.Name = "StringTextBoxKey";
			this.StringTextBoxKey.Size = new System.Drawing.Size(294, 23);
			this.StringTextBoxKey.TabIndex = 1;
			this.StringTextBoxKey.Validating += new System.ComponentModel.CancelEventHandler(this.StringTextBoxKey_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Key";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Label";
			// 
			// StringCheckBoxCustom
			// 
			this.StringCheckBoxCustom.Location = new System.Drawing.Point(362, 12);
			this.StringCheckBoxCustom.Name = "StringCheckBoxCustom";
			this.StringCheckBoxCustom.Size = new System.Drawing.Size(151, 23);
			this.StringCheckBoxCustom.TabIndex = 3;
			this.StringCheckBoxCustom.Text = "Enable custom key";
			this.StringCheckBoxCustom.CheckedChanged += new System.EventHandler(this.StringCheckBoxCustom_CheckedChanged);
			// 
			// StringCheckBoxReversed
			// 
			this.StringCheckBoxReversed.Location = new System.Drawing.Point(362, 41);
			this.StringCheckBoxReversed.Name = "StringCheckBoxReversed";
			this.StringCheckBoxReversed.Size = new System.Drawing.Size(151, 23);
			this.StringCheckBoxReversed.TabIndex = 3;
			this.StringCheckBoxReversed.Text = "Show reversed key";
			this.StringCheckBoxReversed.CheckedChanged += new System.EventHandler(this.StringCheckBoxReversed_CheckedChanged);
			// 
			// StringButtonCancel
			// 
			this.StringButtonCancel.AutoSize = true;
			this.StringButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.StringButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StringButtonCancel.Location = new System.Drawing.Point(413, 210);
			this.StringButtonCancel.Name = "StringButtonCancel";
			this.StringButtonCancel.Size = new System.Drawing.Size(100, 27);
			this.StringButtonCancel.TabIndex = 4;
			this.StringButtonCancel.Text = "Cancel";
			this.StringButtonCancel.UseVisualStyleBackColor = true;
			this.StringButtonCancel.Click += new System.EventHandler(this.StringButtonCancel_Click);
			// 
			// StringButtonOK
			// 
			this.StringButtonOK.AutoSize = true;
			this.StringButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.StringButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StringButtonOK.Location = new System.Drawing.Point(307, 210);
			this.StringButtonOK.Name = "StringButtonOK";
			this.StringButtonOK.Size = new System.Drawing.Size(100, 27);
			this.StringButtonOK.TabIndex = 4;
			this.StringButtonOK.Text = "OK";
			this.StringButtonOK.UseVisualStyleBackColor = true;
			this.StringButtonOK.Click += new System.EventHandler(this.StringButtonOK_Click);
			// 
			// StringCreator
			// 
			this.AcceptButton = this.StringButtonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.StringButtonCancel;
			this.ClientSize = new System.Drawing.Size(529, 244);
			this.Controls.Add(this.StringButtonOK);
			this.Controls.Add(this.StringButtonCancel);
			this.Controls.Add(this.StringCheckBoxReversed);
			this.Controls.Add(this.StringCheckBoxCustom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StringTextBoxKey);
			this.Controls.Add(this.StringTextBoxLabel);
			this.Controls.Add(this.StringTextBoxText);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "StringCreator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StringCreator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox StringTextBoxText;
		private System.Windows.Forms.TextBox StringTextBoxLabel;
		private System.Windows.Forms.TextBox StringTextBoxKey;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox StringCheckBoxCustom;
		private System.Windows.Forms.CheckBox StringCheckBoxReversed;
		private System.Windows.Forms.Button StringButtonCancel;
		private System.Windows.Forms.Button StringButtonOK;
	}
}