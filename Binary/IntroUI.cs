using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binary.Properties;

namespace Binary
{
	public partial class IntroUI : Form
	{
		public IntroUI()
		{
			this.InitializeComponent();
			this.IntroPictureUser.Image = Resources.User;
			this.IntroPictureModder.Image = Resources.Modder;
			this.IntroToolTip.SetToolTip(this.IntroPictureUser, "Launch Binary for Users");
			this.IntroToolTip.SetToolTip(this.IntroPictureModder, "Launch Binary for Modders");
		}
	}
}
