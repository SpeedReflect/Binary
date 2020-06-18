using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;



namespace Binary
{
	internal static class Theme
	{
		public static class Light
		{
			public static Color MainBackColor = Color.FromArgb(210, 210, 228);
			public static Color MainForeColor = SystemColors.ControlText;
			public static Color ButtonBackColor = Color.FromArgb(175, 175, 200);
			public static Color ButtonForeColor = SystemColors.ControlText;
			public static Color ButtonFlatColor = SystemColors.ButtonShadow;
			public static Color TextBoxBackColor = Color.FromArgb(180, 180, 200);
			public static Color TextBoxForeColor = SystemColors.ControlText;
			public static Color PrimBackColor = Color.FromArgb(190, 190, 210);
			public static Color PrimForeColor = SystemColors.ControlText;
			public static Color LabelTextColor = Color.FromArgb(0, 0, 20);
		}

		public static class Dark
		{
			public static Color MainBackColor = Color.FromArgb(37, 36, 53);
			public static Color MainForeColor = SystemColors.Info;
			public static Color ButtonBackColor = Color.FromArgb(51, 50, 68);
			public static Color ButtonForeColor = SystemColors.Info;
			public static Color ButtonFlatColor = SystemColors.ControlDarkDark;
			public static Color TextBoxBackColor = Color.FromArgb(60, 65, 72);
			public static Color TextBoxForeColor = SystemColors.Info;
			public static Color PrimBackColor = Color.FromArgb(30, 30, 45);
			public static Color PrimForeColor = SystemColors.Info;
			public static Color LabelTextColor = Color.FromArgb(210, 210, 210);
		}
	}
}
