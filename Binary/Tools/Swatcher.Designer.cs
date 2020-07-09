namespace Binary.Tools
{
	partial class Swatcher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swatcher));
			this.GroupBoxRGB = new System.Windows.Forms.GroupBox();
			this.LabelBlue = new System.Windows.Forms.Label();
			this.LabelGreen = new System.Windows.Forms.Label();
			this.LabelRed = new System.Windows.Forms.Label();
			this.TrackBar_Blue = new System.Windows.Forms.TrackBar();
			this.TrackBar_Green = new System.Windows.Forms.TrackBar();
			this.TrackBar_Red = new System.Windows.Forms.TrackBar();
			this.OpenWindowsColorForm = new System.Windows.Forms.Button();
			this.ColorPreview = new System.Windows.Forms.PictureBox();
			this.SwatchDialog = new System.Windows.Forms.ColorDialog();
			this.GroupBoxSwatch = new System.Windows.Forms.GroupBox();
			this.CopyBrightnessValue = new System.Windows.Forms.Button();
			this.CopySaturationValue = new System.Windows.Forms.Button();
			this.CopyPaintSwatchValue = new System.Windows.Forms.Button();
			this.TextBoxBrightness = new System.Windows.Forms.TextBox();
			this.TextBoxSaturation = new System.Windows.Forms.TextBox();
			this.TextBoxPaintSwatch = new System.Windows.Forms.TextBox();
			this.LabelBrightness = new System.Windows.Forms.Label();
			this.LabelSaturation = new System.Windows.Forms.Label();
			this.LabelPaintSwatch = new System.Windows.Forms.Label();
			this.GroupBoxRGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Blue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Red)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).BeginInit();
			this.GroupBoxSwatch.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBoxRGB
			// 
			this.GroupBoxRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBoxRGB.Controls.Add(this.LabelBlue);
			this.GroupBoxRGB.Controls.Add(this.LabelGreen);
			this.GroupBoxRGB.Controls.Add(this.LabelRed);
			this.GroupBoxRGB.Controls.Add(this.TrackBar_Blue);
			this.GroupBoxRGB.Controls.Add(this.TrackBar_Green);
			this.GroupBoxRGB.Controls.Add(this.TrackBar_Red);
			this.GroupBoxRGB.Location = new System.Drawing.Point(29, 21);
			this.GroupBoxRGB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroupBoxRGB.Name = "GroupBoxRGB";
			this.GroupBoxRGB.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroupBoxRGB.Size = new System.Drawing.Size(416, 228);
			this.GroupBoxRGB.TabIndex = 1;
			this.GroupBoxRGB.TabStop = false;
			this.GroupBoxRGB.Text = "RGB Value Picker";
			this.GroupBoxRGB.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBoxRGB_Paint);
			// 
			// LabelBlue
			// 
			this.LabelBlue.AutoSize = true;
			this.LabelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelBlue.Location = new System.Drawing.Point(22, 151);
			this.LabelBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelBlue.Name = "LabelBlue";
			this.LabelBlue.Size = new System.Drawing.Size(41, 20);
			this.LabelBlue.TabIndex = 26;
			this.LabelBlue.Text = "Blue";
			// 
			// LabelGreen
			// 
			this.LabelGreen.AutoSize = true;
			this.LabelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelGreen.Location = new System.Drawing.Point(7, 92);
			this.LabelGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelGreen.Name = "LabelGreen";
			this.LabelGreen.Size = new System.Drawing.Size(54, 20);
			this.LabelGreen.TabIndex = 25;
			this.LabelGreen.Text = "Green";
			// 
			// LabelRed
			// 
			this.LabelRed.AutoSize = true;
			this.LabelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelRed.Location = new System.Drawing.Point(24, 39);
			this.LabelRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelRed.Name = "LabelRed";
			this.LabelRed.Size = new System.Drawing.Size(39, 20);
			this.LabelRed.TabIndex = 24;
			this.LabelRed.Text = "Red";
			// 
			// TrackBar_Blue
			// 
			this.TrackBar_Blue.Location = new System.Drawing.Point(77, 157);
			this.TrackBar_Blue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TrackBar_Blue.Maximum = 255;
			this.TrackBar_Blue.Name = "TrackBar_Blue";
			this.TrackBar_Blue.Size = new System.Drawing.Size(326, 45);
			this.TrackBar_Blue.TabIndex = 16;
			this.TrackBar_Blue.Scroll += new System.EventHandler(this.TrackBar_Blue_Scroll);
			// 
			// TrackBar_Green
			// 
			this.TrackBar_Green.Location = new System.Drawing.Point(77, 98);
			this.TrackBar_Green.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TrackBar_Green.Maximum = 255;
			this.TrackBar_Green.Name = "TrackBar_Green";
			this.TrackBar_Green.Size = new System.Drawing.Size(326, 45);
			this.TrackBar_Green.TabIndex = 15;
			this.TrackBar_Green.Scroll += new System.EventHandler(this.TrackBar_Green_Scroll);
			// 
			// TrackBar_Red
			// 
			this.TrackBar_Red.Location = new System.Drawing.Point(77, 39);
			this.TrackBar_Red.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TrackBar_Red.Maximum = 255;
			this.TrackBar_Red.Name = "TrackBar_Red";
			this.TrackBar_Red.Size = new System.Drawing.Size(326, 45);
			this.TrackBar_Red.TabIndex = 14;
			this.TrackBar_Red.Scroll += new System.EventHandler(this.TrackBar_Red_Scroll);
			// 
			// OpenWindowsColorForm
			// 
			this.OpenWindowsColorForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenWindowsColorForm.Location = new System.Drawing.Point(370, 293);
			this.OpenWindowsColorForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.OpenWindowsColorForm.Name = "OpenWindowsColorForm";
			this.OpenWindowsColorForm.Size = new System.Drawing.Size(306, 30);
			this.OpenWindowsColorForm.TabIndex = 27;
			this.OpenWindowsColorForm.Text = "Use Windows Color Picker";
			this.OpenWindowsColorForm.UseVisualStyleBackColor = false;
			this.OpenWindowsColorForm.Click += new System.EventHandler(this.OpenWindowsColorForm_Click);
			// 
			// ColorPreview
			// 
			this.ColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ColorPreview.Location = new System.Drawing.Point(182, 276);
			this.ColorPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ColorPreview.Name = "ColorPreview";
			this.ColorPreview.Size = new System.Drawing.Size(162, 59);
			this.ColorPreview.TabIndex = 23;
			this.ColorPreview.TabStop = false;
			// 
			// GroupBoxSwatch
			// 
			this.GroupBoxSwatch.Controls.Add(this.CopyBrightnessValue);
			this.GroupBoxSwatch.Controls.Add(this.CopySaturationValue);
			this.GroupBoxSwatch.Controls.Add(this.CopyPaintSwatchValue);
			this.GroupBoxSwatch.Controls.Add(this.TextBoxBrightness);
			this.GroupBoxSwatch.Controls.Add(this.TextBoxSaturation);
			this.GroupBoxSwatch.Controls.Add(this.TextBoxPaintSwatch);
			this.GroupBoxSwatch.Controls.Add(this.LabelBrightness);
			this.GroupBoxSwatch.Controls.Add(this.LabelSaturation);
			this.GroupBoxSwatch.Controls.Add(this.LabelPaintSwatch);
			this.GroupBoxSwatch.Location = new System.Drawing.Point(453, 21);
			this.GroupBoxSwatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroupBoxSwatch.Name = "GroupBoxSwatch";
			this.GroupBoxSwatch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroupBoxSwatch.Size = new System.Drawing.Size(346, 228);
			this.GroupBoxSwatch.TabIndex = 28;
			this.GroupBoxSwatch.TabStop = false;
			this.GroupBoxSwatch.Text = "Swatch Color";
			this.GroupBoxSwatch.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBoxSwatch_Paint);
			// 
			// CopyBrightnessValue
			// 
			this.CopyBrightnessValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopyBrightnessValue.Location = new System.Drawing.Point(230, 159);
			this.CopyBrightnessValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CopyBrightnessValue.Name = "CopyBrightnessValue";
			this.CopyBrightnessValue.Size = new System.Drawing.Size(96, 25);
			this.CopyBrightnessValue.TabIndex = 35;
			this.CopyBrightnessValue.Text = "Copy";
			this.CopyBrightnessValue.UseVisualStyleBackColor = false;
			this.CopyBrightnessValue.Click += new System.EventHandler(this.CopyBrightnessValue_Click);
			// 
			// CopySaturationValue
			// 
			this.CopySaturationValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopySaturationValue.Location = new System.Drawing.Point(230, 106);
			this.CopySaturationValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CopySaturationValue.Name = "CopySaturationValue";
			this.CopySaturationValue.Size = new System.Drawing.Size(96, 25);
			this.CopySaturationValue.TabIndex = 34;
			this.CopySaturationValue.Text = "Copy";
			this.CopySaturationValue.UseVisualStyleBackColor = false;
			this.CopySaturationValue.Click += new System.EventHandler(this.CopySaturationValue_Click);
			// 
			// CopyPaintSwatchValue
			// 
			this.CopyPaintSwatchValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopyPaintSwatchValue.Location = new System.Drawing.Point(230, 50);
			this.CopyPaintSwatchValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CopyPaintSwatchValue.Name = "CopyPaintSwatchValue";
			this.CopyPaintSwatchValue.Size = new System.Drawing.Size(96, 25);
			this.CopyPaintSwatchValue.TabIndex = 33;
			this.CopyPaintSwatchValue.Text = "Copy";
			this.CopyPaintSwatchValue.UseVisualStyleBackColor = false;
			this.CopyPaintSwatchValue.Click += new System.EventHandler(this.CopyPaintSwatchValue_Click);
			// 
			// TextBoxBrightness
			// 
			this.TextBoxBrightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxBrightness.Location = new System.Drawing.Point(128, 159);
			this.TextBoxBrightness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TextBoxBrightness.Name = "TextBoxBrightness";
			this.TextBoxBrightness.ReadOnly = true;
			this.TextBoxBrightness.Size = new System.Drawing.Size(94, 22);
			this.TextBoxBrightness.TabIndex = 32;
			this.TextBoxBrightness.Text = "0";
			// 
			// TextBoxSaturation
			// 
			this.TextBoxSaturation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxSaturation.Location = new System.Drawing.Point(128, 106);
			this.TextBoxSaturation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TextBoxSaturation.Name = "TextBoxSaturation";
			this.TextBoxSaturation.ReadOnly = true;
			this.TextBoxSaturation.Size = new System.Drawing.Size(94, 22);
			this.TextBoxSaturation.TabIndex = 31;
			this.TextBoxSaturation.Text = "0";
			// 
			// TextBoxPaintSwatch
			// 
			this.TextBoxPaintSwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxPaintSwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxPaintSwatch.Location = new System.Drawing.Point(128, 50);
			this.TextBoxPaintSwatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TextBoxPaintSwatch.Name = "TextBoxPaintSwatch";
			this.TextBoxPaintSwatch.ReadOnly = true;
			this.TextBoxPaintSwatch.Size = new System.Drawing.Size(94, 22);
			this.TextBoxPaintSwatch.TabIndex = 30;
			this.TextBoxPaintSwatch.Text = "0";
			// 
			// LabelBrightness
			// 
			this.LabelBrightness.AutoSize = true;
			this.LabelBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelBrightness.Location = new System.Drawing.Point(7, 159);
			this.LabelBrightness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelBrightness.Name = "LabelBrightness";
			this.LabelBrightness.Size = new System.Drawing.Size(85, 20);
			this.LabelBrightness.TabIndex = 29;
			this.LabelBrightness.Text = "Brightness";
			// 
			// LabelSaturation
			// 
			this.LabelSaturation.AutoSize = true;
			this.LabelSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSaturation.Location = new System.Drawing.Point(7, 106);
			this.LabelSaturation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelSaturation.Name = "LabelSaturation";
			this.LabelSaturation.Size = new System.Drawing.Size(83, 20);
			this.LabelSaturation.TabIndex = 28;
			this.LabelSaturation.Text = "Saturation";
			// 
			// LabelPaintSwatch
			// 
			this.LabelPaintSwatch.AutoSize = true;
			this.LabelPaintSwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelPaintSwatch.Location = new System.Drawing.Point(7, 50);
			this.LabelPaintSwatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelPaintSwatch.Name = "LabelPaintSwatch";
			this.LabelPaintSwatch.Size = new System.Drawing.Size(98, 20);
			this.LabelPaintSwatch.TabIndex = 27;
			this.LabelPaintSwatch.Text = "PaintSwatch";
			// 
			// Swatcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(830, 361);
			this.Controls.Add(this.GroupBoxSwatch);
			this.Controls.Add(this.OpenWindowsColorForm);
			this.Controls.Add(this.GroupBoxRGB);
			this.Controls.Add(this.ColorPreview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "Swatcher";
			this.Text = "Swatch Picker by MaxHwoy";
			this.GroupBoxRGB.ResumeLayout(false);
			this.GroupBoxRGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Blue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Red)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).EndInit();
			this.GroupBoxSwatch.ResumeLayout(false);
			this.GroupBoxSwatch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBoxRGB;
		private System.Windows.Forms.Button OpenWindowsColorForm;
		private System.Windows.Forms.Label LabelBlue;
		private System.Windows.Forms.Label LabelGreen;
		private System.Windows.Forms.Label LabelRed;
		private System.Windows.Forms.PictureBox ColorPreview;
		private System.Windows.Forms.TrackBar TrackBar_Blue;
		private System.Windows.Forms.TrackBar TrackBar_Green;
		private System.Windows.Forms.TrackBar TrackBar_Red;
		private System.Windows.Forms.ColorDialog SwatchDialog;
		private System.Windows.Forms.GroupBox GroupBoxSwatch;
		private System.Windows.Forms.TextBox TextBoxPaintSwatch;
		private System.Windows.Forms.Label LabelBrightness;
		private System.Windows.Forms.Label LabelSaturation;
		private System.Windows.Forms.Label LabelPaintSwatch;
		private System.Windows.Forms.Button CopyPaintSwatchValue;
		private System.Windows.Forms.TextBox TextBoxBrightness;
		private System.Windows.Forms.TextBox TextBoxSaturation;
		private System.Windows.Forms.Button CopyBrightnessValue;
		private System.Windows.Forms.Button CopySaturationValue;
	}
}