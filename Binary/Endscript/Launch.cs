using System;
using System.IO;
using System.Collections.Generic;
using Binary.Enums;
using Nikki.Core;
using System.Text.Json.Serialization;



namespace Binary.Endscript
{
	public sealed class Launch
	{
		[JsonIgnore()]
		public string ThisDir { get; set; }
		public eUsage UsageID => Enum.TryParse(this.Usage, out eUsage usage) ? usage : eUsage.Invalid;
		public GameINT GameID => Enum.TryParse(this.Game, out GameINT game) ? game : GameINT.None;
		public string Usage { get; set; }
		public string Game { get; set; }
		public string Directory { get; set; }
		public string Endscript { get; set; }
		public List<string> Files { get; set; }
		public List<SubLoader> Links { get; set; }

		public Launch()
		{
			this.Usage = eUsage.User.ToString();
			this.Game = GameINT.None.ToString();
			this.Directory = String.Empty;
			this.Endscript = String.Empty;
			this.Files = new List<string>();
			this.Links = new List<SubLoader>();
		}

		public void CheckFiles()
		{
			foreach (var file in this.Files)
			{

				string path = Path.Combine(this.Directory, file);

				if (!File.Exists(path))
				{

					throw new FileNotFoundException($"File with path {path} could not be found");

				}

			}
		}
	
		public void LoadLinks()
		{
			foreach (var link in this.Links)
			{
				switch (link.Type)
				{
					case eLoaderType.BinKeys:
						Loader.LoadBinKeys(new string[] { link.File });
						break;

					case eLoaderType.VltKeys:
						Loader.LoadVltKeys(new string[] { link.File });
						break;

					case eLoaderType.Attributes:
						Loader.LoadVaultAttributes(link.File);
						break;

					case eLoaderType.FeAttrib:
						Loader.LoadVaultFEAttribs(link.File);
						break;

					case eLoaderType.Labels:
						Loader.LoadLangLabels(link.File, this.GameID);
						break;

					default:
						throw new ArgumentException($"Invalid loading type named {link.LoadType}");
				}
			}
		}
	}
}
