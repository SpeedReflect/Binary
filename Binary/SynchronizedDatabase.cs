using System;
using System.IO;
using System.Windows.Forms;
using Binary.Properties;
using Nikki.Core;
using Nikki.Reflection.Abstract;



namespace Binary
{
	public class SynchronizedDatabase
	{
		public FileBase Database { get; set; }

		public string Filename { get; }

		public string Folder { get; }

		public string FullPath => Path.Combine(this.Folder, this.Filename);

		private Options LoadingOpts { get; }

		private Options SavingOpts { get; }

		public SynchronizedDatabase(GameINT game, string folder, string file)
		{
			this.Database = game switch
			{
				GameINT.Carbon => new Nikki.Support.Carbon.Datamap(),
				GameINT.MostWanted => new Nikki.Support.MostWanted.Datamap(),
				GameINT.Prostreet => new Nikki.Support.Prostreet.Datamap(),
				_ => throw new ArgumentException(nameof(game)),
			};

			this.Folder = folder;
			this.Filename = file;
			this.LoadingOpts = new Options(this.FullPath);
			this.SavingOpts = new Options(this.FullPath, Configurations.Default.Watermark);
		}

		public void Load() => this.Database.Load(this.LoadingOpts);

		public void Save() => this.Database.Save(this.SavingOpts);

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
