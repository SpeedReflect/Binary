using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Binary.Properties;



namespace Binary
{
	internal static class Theme
	{
		public static Color MainBackColor => Configurations.Default.DarkTheme
					? Color.FromArgb(37, 36, 53) : Color.FromArgb(210, 210, 228);

		public static Color MainForeColor => Configurations.Default.DarkTheme
					? SystemColors.Info : SystemColors.ControlText;

		public static Color ButtonBackColor => Configurations.Default.DarkTheme
					? Color.FromArgb(51, 50, 68) : Color.FromArgb(175, 175, 200);

		public static Color ButtonForeColor => Configurations.Default.DarkTheme
					? SystemColors.Info : SystemColors.ControlText;

		public static Color ButtonFlatColor => Configurations.Default.DarkTheme
					? SystemColors.ControlDarkDark : SystemColors.ButtonShadow;

		public static Color TextBoxBackColor => Configurations.Default.DarkTheme
					? Color.FromArgb(60, 65, 72) : Color.FromArgb(180, 180, 200);

		public static Color TextBoxForeColor => Configurations.Default.DarkTheme
					? SystemColors.Info : SystemColors.ControlText;

		public static Color PrimBackColor => Configurations.Default.DarkTheme
					? Color.FromArgb(30, 30, 45) : Color.FromArgb(190, 190, 210);

		public static Color PrimForeColor => Configurations.Default.DarkTheme
					? SystemColors.Info : SystemColors.ControlText;

		public static Color MenuItemBackColor => Configurations.Default.DarkTheme
					? Color.FromArgb(40, 38, 63) : Color.FromArgb(200, 195, 225);

		public static Color MenuItemForeColor => Configurations.Default.DarkTheme
			? SystemColors.Info : SystemColors.ControlText;

		public static Color LabelTextColor => Configurations.Default.DarkTheme
					? Color.FromArgb(210, 210, 210) : Color.FromArgb(0, 0, 20);

		public static Color RegBorderColor => Configurations.Default.DarkTheme
					? Color.FromArgb(100, 90, 135) : Color.FromArgb(30, 30, 50);

		public static Color FocusedBackColor => Configurations.Default.DarkTheme
					? Color.FromArgb(79, 53, 75) : Color.FromArgb(0, 127, 255);

		public static Color FocusedForeColor => Configurations.Default.DarkTheme
					? SystemColors.Info : SystemColors.ControlText;

		public class StatStripRenderer : ToolStripProfessionalRenderer
		{
			public StatStripRenderer() : base(new StatStripColors()) { }
		}

		public class MenuStripRenderer : ToolStripProfessionalRenderer
		{
			public MenuStripRenderer() : base(new MenuStripColors()) { }
		}

		private class StatStripColors : ProfessionalColorTable
		{
			public override Color StatusStripGradientBegin => Configurations.Default.DarkTheme
						? Color.FromArgb(28, 28, 40) : Color.FromArgb(200, 200, 220);
			
			public override Color StatusStripGradientEnd => Configurations.Default.DarkTheme
						? Color.FromArgb(45, 56, 70) : Color.FromArgb(175, 175, 200);
		}

		private class MenuStripColors : ProfessionalColorTable
		{
			public override Color MenuStripGradientBegin => MenuItemBackColor;
			public override Color MenuStripGradientEnd => MenuItemBackColor;
			public override Color MenuBorder => RegBorderColor;

			public override Color MenuItemBorder => Configurations.Default.DarkTheme
						? Color.FromArgb(100, 90, 135) : Color.FromArgb(40, 40, 60);

			public override Color MenuItemPressedGradientBegin => Configurations.Default.DarkTheme
						? Color.FromArgb(60, 57, 82) : Color.FromArgb(180, 175, 205);

			public override Color MenuItemPressedGradientMiddle => Configurations.Default.DarkTheme
						? Color.FromArgb(60, 57, 82) : Color.FromArgb(180, 175, 205);

			public override Color MenuItemPressedGradientEnd => Configurations.Default.DarkTheme
						? Color.FromArgb(60, 57, 82) : Color.FromArgb(180, 175, 205);

			public override Color MenuItemSelected => Configurations.Default.DarkTheme
						? Color.FromArgb(50, 60, 90) : Color.FromArgb(160, 155, 188);

			public override Color MenuItemSelectedGradientBegin => Configurations.Default.DarkTheme
						? Color.FromArgb(44, 54, 80) : Color.FromArgb(170, 165, 198);

			public override Color MenuItemSelectedGradientEnd => Configurations.Default.DarkTheme
						? Color.FromArgb(44, 54, 80) : Color.FromArgb(170, 165, 198);
		}
	}
}
