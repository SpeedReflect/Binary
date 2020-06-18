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
using System.Net.PeerToPeer.Collaboration;
using System.Reflection;
using System.Runtime.InteropServices;

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
			// Renderers
			this.EditorStatusStrip.Renderer = new Theme.StatStripRenderer();
			this.EditorMenuStrip.Renderer = new Theme.MenuStripRenderer();

			// Primary colors and controls
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.EditorTreeView.BackColor = Theme.PrimBackColor;
			this.EditorTreeView.ForeColor = Theme.PrimForeColor;

			// Property grid
			this.EditorPropertyGrid.BackColor = Theme.PrimBackColor;
			this.EditorPropertyGrid.CategorySplitterColor = Theme.ButtonBackColor;
			this.EditorPropertyGrid.CategoryForeColor = Theme.TextBoxForeColor;
			this.EditorPropertyGrid.CommandsBackColor = Theme.PrimBackColor;
			this.EditorPropertyGrid.CommandsForeColor = Theme.PrimForeColor;
			this.EditorPropertyGrid.CommandsBorderColor = Theme.PrimBackColor;
			this.EditorPropertyGrid.DisabledItemForeColor = Theme.LabelTextColor;
			this.EditorPropertyGrid.LineColor = Theme.ButtonBackColor;
			this.EditorPropertyGrid.SelectedItemWithFocusBackColor = Theme.FocusedBackColor;
			this.EditorPropertyGrid.SelectedItemWithFocusForeColor = Theme.FocusedForeColor;
			this.EditorPropertyGrid.ViewBorderColor = Theme.RegBorderColor;
			this.EditorPropertyGrid.ViewBackColor = Theme.PrimBackColor;
			this.EditorPropertyGrid.ViewForeColor = Theme.PrimForeColor;

			// Menu strip and menu items
			this.EditorMenuStrip.ForeColor = Theme.LabelTextColor;
			this.EMSMainNewLauncher.BackColor = Theme.MenuItemBackColor;
			this.EMSMainNewLauncher.ForeColor = Theme.MenuItemForeColor;
			this.EMSMainLoadFiles.BackColor = Theme.MenuItemBackColor;
			this.EMSMainLoadFiles.ForeColor = Theme.MenuItemForeColor;
			this.EMSMainReloadFiles.BackColor = Theme.MenuItemBackColor;
			this.EMSMainReloadFiles.ForeColor = Theme.MenuItemForeColor;
			this.EMSMainSaveFiles.BackColor = Theme.MenuItemBackColor;
			this.EMSMainSaveFiles.ForeColor = Theme.MenuItemForeColor;
			this.EMSMainExit.BackColor = Theme.MenuItemBackColor;
			this.EMSMainExit.ForeColor = Theme.MenuItemForeColor;
			this.EMSDatabaseLoadDB.BackColor = Theme.MenuItemBackColor;
			this.EMSDatabaseLoadDB.ForeColor = Theme.MenuItemForeColor;
			this.EMSDatabaseReloadDB.BackColor = Theme.MenuItemBackColor;
			this.EMSDatabaseReloadDB.ForeColor = Theme.MenuItemForeColor;
			this.EMSDatabaseSaveDB.BackColor = Theme.MenuItemBackColor;
			this.EMSDatabaseSaveDB.ForeColor = Theme.MenuItemForeColor;
			this.EMSDatabaseCombineDB.BackColor = Theme.MenuItemBackColor;
			this.EMSDatabaseCombineDB.ForeColor = Theme.MenuItemForeColor;
			this.EMSToolsHasher.BackColor = Theme.MenuItemBackColor;
			this.EMSToolsHasher.ForeColor = Theme.MenuItemForeColor;
			this.EMSToolsRaider.BackColor = Theme.MenuItemBackColor;
			this.EMSToolsRaider.ForeColor = Theme.MenuItemForeColor;
			this.EMSToolsSwatcher.BackColor = Theme.MenuItemBackColor;
			this.EMSToolsSwatcher.ForeColor = Theme.MenuItemForeColor;
			this.EMSOptionsCreate.BackColor = Theme.MenuItemBackColor;
			this.EMSOptionsCreate.ForeColor = Theme.MenuItemForeColor;
			this.EMSOptionsRestore.BackColor = Theme.MenuItemBackColor;
			this.EMSOptionsRestore.ForeColor = Theme.MenuItemForeColor;
			this.EMSOptionsUnlock.BackColor = Theme.MenuItemBackColor;
			this.EMSOptionsUnlock.ForeColor = Theme.MenuItemForeColor;
			this.EMSScriptingProcess.BackColor = Theme.MenuItemBackColor;
			this.EMSScriptingProcess.ForeColor = Theme.MenuItemForeColor;
			this.EMSScriptingGenerate.BackColor = Theme.MenuItemBackColor;
			this.EMSScriptingGenerate.ForeColor = Theme.MenuItemForeColor;
			this.EMSScriptingClear.BackColor = Theme.MenuItemBackColor;
			this.EMSScriptingClear.ForeColor = Theme.MenuItemForeColor;
			this.EMSWindowsRun.BackColor = Theme.MenuItemBackColor;
			this.EMSWindowsRun.ForeColor = Theme.MenuItemForeColor;
			this.EMSWindowsNew.BackColor = Theme.MenuItemBackColor;
			this.EMSWindowsNew.ForeColor = Theme.MenuItemForeColor;
			this.EMSHelpAbout.BackColor = Theme.MenuItemBackColor;
			this.EMSHelpAbout.ForeColor = Theme.MenuItemForeColor;
			this.EMSHelpTutorials.BackColor = Theme.MenuItemBackColor;
			this.EMSHelpTutorials.ForeColor = Theme.MenuItemForeColor;

			// Buttons
			this.EditorButtonOpenEditor.BackColor = Theme.ButtonBackColor;
			this.EditorButtonOpenEditor.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonOpenEditor.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonAddNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonAddNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonAddNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonDeleteNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonDeleteNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonDeleteNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonCopyNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonCopyNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonCopyNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonExportNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonExportNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonExportNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonImportNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonImportNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonImportNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonFindNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonFindNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonFindNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;

			// Textboxes
			this.EditorCommandPrompt.BackColor = Theme.PrimBackColor;
			this.EditorCommandPrompt.ForeColor = Theme.PrimForeColor;
			this.EditorFindTextBox.BackColor = Theme.TextBoxBackColor;
			this.EditorFindTextBox.ForeColor = Theme.TextBoxForeColor;
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
			this.EditorCommandPrompt.Text = String.Empty;
		}

		private void EMSWindowsRun_Click(object sender, EventArgs e)
		{

		}

		private void EMSWindowsNew_Click(object sender, EventArgs e)
		{
			var path = Process.GetCurrentProcess().MainModule.FileName;
			Process.Start(new ProcessStartInfo() { FileName = path });
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
			this.RecursiveTreeHiglight(this.EditorFindTextBox.Text, this.EditorTreeView.Nodes);
		}

		private void RecursiveTreeHiglight(string match, TreeNodeCollection nodes)
		{

			foreach (TreeNode node in nodes)
			{

				node.BackColor = String.IsNullOrEmpty(match) || !node.Text.Contains(match)
					? this.EditorTreeView.BackColor
					: Configurations.Default.DarkTheme
						? Color.FromArgb(160, 20, 30)
						: Color.FromArgb(60, 255, 60);

				if (node.Nodes.Count > 0) this.RecursiveTreeHiglight(match, node.Nodes);

			}

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

		#region TreeView Controls

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

		#region PropertyGrid Controls

		private void WriteLineToEndCommandPrompt(string line)
		{
			if (String.IsNullOrEmpty(this.EditorCommandPrompt.Text) ||
				this.EditorCommandPrompt.Text.EndsWith(Environment.NewLine))
			{

				this.EditorCommandPrompt.Text += line + Environment.NewLine;

			}
			else
			{

				this.EditorCommandPrompt.Text += Environment.NewLine + line + Environment.NewLine;

			}
		}

		private void InjectEndCommand(eCommandType type, string nodepath)
		{
			const string space = " ";
			var line = type.ToString() + space;
			var splits = nodepath.Split(this.EditorTreeView.PathSeparator);

			for (int loop = 0; loop < splits.Length - 1; ++loop) line += splits[loop] + space;

			line += splits[^1];
			this.WriteLineToEndCommandPrompt(line);
		}

		private void InjectEndCommand(eCommandType type, string nodepath, params string[] args)
		{
			const string space = " ";
			var line = type.ToString() + space;
			var splits = nodepath.Split(this.EditorTreeView.PathSeparator);

			foreach (var split in splits) line += split + space;

			for (int loop = 0; loop < args.Length - 1; ++loop) line += args[loop] + space;

			line += args[^1];
			this.WriteLineToEndCommandPrompt(line);
		}

		private void EditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			this.InjectEndCommand(eCommandType.update, this.EditorTreeView.SelectedNode.FullPath,
				e.ChangedItem.Label, e.ChangedItem.Value.ToString());

			if (e.ChangedItem.Label == "CollectionName")
			{

				this.EditorTreeView.SelectedNode.Text = e.ChangedItem.Value.ToString();
				this.EditorPropertyGrid.Refresh();

			}
		}

		#endregion

		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SyncDBs = null;
		}

	}
}
