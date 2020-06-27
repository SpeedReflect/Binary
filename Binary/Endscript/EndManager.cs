using CoreExtensions.Text;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Nikki.Reflection.Enum;
using Nikki.Support.Shared.Class;



namespace Binary.Endscript
{
	class EndManager
	{
		private List<SynchronizedDatabase> SyncDBs;

		/*
		Commands:
			- update file                        manager collection property      value
			- update file                        manager collection expand        subpart       property value
			- static file                        manager property   value
			- add    negate/synchronize/override file    manager    collection
			- remove negate/synchronize/override file    manager    collection
			- copy   negate/synchronize/override file    manager    oldcollection newcollection
			- import negate/synchronize/override file    manager    collection
			- export negate/synchronize/override file    manager    collection
			- link   relative/absolute           type    file
			- attach file
			- load   file
			- save   file
			- new    file
			- delete file
			- move   oldfile                     newfile


		*/

		public EndManager() => this.SyncDBs = new List<SynchronizedDatabase>();

		public EndManager(Launch launch) : this()
		{

		}

		public EndManager(List<SynchronizedDatabase> sdbs)
		{
			this.SyncDBs = sdbs;
		}


		public eEndResult ProcessCommand(string command)
		{
			if (command.IsNullOrComment()) return eEndResult.Comment;

			var splits = command.SmartSplitString().ToArray();

			var type = this.GetCommandType(splits[0]);

			var result = type switch
			{
				eCommandType.update => this.ProcessUpdateCommand(splits),
				eCommandType.add => this.ProcessAddCommand(splits),
				eCommandType.remove => this.ProcessRemoveCommand(splits),
				eCommandType.copy => this.ProcessCopyCommand(splits),
				_ => throw new InvalidOperationException($"Command {splits[0]} is an invalid command")
			};

			return result;
		}

		private eCommandType GetCommandType(string command) =>
			Enum.TryParse(command, out eCommandType type) ? type : eCommandType.invalid;

		private IManager GetManager(string file, string manage)
		{
			var sdb = this.SyncDBs.Find(_ => _.Filename == file);

			if (sdb == null)
			{

				throw new ArgumentException($"Database named {file} does not exist");

			}

			var manager = sdb.Database.GetManager(manage);

			if (manager != null) return manager;
			else throw new ArgumentException($"Manager named {manage} does not exist");
		}

		private Collectable GetCollection(string file, string manage, string name)
		{
			var sdb = this.SyncDBs.Find(_ => _.Filename == file);

			if (sdb == null)
			{

				throw new ArgumentException($"Database named {file} does not exist");

			}

			var manager = sdb.Database.GetManager(manage);

			if (manager == null)
			{

				throw new ArgumentException($"Manager named {manage} does not exist");

			}

			var reflective = manager[manager.IndexOf(name)];

			if (reflective is Collectable collectable) return collectable;
			else throw new ArgumentException($"Collection named {name} does not exist");
		}

		#region update

		private eEndResult ProcessUpdateCommand(string[] splits)
		{
			return splits.Length switch
			{
				6 => this.ProcessUpdateCommand_Collectable(splits),
				7 => this.ProcessUpdateCommand_STR_TPK(splits),
				8 => this.ProcessUpdateCommand_SubPart(splits),
				_ => throw new InvalidArgsNumberException(splits.Length, 6, 7, 8)
			};
		}

		private eEndResult ProcessUpdateCommand_Collectable(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);
			collection.SetValue(splits[4], splits[5]);

			return splits[4] == nameof(collection.CollectionName)
				? eEndResult.CollectionName
				: eEndResult.UpdateNode;
		}

		private eEndResult ProcessUpdateCommand_STR_TPK(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);
			var key = Convert.ToUInt32(splits[4]);

