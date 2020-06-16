using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nikki.Core;
using Nikki.Utils;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;



namespace Binary
{
	public partial class Editor : Form
	{
		private readonly List<SyncDatabase> SyncDBs;



		public Editor()
		{
			this.SyncDBs = new List<SyncDatabase>();
			this.InitializeComponent();
		}

		private void LoadTreeView()
		{
			this.EditorTreeView.Nodes.Clear();
			this.SyncDBs.Sort((x, y) => x.Folder.CompareTo(y.Folder));

			foreach (var db in this.SyncDBs)
			{

				TreeNode root = null;

				foreach (TreeNode node in this.EditorTreeView.Nodes)
				{

					if (node.Text == db.Folder)
					{

						root = node;
						break;

					}

				}

				if (root == null)
				{

					root = new TreeNode(db.Folder);
					this.EditorTreeView.Nodes.Add(root);

				}

				root.Nodes.Add(db.GetTreeNodes());
			}


		}

		private void Editor_Load(object sender, EventArgs e)
		{

		}

		private void EditorMenuStripMainLoadFile_Click(object sender, EventArgs e)
		{
			var browser = new OpenFileDialog()
			{
				CheckFileExists = true,
				Filter = "All Files | *.*",
				Multiselect = true,
			};

			if (browser.ShowDialog() == DialogResult.OK && browser.FileNames.Length > 0)
			{

				foreach (var file in browser.FileNames)
				{

					if (this.SyncDBs.Find(_ => _.FullPath == file) != null) continue;

					var db = new SyncDatabase(GameINT.Carbon, file);
					db.Load();
					this.SyncDBs.Add(db);

				}

				this.LoadTreeView();

			}

		}

		private void EditorTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.EditorPropertyGrid.SelectedObject = Utils.GetReflective(e.Node.FullPath, this.SyncDBs);
		}

		private void EditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.ChangedItem.Label == "CollectionName")
			{

				this.EditorTreeView.SelectedNode.Text = e.ChangedItem.Value.ToString();
				this.EditorPropertyGrid.Refresh();

			}
		}
	}
}
