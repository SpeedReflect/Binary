using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Binary.Enums;
using Binary.Endscript;
using Binary.Properties;

using Nikki.Core;
using Nikki.Utils;
using Nikki.Support.Shared.Class;
using Nikki.Reflection.Interface;
using CoreExtensions.Management;
using Nikki.Reflection.Abstract;

namespace Binary
{
	public partial class Editor : Form
	{
		private List<SyncDatabase> SyncDBs;

		public Editor()
		{
			this.SyncDBs = new List<SyncDatabase>();
			this.InitializeComponent();
			this.ToggleTheme();
		}

		#region Theme

		private void ToggleTheme()
		{
			if (Configurations.Default.DarkTheme) this.ToggleDarkTheme();
			else this.ToggleLightTheme();
		}

		private void ToggleLightTheme()
		{
			this.BackColor = Theme.Light.MainBackColor;
			this.ForeColor = Theme.Light.MainForeColor;

		}

		private void ToggleDarkTheme()
		{
			this.BackColor = Theme.Dark.MainBackColor;
			this.ForeColor = Theme.Dark.MainForeColor;
			this.EditorTreeView.BackColor = Theme.Dark.PrimBackColor;
			this.EditorTreeView.ForeColor = Theme.Dark.PrimForeColor;
			this.EditorPropertyGrid.ViewBackColor = Theme.Dark.PrimBackColor;
			this.EditorPropertyGrid.ViewForeColor = Theme.Dark.PrimForeColor;



			this.EditorButtonOpenEditor.BackColor = Theme.Dark.ButtonBackColor;
			this.EditorButtonOpenEditor.ForeColor = Theme.Dark.ButtonForeColor;
			this.EditorButtonOpenEditor.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.EditorButtonAddNode.BackColor = Theme.Dark.ButtonBackColor;
			this.EditorButtonAddNode.ForeColor = Theme.Dark.ButtonForeColor;
			this.EditorButtonAddNode.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.EditorButtonDeleteNode.BackColor = Theme.Dark.ButtonBackColor;
			this.EditorButtonDeleteNode.ForeColor = Theme.Dark.ButtonForeColor;
			this.EditorButtonDeleteNode.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.EditorButtonCopyNode.BackColor = Theme.Dark.ButtonBackColor;
			this.EditorButtonCopyNode.ForeColor = Theme.Dark.ButtonForeColor;
			this.EditorButtonCopyNode.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.EditorButtonExportNode.BackColor = Theme.Dark.ButtonBackColor;
			this.EditorButtonExportNode.ForeColor = Theme.Dark.ButtonForeColor;
			this.EditorButtonExportNode.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
			this.EditorButtonImportNode.BackColor = Theme.Dark.ButtonBackColor;
			this.EditorButtonImportNode.ForeColor = Theme.Dark.ButtonForeColor;
			this.EditorButtonImportNode.FlatAppearance.BorderColor = Theme.Dark.ButtonFlatColor;
		}

		#endregion

		#region Manage Controls

		private void ManageButtonOpenEditor(IReflective reflective)
		{
			this.EditorButtonOpenEditor.Enabled =
				reflective is FNGroup ||
				reflective is STRBlock ||
				reflective is TPKBlock ||
				reflective is DBModelPart;
		}

		private void ManageButtonAddNode(TreeNode node)
		{
			if (node == null || node.Level != 1)
			{

				this.EditorButtonAddNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Text);

			if (sdb == null)
			{

				this.EditorButtonAddNode.Enabled = false;
				return;

			}
			
			var manager = sdb.Database.GetManager(node.Text);
			this.EditorButtonAddNode.Enabled = manager != null && !manager.IsReadOnly;
		}

		private void ManageButtonDeleteNode(TreeNode node)
		{
			if (node == null || node.Level != 2)
			{

				this.EditorButtonDeleteNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Parent.Text);
			
			if (sdb == null)
			{

				this.EditorButtonCopyNode.Enabled = false;
				return;

			}
			
			var manager = sdb.Database.GetManager(node.Parent.Text);
			this.EditorButtonDeleteNode.Enabled = manager != null && !manager.IsReadOnly;
		}

