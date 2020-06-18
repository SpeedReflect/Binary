using System;



namespace Binary.Endscript
{
	public class InvalidArgsNumberException : Exception
	{
		public InvalidArgsNumberException() : base() { }

		public InvalidArgsNumberException(int number, params int[] expected)
			: base($"Invalid number of arguments passed: got {number}, expected {BuildExpectedString(expected)} arguments") { }

		private static string BuildExpectedString(params int[] expected)
		{
			string result = String.Empty;

			if (expected.Length == 0) return result;
			else if (expected.Length == 1) return expected[0].ToString();
			else
			{

				for (int loop = 0; loop < expected.Length - 1; ++loop)
				{

					result += expected[loop].ToString() + ", or ";

				}

				result += expected[^1].ToString();
				return result;

			}
		}
	}
}
