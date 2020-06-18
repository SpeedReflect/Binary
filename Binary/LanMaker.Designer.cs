namespace Binary
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
			this.LanMakerUsage = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LanMakerGame = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LanMakerLabelDir = new System.Windows.Forms.Label();
			this.LanMakerButtonDir = new System.Windows.Forms.Button();
			this.LanMakerButtonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LanMakerUsage
			// 
			this.LanMakerUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanMakerUsage.FormattingEnabled = true;
			this.LanMakerUsage.Items.AddRange(new object[] {
            "User",
            "Modder"});
			this.LanMakerUsage.Location = new System.Drawing.Point(57, 12);
			this.LanMakerUsage.Name = "LanMakerUsage";
			this.LanMakerUsage.Size = new System.Drawing.Size(305, 23);
			this.LanMakerUsage.TabIndex = 2;
			this.LanMakerUsage.SelectionChangeCommitted += new System.EventHandler(this.LanMakerUsage_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usage";
			// 
			// LanMakerGame
			// 
			this.LanMakerGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanMakerGame.FormattingEnabled = true;
			this.LanMakerGame.Items.AddRange(new object[] {
            "Carbon",
            "MostWanted",
            "Prostreet",
            "Undercover",
            "Underground1",
            "Underground2"});
			this.LanMakerGame.Location = new System.Drawing.Point(57, 46);
			this.LanMakerGame.Name = "LanMakerGame";
			this.LanMakerGame.Size = new System.Drawing.Size(305, 23);
			this.LanMakerGame.TabIndex = 4;
			this.LanMakerGame.SelectionChangeCommitted += new System.EventHandler(this.LanMakerGame_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Game";
			// 
			// LanMakerLabelDir
			// 
			this.LanMakerLabelDir.AutoSize = true;
			this.LanMakerLabelDir.Location = new System.Drawing.Point(13, 81);
			this.LanMakerLabelDir.Name = "LanMakerLabelDir";
			this.LanMakerLabelDir.Size = new System.Drawing.Size(148, 15);
			this.LanMakerLabelDir.TabIndex = 7;
			this.LanMakerLabelDir.Text = "Directory was not selected.";
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
			this.LanMakerButtonSave.Location = new System.Drawing.Point(368, 43);
			this.LanMakerButtonSave.Name = "LanMakerButtonSave";
			this.LanMakerButtonSave.Size = new System.Drawing.Size(110, 27);
			this.LanMakerButtonSave.TabIndex = 6;
			this.LanMakerButtonSave.Text = "Save";
			this.LanMakerButtonSave.UseVisualStyleBackColor = true;
			this.LanMakerButtonSave.Click += new System.EventHandler(this.LanMakerButtonSave_Click);
			// 
			// LanMaker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 106);
			this.Controls.Add(this.LanMakerButtonSave);
			this.Controls.Add(this.LanMakerButtonDir);
			this.Controls.Add(this.LanMakerLabelDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LanMakerGame);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LanMakerUsage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "LanMaker";
			this.Text = "Launcher Maker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox LanMakerUsage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox LanMakerGame;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LanMakerLabelDir;
		private System.Windows.Forms.Button LanMakerButtonDir;
		private System.Windows.Forms.Button LanMakerButtonSave;
	}
}