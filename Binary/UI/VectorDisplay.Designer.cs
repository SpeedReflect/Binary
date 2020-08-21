namespace Binary.UI
{
	partial class VectorDisplay
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
			this.VinylBrowser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// VinylBrowser
			// 
			this.VinylBrowser.Location = new System.Drawing.Point(233, 149);
			this.VinylBrowser.Name = "VinylBrowser";
			this.VinylBrowser.Size = new System.Drawing.Size(344, 186);
			this.VinylBrowser.TabIndex = 0;
			// 
			// VectorDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.VinylBrowser);
			this.Name = "VectorDisplay";
			this.Text = "VectorDisplay";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser VinylBrowser;
	}
}