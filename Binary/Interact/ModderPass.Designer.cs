namespace Binary.Interact
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
			this.ModderPassPictureBox = new System.Windows.Forms.PictureBox();
			this.ModderPassToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.ModderPassButtonConfirm = new System.Windows.Forms.Button();
			this.ModderPassButtonExit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ModderPassLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ModderPassPictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ModderPassTextBox
			// 
			this.ModderPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ModderPassTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ModderPassTextBox.Location = new System.Drawing.Point(12, 139);
			this.ModderPassTextBox.Name = "ModderPassTextBox";
			this.ModderPassTextBox.ShortcutsEnabled = false;
			this.ModderPassTextBox.Size = new System.Drawing.Size(461, 27);
			this.ModderPassTextBox.TabIndex = 0;
			this.ModderPassTextBox.UseSystemPasswordChar = true;
			this.ModderPassTextBox.WordWrap = false;
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
			this.ModderPassButtonConfirm.Location = new System.Drawing.Point(39, 172);
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
			this.ModderPassButtonExit.Location = new System.Drawing.Point(245, 172);
			this.ModderPassButtonExit.Name = "ModderPassButtonExit";
			this.ModderPassButtonExit.Size = new System.Drawing.Size(200, 35);
			this.ModderPassButtonExit.TabIndex = 3;
			this.ModderPassButtonExit.Text = "Exit";
			this.ModderPassButtonExit.UseVisualStyleBackColor = false;
			this.ModderPassButtonExit.Click += new System.EventHandler(this.ModderPassButtonExit_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.ModderPassLabel);
			this.panel1.Location = new System.Drawing.Point(12, 11);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 122);
			this.panel1.TabIndex = 4;
			// 
			// ModderPassLabel
			// 
			this.ModderPassLabel.AutoSize = true;
			this.ModderPassLabel.Location = new System.Drawing.Point(0, 1);
			this.ModderPassLabel.Name = "ModderPassLabel";
			this.ModderPassLabel.Size = new System.Drawing.Size(342, 105);
			this.ModderPassLabel.TabIndex = 0;
			this.ModderPassLabel.Text = resources.GetString("ModderPassLabel.Text");
			// 
			// ModderPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(485, 216);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ModderPassButtonExit);
			this.Controls.Add(this.ModderPassButtonConfirm);
			this.Controls.Add(this.ModderPassPictureBox);
			this.Controls.Add(this.ModderPassTextBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ModderPass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Protection";
			((System.ComponentModel.ISupportInitialize)(this.ModderPassPictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ModderPassTextBox;
		private System.Windows.Forms.PictureBox ModderPassPictureBox;
		private System.Windows.Forms.ToolTip ModderPassToolTip;
		private System.Windows.Forms.Button ModderPassButtonConfirm;
		private System.Windows.Forms.Button ModderPassButtonExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label ModderPassLabel;
	}
}