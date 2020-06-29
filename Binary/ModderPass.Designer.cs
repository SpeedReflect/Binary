namespace Binary
{
	partial class ModderPass
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModderPass));
			this.ModderPassTextBox = new System.Windows.Forms.TextBox();
			this.ModderPassLabel = new System.Windows.Forms.Label();
			this.ModderPassPictureBox = new System.Windows.Forms.PictureBox();
			this.ModderPassToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.ModderPassButtonConfirm = new System.Windows.Forms.Button();
			this.ModderPassButtonExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ModderPassPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ModderPassTextBox
			// 
			this.ModderPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ModderPassTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ModderPassTextBox.Location = new System.Drawing.Point(12, 117);
			this.ModderPassTextBox.Name = "ModderPassTextBox";
			this.ModderPassTextBox.ShortcutsEnabled = false;
			this.ModderPassTextBox.Size = new System.Drawing.Size(461, 27);
			this.ModderPassTextBox.TabIndex = 0;
			this.ModderPassTextBox.UseSystemPasswordChar = true;
			this.ModderPassTextBox.WordWrap = false;
			// 
			// ModderPassLabel
			// 
			this.ModderPassLabel.AutoSize = true;
			this.ModderPassLabel.Location = new System.Drawing.Point(12, 9);
			this.ModderPassLabel.Name = "ModderPassLabel";
			this.ModderPassLabel.Size = new System.Drawing.Size(365, 105);
			this.ModderPassLabel.TabIndex = 1;
			this.ModderPassLabel.Text = resources.GetString("ModderPassLabel.Text");
			// 
			// ModderPassPictureBox
			// 
			this.ModderPassPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ModderPassPictureBox.Location = new System.Drawing.Point(383, 12);
			this.ModderPassPictureBox.Name = "ModderPassPictureBox";
			this.ModderPassPictureBox.Size = new System.Drawing.Size(90, 90);
			this.ModderPassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ModderPassPictureBox.TabIndex = 2;
			this.ModderPassPictureBox.TabStop = false;
			this.ModderPassPictureBox.Click += new System.EventHandler(this.ModderPassPictureBox_Click);
			// 
			// ModderPassButtonConfirm
			// 
			this.ModderPassButtonConfirm.AutoSize = true;
			this.ModderPassButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ModderPassButtonConfirm.Location = new System.Drawing.Point(39, 150);
			this.ModderPassButtonConfirm.Name = "ModderPassButtonConfirm";
			this.ModderPassButtonConfirm.Size = new System.Drawing.Size(200, 35);
			this.ModderPassButtonConfirm.TabIndex = 3;
			this.ModderPassButtonConfirm.Text = "Confirm";
			this.ModderPassButtonConfirm.UseVisualStyleBackColor = false;
			this.ModderPassButtonConfirm.Click += new System.EventHandler(this.ModderPassButtonConfirm_Click);
			// 
			// ModderPassButtonExit
			// 
			this.ModderPassButtonExit.AutoSize = true;
			this.ModderPassButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ModderPassButtonExit.Location = new System.Drawing.Point(245, 150);
			this.ModderPassButtonExit.Name = "ModderPassButtonExit";
			this.ModderPassButtonExit.Size = new System.Drawing.Size(200, 35);
			this.ModderPassButtonExit.TabIndex = 3;
			this.ModderPassButtonExit.Text = "Exit";
			this.ModderPassButtonExit.UseVisualStyleBackColor = false;
			this.ModderPassButtonExit.Click += new System.EventHandler(this.ModderPassButtonExit_Click);
			// 
			// ModderPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(485, 197);
			this.Controls.Add(this.ModderPassButtonExit);
			this.Controls.Add(this.ModderPassButtonConfirm);
			this.Controls.Add(this.ModderPassPictureBox);
			this.Controls.Add(this.ModderPassLabel);
			this.Controls.Add(this.ModderPassTextBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ModderPass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Protection";
			((System.ComponentModel.ISupportInitialize)(this.ModderPassPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ModderPassTextBox;
		private System.Windows.Forms.Label ModderPassLabel;
		private System.Windows.Forms.PictureBox ModderPassPictureBox;
		private System.Windows.Forms.ToolTip ModderPassToolTip;
		private System.Windows.Forms.Button ModderPassButtonConfirm;
		private System.Windows.Forms.Button ModderPassButtonExit;
	}
}