		private void ManageButtonCopyNode(TreeNode node)
		{
			if (node == null || node.Level != 2)
			{

				this.EditorButtonCopyNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Parent.Text);
			
			if (sdb == null)
			{

				this.EditorButtonCopyNode.Enabled = false;
				return;

			}

			var manager = sdb.Database.GetManager(node.Parent.Text);
			this.EditorButtonCopyNode.Enabled = manager != null && !manager.IsReadOnly;
		}

		private void ManageButtonExportNode(TreeNode node)
		{
			if (node == null || node.Level != 2)
			{

				this.EditorButtonExportNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Parent.Text);
			
			if (sdb == null)
			{

				this.EditorButtonExportNode.Enabled = false;
				return;

			}

			var manager = sdb.Database.GetManager(node.Parent.Text);
			this.EditorButtonExportNode.Enabled = manager != null && !manager.IsReadOnly;
		}

		private void ManageButtonImportNode(TreeNode node)
		{
			if (node == null || node.Level != 1)
			{

				this.EditorButtonImportNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Text);

			if (sdb == null)
			{

				this.EditorButtonImportNode.Enabled = false;
				return;

			}

			var manager = sdb.Database.GetManager(node.Text);
			this.EditorButtonImportNode.Enabled = manager != null && !manager.IsReadOnly;
		}

		#endregion

		#region Menu Strip Controls

		private void EMSMainNewLauncher_Click(object sender, EventArgs e)
		{
			using var form = new LanMaker();
			form.ShowDialog();
		}

		private void EMSMainLoadFiles_Click(object sender, EventArgs e)
		{
			using var browser = new OpenFileDialog()
			{
				CheckFileExists = true,
				Filter = "Endscript Files | *.end",
				Multiselect = false,
			};

			if (browser.ShowDialog() == DialogResult.OK)
			{

				this.LoadSynchronizedDatabases(browser.FileName, true);

			}
		}

		private void EMSMainReloadFiles_Click(object sender, EventArgs e)
		{

		}

		private void EMSMainSaveFiles_Click(object sender, EventArgs e)
		{

		}

		private void EMSMainExit_Click(object sender, EventArgs e)
		{

		}

		private void EMSDatabaseLoadDB_Click(object sender, EventArgs e)
		{

		}

		private void EMSDatabaseReloadDB_Click(object sender, EventArgs e)
		{

		}

		private void EMSDatabaseSaveDB_Click(object sender, EventArgs e)
		{

		}

		private void EMSDatabaseCombineDB_Click(object sender, EventArgs e)
		{

		}

		private void EMSToolsHasher_Click(object sender, EventArgs e)
		{

		}

		private void EMSToolsRaider_Click(object sender, EventArgs e)
		{

		}

		private void EMSToolsSwatcher_Click(object sender, EventArgs e)
		{

		}

		private void EMSOptionsCreate_Click(object sender, EventArgs e)
		{

		}

		private void EMSOptionsRestore_Click(object sender, EventArgs e)
		{

		}

		private void EMSOptionsUnlock_Click(object sender, EventArgs e)
		{

		}

		private void EMSScriptingProcess_Click(object sender, EventArgs e)
		{

		}

		private void EMSScriptingGenerate_Click(object sender, EventArgs e)
		{

		}

		private void EMSScriptingClear_Click(object sender, EventArgs e)
		{

		}

		private void EMSWindowsRun_Click(object sender, EventArgs e)
		{

		}

		private void EMSWindowsNew_Click(object sender, EventArgs e)
		{

		}

		private void EMSHelpAbout_Click(object sender, EventArgs e)
		{

		}

		private void EMSHelpTutorials_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region Button Controls

		private void EditorButtonAddNode_Click(object sender, EventArgs e)
		{

		}

