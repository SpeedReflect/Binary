namespace Binary.Interact
{
	partial class AttribCreator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttribCreator));
			this.AttribTypeComboBox = new System.Windows.Forms.ComboBox();
			this.AttribKeyComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AttribButtonCreate = new System.Windows.Forms.Button();
			this.AttribButtonHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AttribTypeComboBox
			// 
			this.AttribTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AttribTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AttribTypeComboBox.FormattingEnabled = true;
			this.AttribTypeComboBox.Location = new System.Drawing.Point(49, 12);
			this.AttribTypeComboBox.Name = "AttribTypeComboBox";
			this.AttribTypeComboBox.Size = new System.Drawing.Size(257, 23);
			this.AttribTypeComboBox.TabIndex = 0;
			this.AttribTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AttribTypeComboBox_SelectedIndexChanged);
			// 
			// AttribKeyComboBox
			// 
			this.AttribKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AttribKeyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AttribKeyComboBox.FormattingEnabled = true;
			this.AttribKeyComboBox.Location = new System.Drawing.Point(49, 44);
			this.AttribKeyComboBox.Name = "AttribKeyComboBox";
			this.AttribKeyComboBox.Size = new System.Drawing.Size(257, 23);
			this.AttribKeyComboBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Key";
			// 
			// AttribButtonCreate
			// 
			this.AttribButtonCreate.AutoSize = true;
			this.AttribButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AttribButtonCreate.Location = new System.Drawing.Point(316, 41);
			this.AttribButtonCreate.Name = "AttribButtonCreate";
			this.AttribButtonCreate.Size = new System.Drawing.Size(86, 27);
			this.AttribButtonCreate.TabIndex = 3;
			this.AttribButtonCreate.Text = "Create";
			this.AttribButtonCreate.UseVisualStyleBackColor = true;
			this.AttribButtonCreate.Click += new System.EventHandler(this.AttribButtonCreate_Click);
			// 
			// AttribButtonHelp
			// 
			this.AttribButtonHelp.AutoSize = true;
			this.AttribButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AttribButtonHelp.Location = new System.Drawing.Point(316, 10);
			this.AttribButtonHelp.Name = "AttribButtonHelp";
			this.AttribButtonHelp.Size = new System.Drawing.Size(86, 27);
			this.AttribButtonHelp.TabIndex = 3;
			this.AttribButtonHelp.Text = "Help";
			this.AttribButtonHelp.UseVisualStyleBackColor = true;
			this.AttribButtonHelp.Click += new System.EventHandler(this.AttribButtonHelp_Click);
			// 
			// AttribCreator
			// 
			this.AcceptButton = this.AttribButtonCreate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(413, 80);
			this.Controls.Add(this.AttribButtonHelp);
			this.Controls.Add(this.AttribButtonCreate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AttribKeyComboBox);
			this.Controls.Add(this.AttribTypeComboBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AttribCreator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attribute Creator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox AttribTypeComboBox;
		private System.Windows.Forms.ComboBox AttribKeyComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AttribButtonCreate;
		private System.Windows.Forms.Button AttribButtonHelp;
	}
}