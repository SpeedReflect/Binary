namespace Binary
{
	partial class IntroUI
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
			this.IntroPanelModder = new System.Windows.Forms.Panel();
			this.IntroPictureModder = new System.Windows.Forms.PictureBox();
			this.IntroPanelUser = new System.Windows.Forms.Panel();
			this.IntroPictureUser = new System.Windows.Forms.PictureBox();
			this.IntroToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.IntroPanelModder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IntroPictureModder)).BeginInit();
			this.IntroPanelUser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IntroPictureUser)).BeginInit();
			this.SuspendLayout();
			// 
			// IntroPanelModder
			// 
			this.IntroPanelModder.Controls.Add(this.IntroPictureModder);
			this.IntroPanelModder.Location = new System.Drawing.Point(322, 77);
			this.IntroPanelModder.Name = "IntroPanelModder";
			this.IntroPanelModder.Size = new System.Drawing.Size(300, 300);
			this.IntroPanelModder.TabIndex = 0;
			// 
			// IntroPictureModder
			// 
			this.IntroPictureModder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IntroPictureModder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IntroPictureModder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IntroPictureModder.Location = new System.Drawing.Point(0, 0);
			this.IntroPictureModder.Name = "IntroPictureModder";
			this.IntroPictureModder.Size = new System.Drawing.Size(300, 300);
			this.IntroPictureModder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.IntroPictureModder.TabIndex = 0;
			this.IntroPictureModder.TabStop = false;
			this.IntroPictureModder.Click += new System.EventHandler(this.IntroPictureModder_Click);
			// 
			// IntroPanelUser
			// 
			this.IntroPanelUser.Controls.Add(this.IntroPictureUser);
			this.IntroPanelUser.Location = new System.Drawing.Point(16, 77);
			this.IntroPanelUser.Name = "IntroPanelUser";
			this.IntroPanelUser.Size = new System.Drawing.Size(300, 300);
			this.IntroPanelUser.TabIndex = 1;
			// 
			// IntroPictureUser
			// 
			this.IntroPictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IntroPictureUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IntroPictureUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IntroPictureUser.Location = new System.Drawing.Point(0, 0);
			this.IntroPictureUser.Name = "IntroPictureUser";
			this.IntroPictureUser.Size = new System.Drawing.Size(300, 300);
			this.IntroPictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.IntroPictureUser.TabIndex = 0;
			this.IntroPictureUser.TabStop = false;
			this.IntroPictureUser.Click += new System.EventHandler(this.IntroPictureUser_Click);
			// 
			// IntroUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 388);
			this.Controls.Add(this.IntroPanelUser);
			this.Controls.Add(this.IntroPanelModder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "IntroUI";
			this.Text = "Binary by MaxHwoy";
			this.IntroPanelModder.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.IntroPictureModder)).EndInit();
			this.IntroPanelUser.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.IntroPictureUser)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel IntroPanelModder;
		private System.Windows.Forms.Panel IntroPanelUser;
		private System.Windows.Forms.PictureBox IntroPictureModder;
		private System.Windows.Forms.PictureBox IntroPictureUser;
		private System.Windows.Forms.ToolTip IntroToolTip;
	}
}