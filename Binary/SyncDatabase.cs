using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Nikki.Core;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Attributes;
using System.Windows.Forms;
using System.Reflection.Metadata;

namespace Binary
{
	public class SyncDatabase
	{
		public FileBase Database { get; set; }

		public string Filename => Path.GetFileNameWithoutExtension(this.FullPath).ToUpperInvariant();

		public string Folder => Path.GetFileName(Path.GetDirectoryName(this.FullPath)).ToUpperInvariant();

		public string FullPath { get; }

		public SyncDatabase(GameINT game, string fullpath)
		{
			this.Database = game switch
			{
				GameINT.Carbon => new Nikki.Support.Carbon.Datamap(),
				GameINT.MostWanted => new Nikki.Support.MostWanted.Datamap(),
				GameINT.Prostreet => new Nikki.Support.Prostreet.Datamap(),
				_ => throw new ArgumentException(nameof(game)),
			};

			this.FullPath = fullpath;
		}

		public void Load() => this.Database.Load(new Options(this.FullPath));

		public void Save() => this.Database.Save(new Options(this.FullPath));

		public TreeNode GetTreeNodes()
		{
			var result = new TreeNode(this.Filename);

			foreach (var manager in this.Database.Managers)
			{
				var managenode = new TreeNode(manager.Name); 

				foreach (Collectable collection in manager)
				{

					managenode.Nodes.Add(this.GetCollectionNodes(collection));

				}

				result.Nodes.Add(managenode);

			}

			return result;
		}
	
		private TreeNode GetCollectionNodes(Collectable collection)
		{
			var result = new TreeNode(collection.CollectionName);

			foreach (var expando in collection.GetAllNodes())
			{

				var expandnode = new TreeNode(expando.NodeName);

				foreach (var subpart in expando.SubNodes)
				{

					var subnode = new TreeNode(subpart.NodeName);
					expandnode.Nodes.Add(subnode);

				}

				result.Nodes.Add(expandnode);

			}

			return result;
		}

	}
}
