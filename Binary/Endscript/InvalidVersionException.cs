using System;



namespace Binary.Endscript
{
	public class InvalidVersionException : Exception
	{
		public InvalidVersionException() : base() { }

		public InvalidVersionException(int version)
			: base($"Endscript version was of invalid format, expected [VERSN{version}]") { }
	}
}
