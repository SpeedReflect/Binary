using System;
using Binary.Enums;



namespace Binary.Endscript
{
	public class SubLoader
	{
		public eLoaderType LType => Enum.TryParse(this.LoadType, out eLoaderType type) ? type : eLoaderType.Invalid;
		public ePathType PType => Enum.TryParse(this.PathType, out ePathType type) ? type : ePathType.Invalid;
		public string LoadType { get; set; } = String.Empty;
		public string PathType { get; set; } = String.Empty;
		public string File { get; set; } = String.Empty;
	}
}
