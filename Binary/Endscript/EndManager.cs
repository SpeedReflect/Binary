using Accessibility;
using CoreExtensions.Text;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Nikki.Support.Shared.Class;



namespace Binary.Endscript
{
	class EndManager
	{
		private List<SyncDatabase> SyncDBs;

		/*
		Commands:
			- update
			- add synchronize/override
			- delete synchronize/override
			- copy synchronize/override
			- import negate/synchronize/override plain/serialized
			- export negate/synchronize/override plain/serialized
			- link
			- attach
			- load
			- unload ?
			- new (syncdatabase)
		*/

		public EndManager() => this.SyncDBs = new List<SyncDatabase>();

		public EndManager(Launch launch) : this()
		{

		}

		public EndManager(List<SyncDatabase> sdbs)
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

				_ => throw new InvalidOperationException($"Command {splits[0]} is an invalid command")
			};

			return result;
		}

		private eCommandType GetCommandType(string command) =>
			Enum.TryParse(command, out eCommandType type) ? type : eCommandType.invalid;

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
				? eEndResult.CollectionNameUpdate
				: eEndResult.PropertyUpdate;
		}

		private eEndResult ProcessUpdateCommand_STR_TPK(string[] splits)
		{
			var collection = this.GetCollection(splits[1], splits[2], splits[3]);

			if (collection is TPKBlock tpk)
			{


				return eEndResult.TextureUpdate;

			}
			else if (collection is STRBlock str)
			{


				return eEndResult.StringUpdate;

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
			return eEndResult.SubPartUpdate;
		}

		#endregion

	}
}
