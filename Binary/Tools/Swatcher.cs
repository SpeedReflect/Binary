using System;
using System.Drawing;
using System.Windows.Forms;



namespace Binary.Tools
{
    public partial class Swatcher : Form
    {
        public Swatcher()
        {
            this.InitializeComponent();
            this.ToggleTheme();
            this.ColorPreview.BackColor = Color.Black;
        }

		#region Theme

        private void ToggleTheme()
		{
            this.BackColor = Theme.MainBackColor;
            this.ForeColor = Theme.MainForeColor;

            this.CopyBrightnessValue.BackColor = Theme.ButtonBackColor;
            this.CopyBrightnessValue.ForeColor = Theme.ButtonForeColor;
            this.CopyBrightnessValue.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopySaturationValue.BackColor = Theme.ButtonBackColor;
            this.CopySaturationValue.ForeColor = Theme.ButtonForeColor;
            this.CopySaturationValue.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.CopyPaintSwatchValue.BackColor = Theme.ButtonBackColor;
            this.CopyPaintSwatchValue.ForeColor = Theme.ButtonForeColor;
            this.CopyPaintSwatchValue.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
            this.TextBoxBrightness.BackColor = Theme.TextBoxBackColor;
            this.TextBoxBrightness.ForeColor = Theme.TextBoxForeColor;
            this.TextBoxSaturation.BackColor = Theme.TextBoxBackColor;
            this.TextBoxSaturation.ForeColor = Theme.TextBoxForeColor;
            this.TextBoxPaintSwatch.BackColor = Theme.TextBoxBackColor;
            this.TextBoxPaintSwatch.ForeColor = Theme.TextBoxForeColor;
            this.GroupBoxRGB.ForeColor = Theme.LabelTextColor;
            this.GroupBoxSwatch.ForeColor = Theme.LabelTextColor;
        }

        #endregion

        private void RGBtoHSV(float red, float green, float blue)
        {
            float hue = 0; // paintswatch
            float sat = 0; // saturation
            float brt = 0; // brightness

            float min = 0; // min rgb value
            float max = 0; // max rgb value
            float dif = 0; // delta of max & min

            max = (red > green) ? red : green;
            max = (max > blue) ? max : blue;
            min = (red < green) ? red : green;
            min = (min < blue) ? min : blue;

            brt = max; // set brightness
            dif = max - min;

            sat = max == 0 ? 0 : dif / max; // set saturation

            if (max == min) hue = 0;
            else if (max == red)   hue = (60 * ((green - blue) / dif) + 360) % 360;
            else if (max == green) hue = (60 * ((blue - red) / dif) + 120) % 360;
            else if (max == blue)  hue = (60 * ((red - green) / dif) + 240) % 360;

            hue = 90 - (hue / 4);

            this.TextBoxPaintSwatch.Text = ((int)hue).ToString();
            this.TextBoxSaturation.Text = sat.ToString();
            this.TextBoxBrightness.Text = brt.ToString();
            this.ColorPreview.BackColor = Color.FromArgb(this.TrackBar_Red.Value, this.TrackBar_Green.Value, this.TrackBar_Blue.Value);
        }

        private void TrackBar_Red_Scroll(object sender, EventArgs e)
        {
            float red = Convert.ToSingle(this.TrackBar_Red.Value) / 255;
            float green = Convert.ToSingle(this.TrackBar_Green.Value) / 255;
            float blue = Convert.ToSingle(this.TrackBar_Blue.Value) / 255;
            this.RGBtoHSV(red, green, blue);
        }

        private void TrackBar_Green_Scroll(object sender, EventArgs e)
        {
            float red = Convert.ToSingle(this.TrackBar_Red.Value) / 255;
            float green = Convert.ToSingle(this.TrackBar_Green.Value) / 255;
            float blue = Convert.ToSingle(this.TrackBar_Blue.Value) / 255;
            this.RGBtoHSV(red, green, blue);
        }

        private void TrackBar_Blue_Scroll(object sender, EventArgs e)
        {
            float red = Convert.ToSingle(this.TrackBar_Red.Value) / 255;
            float green = Convert.ToSingle(this.TrackBar_Green.Value) / 255;
            float blue = Convert.ToSingle(this.TrackBar_Blue.Value) / 255;
            this.RGBtoHSV(red, green, blue);
        }

        private void OpenWindowsColorForm_Click(object sender, EventArgs e)
        {
            if (this.SwatchDialog.ShowDialog() == DialogResult.OK)
            {

                this.TrackBar_Red.Value = this.SwatchDialog.Color.R;
                this.TrackBar_Green.Value = this.SwatchDialog.Color.G;
                this.TrackBar_Blue.Value = this.SwatchDialog.Color.B;

                float red = Convert.ToSingle(this.TrackBar_Red.Value) / 255;
                float green = Convert.ToSingle(this.TrackBar_Green.Value) / 255;
                float blue = Convert.ToSingle(this.TrackBar_Blue.Value) / 255;

                this.RGBtoHSV(red, green, blue);
            }
        }

        private void CopyPaintSwatchValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.TextBoxPaintSwatch.Text);
        }

        private void CopySaturationValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.TextBoxSaturation.Text);
        }

        private void CopyBrightnessValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.TextBoxBrightness.Text);
        }

		private void GroupBoxRGB_Paint(object sender, PaintEventArgs e)
		{
            var box = sender as GroupBox;
            this.DrawGroupBox(box, e.Graphics, Theme.LabelTextColor, Theme.LabelTextColor);
        }

        private void GroupBoxSwatch_Paint(object sender, PaintEventArgs e)
        {
            var box = sender as GroupBox;
            this.DrawGroupBox(box, e.Graphics, Theme.LabelTextColor, Theme.LabelTextColor);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color fore, Color border)
        {
            if (box is null) return;

            var fore_b = new SolidBrush(fore);
            var border_b = new SolidBrush(border);
            var border_p = new Pen(border_b);

            var size = g.MeasureString(box.Text, box.Font);

            var x = box.ClientRectangle.X;
            var y = box.ClientRectangle.Y + (int)(size.Height / 2);
            var width = box.ClientRectangle.Width - 1;
            var height = box.ClientRectangle.Height - (int)(size.Height / 2) - 1;

            var rect = new Rectangle(x, y, width, height);

            g.Clear(this.BackColor);
            g.DrawString(box.Text, box.Font, fore_b, box.Padding.Left, 0);

            g.DrawLine(border_p, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            g.DrawLine(border_p, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            g.DrawLine(border_p, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            g.DrawLine(border_p, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
            g.DrawLine(border_p, new Point(rect.X + box.Padding.Left + (int)size.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }
	}
}
