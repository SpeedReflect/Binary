using System;
using System.Collections.Generic;
using System.Text;

namespace Binary.Endscript
{
	public enum eEndResult : int
	{
		Invalid = 0,
		Comment = 1,
		CollectionNameUpdate = 2,
		PropertyUpdate = 3,
		SubPartUpdate = 4,
		FEngUpdate = 5,
		TextureUpdate = 6,
		StringUpdate = 7,

		StaticUpdate,


		AddNode,
		RemoveNode,
		CopyNode,

		NewDatabase,
		DeleteDatabase,

		Export,

		ImportNegate,
		ImportSynchronize,
		ImportOverride,



		Error = Int32.MaxValue
	}
}
