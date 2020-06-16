using System;



namespace Binary.Endscript
{
	public class SubLoader
	{
		public eLoaderType Type => Enums.TryParse(this.LoadType, out eLoaderType type) ? type : eLoaderType.Invalid;
		public string LoadType { get; set; } = String.Empty;
		public string File { get; set; } = String.Empty;
	}
}
