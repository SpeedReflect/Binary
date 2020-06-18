using System;
using System.Collections.Generic;
using System.Text;

namespace Binary.Endscript
{
	[Flags()]
	public enum eCommandType : int
	{
		invalid = 0,
		update = 1,
		add = 2,
		remove = 3,
		copy = 4,
		export = 5,
		import = 6,
		@static = 7,
		
		@new = 8,
		delete = 9,
		combine = 10,





	}
}
