using System;
using System.Collections.Generic;
using Nikki.Core;



namespace Binary.Endscript
{
	public sealed class Launch
	{
		public eUsageOriented UsageID => (eUsageOriented)Enum.Parse(typeof(eUsageOriented), this.Usage);
		public GameINT GameID => (GameINT)Enum.Parse(typeof(GameINT), this.Game);

		public string Usage { get; set; }
		public string Game { get; set; }
		public string Directory { get; set; }
		public List<string> Files { get; set; }
		public List<string> Endscripts { get; set; }
		public List<string> Links { get; set; }

		public Launch()
		{
			this.Usage = eUsageOriented.User.ToString();
			this.Game = GameINT.None.ToString();
			this.Directory = String.Empty;
			this.Files = new List<string>();
			this.Endscripts = new List<string>();
			this.Links = new List<string>();
		}
	}
}