		private void EditorButtonDeleteNode_Click(object sender, EventArgs e)
		{

		}

		private void EditorButtonCopyNode_Click(object sender, EventArgs e)
		{

		}

		private void EditorButtonOpenEditor_Click(object sender, EventArgs e)
		{

		}

		private void EditorButtonExportNode_Click(object sender, EventArgs e)
		{

		}

		private void EditorButtonImportNode_Click(object sender, EventArgs e)
		{

		}

		private void EditorButtonFindNode_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region Loading

		private void LoadSynchronizedDatabases(string filename, bool showerrors)
		{
			try
			{

				Parser.Deserialize(filename, out Launch launch);

				if (launch.UsageID != eUsage.Modder)
				{

					throw new Exception($"Usage type of the endscript is stated to be {launch.Usage}, while should be Modder");

				}

				if (launch.GameID == GameINT.None)
				{

					throw new Exception($"Invalid stated game type named {launch.Game}");

				}

				if (!Directory.Exists(launch.Directory))
				{

					throw new DirectoryNotFoundException($"Directory named {launch.Directory} does not exist");

				}

				if (launch.Files.Count == 0)
				{

					throw new ArgumentException("No files has been specified to load");

				}

				launch.CheckFiles();
				launch.LoadLinks();

				var watch = new Stopwatch();
				watch.Start();

				foreach (var file in launch.Files)
				{

					var sdb = new SyncDatabase(launch.GameID, launch.Directory, file);
					sdb.Load();
					this.SyncDBs.Add(sdb);

				}

				watch.Stop();
				this.EditorStatusLabel.Text = $"Files: {launch.Files.Count} | Time: {watch.ElapsedMilliseconds}ms | Script: {filename}";
				this.LoadTreeView();
				Configurations.Default.LaunchFile = filename;
				Configurations.Default.Save();

			}
			catch (Exception e)
			{

				if (showerrors)
				{

					MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
		}

		private void LoadTreeView()
		{
			this.EditorTreeView.Nodes.Clear();
			this.SyncDBs.Sort((x, y) => x.Filename.CompareTo(y.Filename));

			foreach (var db in this.SyncDBs)
			{

				this.EditorTreeView.Nodes.Add(db.GetTreeNodes());

			}

			this.EditorButtonFindNode.Enabled = true;

		}

		private void Editor_Load(object sender, EventArgs e)
		{
			var file = Configurations.Default.LaunchFile;
			if (!File.Exists(file)) return;
			else this.LoadSynchronizedDatabases(file, false);
		}

		#endregion

		#region TreeView Manage

		private void EditorTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (this.EditorTreeView.SelectedNode != null)
			{

				this.EditorTreeView.SelectedNode.ForeColor = this.EditorTreeView.ForeColor;

				e.Node.ForeColor = Configurations.Default.DarkTheme
					? Color.FromArgb(255, 230, 0)
					: Color.FromArgb(255, 20, 20);

			}
			else
			{

				e.Node.ForeColor = Configurations.Default.DarkTheme
					? Color.FromArgb(255, 230, 0)
					: Color.FromArgb(255, 90, 0);

			}
		}

		private void EditorTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(e.Node.FullPath);
			var selected = Utils.GetReflective(e.Node.FullPath, this.EditorTreeView.PathSeparator, this.SyncDBs);

			this.ManageButtonOpenEditor(selected);
			this.ManageButtonAddNode(e.Node);
			this.ManageButtonDeleteNode(e.Node);
			this.ManageButtonCopyNode(e.Node);
			this.ManageButtonExportNode(e.Node);
			this.ManageButtonImportNode(e.Node);

			this.EditorPropertyGrid.SelectedObject = selected;
		}

		#endregion


		private void EditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.ChangedItem.Label == "CollectionName")
			{

				this.EditorTreeView.SelectedNode.Text = e.ChangedItem.Value.ToString();
				this.EditorPropertyGrid.Refresh();

			}
		}

		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SyncDBs = null;
		}

	}
}
