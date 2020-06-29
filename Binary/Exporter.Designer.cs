namespace Binary
{
	partial class Exporter
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
			this.ExportSerialized = new System.Windows.Forms.CheckBox();
			this.ExporterButton = new System.Windows.Forms.Button();
			this.ExporterToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// ExportSerialized
			// 
			this.ExportSerialized.Checked = true;
			this.ExportSerialized.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ExportSerialized.Location = new System.Drawing.Point(13, 14);
			this.ExportSerialized.Name = "ExportSerialized";
			this.ExportSerialized.Size = new System.Drawing.Size(89, 23);
			this.ExportSerialized.TabIndex = 0;
			this.ExportSerialized.Text = "Serialized";
			// 
			// ExporterButton
			// 
			this.ExporterButton.AutoSize = true;
			this.ExporterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExporterButton.Location = new System.Drawing.Point(108, 12);
			this.ExporterButton.Name = "ExporterButton";
			this.ExporterButton.Size = new System.Drawing.Size(94, 27);
			this.ExporterButton.TabIndex = 1;
			this.ExporterButton.Text = "Export";
			this.ExporterButton.UseVisualStyleBackColor = true;
			this.ExporterButton.Click += new System.EventHandler(this.ExporterButton_Click);
			// 
			// Exporter
			// 
			this.AcceptButton = this.ExporterButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(214, 48);
			this.Controls.Add(this.ExporterButton);
			this.Controls.Add(this.ExportSerialized);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Exporter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exporter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox ExportSerialized;
		private System.Windows.Forms.Button ExporterButton;
		private System.Windows.Forms.ToolTip ExporterToolTip;
	}
}