			if (collection is TPKBlock tpk)
			{

				var texture = tpk.FindTexture(key, eKeyType.BINKEY);
				texture.SetValue(splits[5], splits[6]);
				return eEndResult.UpdateTexture;

			}
			else if (collection is STRBlock str)
			{

				var record = str.GetRecord(key);
				record.SetValue(splits[5], splits[6]);
				return eEndResult.UpdateString;

			}
			else
			{

				throw new InvalidArgsNumberException(splits.Length, 5, 7);

			}
		}

		private eEndResult ProcessUpdateCommand_SubPart(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);
			var subpart = collection.GetSubPart(splits[5], splits[4]);
			
			if (subpart == null)
			{

				throw new ArgumentException($"SubPart named {splits[5]} in root {splits[4]} does not exist in " +
					$"the collection named {splits[3]}");

			}

			subpart.SetValue(splits[6], splits[7]);
			return eEndResult.UpdateSubPart;
		}

		#endregion

		#region add

		private eEndResult ProcessAddCommand(string[] splits)
		{
			return splits.Length switch
			{
				4 => this.ProcessAddCommand_Collectable(splits),
				6 => this.ProcessAddCommand_TPK(splits),
				7 => this.ProcessAddCommand_STR(splits),
				_ => throw new InvalidArgsNumberException(splits.Length, 4, 6, 7)
			};
		}

		private eEndResult ProcessAddCommand_Collectable(string[] splits)
		{
			var manager = this.GetManager(splits[1], splits[2]);
			manager.Add(splits[3]);
			return eEndResult.AddNode;
		}

		private eEndResult ProcessAddCommand_TPK(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);

			if (collection is TPKBlock tpk)
			{

				tpk.AddTexture(splits[4], splits[5]);
				return eEndResult.AddTexture;

			}
			else
			{

				throw new InvalidArgsNumberException(splits.Length, 4, 7);

			}
		}

		private eEndResult ProcessAddCommand_STR(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);

			if (collection is STRBlock str)
			{

				str.AddRecord(splits[4], splits[5], splits[6]);
				return eEndResult.AddString;

			}
			else
			{

				throw new InvalidArgsNumberException(splits.Length, 4, 6);

			}
		}

		#endregion

		#region remove

		private eEndResult ProcessRemoveCommand(string[] splits)
		{
			return splits.Length switch
			{
				4 => this.ProcessRemoveCommand_Collectable(splits),
				5 => this.ProcessRemoveCommand_STR_TPK(splits),
				_ => throw new InvalidArgsNumberException(splits.Length, 4, 5)
			};
		}

		private eEndResult ProcessRemoveCommand_Collectable(string[] splits)
		{
			var manager = this.GetManager(splits[1], splits[2]);
			manager.Remove(splits[3]);
			return eEndResult.RemoveNode;
		}

		private eEndResult ProcessRemoveCommand_STR_TPK(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);
			var key = Convert.ToUInt32(splits[4], 16);

			if (collection is TPKBlock tpk)
			{

				tpk.RemoveTexture(key, eKeyType.BINKEY);
				return eEndResult.RemoveTexture;

			}
			else if (collection is STRBlock str)
			{

				str.RemoveRecord(key);
				return eEndResult.RemoveString;

			}
			else
			{

				throw new InvalidArgsNumberException(splits.Length, 4);

			}
		}

		#endregion

		#region copy

		private eEndResult ProcessCopyCommand(string[] splits)
		{
			return splits.Length switch
			{
				5 => this.ProcessCopyCommand_Collectable(splits),
				6 => this.ProcessCopyCommand_TPK(splits),
				_ => throw new InvalidArgsNumberException(splits.Length, 5, 6)
			};
		}

		private eEndResult ProcessCopyCommand_Collectable(string[] splits)
		{
			var manager = this.GetManager(splits[1], splits[2]);
			manager.Clone(splits[4], splits[3]);
			return eEndResult.CopyNode;
		}

		private eEndResult ProcessCopyCommand_TPK(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);

			if (collection is TPKBlock tpk)
			{

				var key = Convert.ToUInt32(splits[4], 16);
				tpk.CloneTexture(splits[5], key, eKeyType.BINKEY);
				return eEndResult.CopyTexture;

			}
			else
			{

				throw new InvalidArgsNumberException(splits.Length, 5);

			}
		}

		#endregion

	}
}
