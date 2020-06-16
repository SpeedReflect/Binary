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

		public void CheckEndscript()
		{
			string path = Path.Combine(this.ThisDir, this.Endscript);
			if (!File.Exists(path))
			{

				throw new FileNotFoundException($"Endscript with path {path} could not be found");

			}
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
				var path = link.PType == ePathType.Relative
					? Path.Combine(this.ThisDir, link.File)
					: Path.Combine(this.Directory, link.File);

				switch (link.LType)
				{
					case eLoaderType.BinKeys:
						Loader.LoadBinKeys(new string[] { path });
						break;

					case eLoaderType.VltKeys:
						Loader.LoadVltKeys(new string[] { path });
						break;

					case eLoaderType.Attributes:
						Loader.LoadVaultAttributes(path);
						break;

					case eLoaderType.FeAttrib:
						Loader.LoadVaultFEAttribs(path);
						break;

					case eLoaderType.Labels:
						Loader.LoadLangLabels(path, this.GameID);
						break;

					default:
						throw new ArgumentException($"Invalid loading type named {link.LoadType}");
				}
			}
		}
	}
}
