namespace Binary.Interact
{
	partial class LanMaker
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanMaker));
			this.LanMakerUsage = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LanMakerGame = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LanMakerButtonDir = new System.Windows.Forms.Button();
			this.LanMakerButtonSave = new System.Windows.Forms.Button();
			this.LanMakerTextBoxDir = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.LanMakerButtonHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LanMakerUsage
			// 
			this.LanMakerUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanMakerUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LanMakerUsage.FormattingEnabled = true;
			this.LanMakerUsage.Items.AddRange(new object[] {
            "User",
            "Modder"});
			this.LanMakerUsage.Location = new System.Drawing.Point(57, 43);
			this.LanMakerUsage.Name = "LanMakerUsage";
			this.LanMakerUsage.Size = new System.Drawing.Size(305, 23);
			this.LanMakerUsage.TabIndex = 2;
			this.LanMakerUsage.SelectionChangeCommitted += new System.EventHandler(this.LanMakerUsage_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usage";
			// 
			// LanMakerGame
			// 
			this.LanMakerGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanMakerGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LanMakerGame.FormattingEnabled = true;
			this.LanMakerGame.Items.AddRange(new object[] {
            "Carbon",
            "MostWanted",
            "Prostreet",
            "Undercover",
            "Underground1",
            "Underground2"});
			this.LanMakerGame.Location = new System.Drawing.Point(57, 77);
			this.LanMakerGame.Name = "LanMakerGame";
			this.LanMakerGame.Size = new System.Drawing.Size(305, 23);
			this.LanMakerGame.TabIndex = 4;
			this.LanMakerGame.SelectionChangeCommitted += new System.EventHandler(this.LanMakerGame_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Game";
			// 
			// LanMakerButtonDir
			// 
			this.LanMakerButtonDir.AutoSize = true;
			this.LanMakerButtonDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LanMakerButtonDir.Location = new System.Drawing.Point(368, 9);
			this.LanMakerButtonDir.Name = "LanMakerButtonDir";
			this.LanMakerButtonDir.Size = new System.Drawing.Size(110, 27);
			this.LanMakerButtonDir.TabIndex = 6;
			this.LanMakerButtonDir.Text = "Select Directory";
			this.LanMakerButtonDir.UseVisualStyleBackColor = true;
			this.LanMakerButtonDir.Click += new System.EventHandler(this.LanMakerButtonDir_Click);
			// 
			// LanMakerButtonSave
			// 
			this.LanMakerButtonSave.AutoSize = true;
			this.LanMakerButtonSave.Enabled = false;
			this.LanMakerButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LanMakerButtonSave.Location = new System.Drawing.Point(368, 74);
			this.LanMakerButtonSave.Name = "LanMakerButtonSave";
			this.LanMakerButtonSave.Size = new System.Drawing.Size(110, 27);
			this.LanMakerButtonSave.TabIndex = 6;
			this.LanMakerButtonSave.Text = "Save";
			this.LanMakerButtonSave.UseVisualStyleBackColor = true;
			this.LanMakerButtonSave.Click += new System.EventHandler(this.LanMakerButtonSave_Click);
			// 
			// LanMakerTextBoxDir
			// 
			this.LanMakerTextBoxDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LanMakerTextBoxDir.Location = new System.Drawing.Point(57, 12);
			this.LanMakerTextBoxDir.Name = "LanMakerTextBoxDir";
			this.LanMakerTextBoxDir.Size = new System.Drawing.Size(305, 23);
			this.LanMakerTextBoxDir.TabIndex = 8;
			this.LanMakerTextBoxDir.TextChanged += new System.EventHandler(this.LanMakerTextBoxDir_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Path";
			// 
			// LanMakerButtonHelp
			// 
			this.LanMakerButtonHelp.AutoSize = true;
			this.LanMakerButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LanMakerButtonHelp.Location = new System.Drawing.Point(368, 41);
			this.LanMakerButtonHelp.Name = "LanMakerButtonHelp";
			this.LanMakerButtonHelp.Size = new System.Drawing.Size(110, 27);
			this.LanMakerButtonHelp.TabIndex = 6;
			this.LanMakerButtonHelp.Text = "Help";
			this.LanMakerButtonHelp.UseVisualStyleBackColor = true;
			this.LanMakerButtonHelp.Click += new System.EventHandler(this.LanMakerButtonHelp_Click);
			// 
			// LanMaker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(490, 112);
			this.Controls.Add(this.LanMakerButtonHelp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LanMakerTextBoxDir);
			this.Controls.Add(this.LanMakerButtonSave);
			this.Controls.Add(this.LanMakerButtonDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LanMakerGame);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LanMakerUsage);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LanMaker";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Launcher Maker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox LanMakerUsage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox LanMakerGame;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LanMakerButtonDir;
		private System.Windows.Forms.Button LanMakerButtonSave;
		private System.Windows.Forms.TextBox LanMakerTextBoxDir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button LanMakerButtonHelp;
	}
}