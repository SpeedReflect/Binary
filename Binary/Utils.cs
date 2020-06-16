using System;
using System.Collections.Generic;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;



namespace Binary
{
	internal static class Utils
	{
		public static IReflective GetReflective(string path, List<SyncDatabase> SyncDBs)
		{
			var splits = path.Split('\\');

			// splits[0] = Folder
			// splits[1] = Filename
			// splits[2] = IManager
			// splits[3] = Collectable
			// splits[4] = Expandable
			// splits[5] = SubPart

			if (splits.Length != 4 && splits.Length != 6) return null;

			var db = SyncDBs.Find(_ => _.Folder == splits[0] && _.Filename == splits[1]);
			if (db == null) return null;

			var manager = db.Database.GetManager(splits[2]);
			if (manager == null) return null;

			var collection = manager[manager.IndexOf(splits[3])] as Collectable;

			return splits.Length == 4
				? collection
				: (IReflective)collection.GetSubPart(splits[5], splits[4]);
		}
	}
}
