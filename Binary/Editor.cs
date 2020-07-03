﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Binary.Enums;
using Binary.Endscript;
using Binary.Properties;
using Nikki.Core;
using Nikki.Utils;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;
using Nikki.Support.Shared.Class;
using CoreExtensions.Management;



namespace Binary
{
	public partial class Editor : Form
	{
		private List<SynchronizedDatabase> SyncDBs;
		private readonly List<Form> _openforms;
		private const string empty = "\"\"";

		public Editor()
		{
			this.SyncDBs = new List<SynchronizedDatabase>();
			this._openforms = new List<Form>();
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

			// Tree view
			this.EditorTreeView.BackColor = Theme.PrimBackColor;
			this.EditorTreeView.ForeColor = Theme.PrimForeColor;
			this.EditorTreeView.SelectedImageIndex = Configurations.Default.DarkTheme ? 3 : 2;
			this.EditorTreeView.ImageIndex = Configurations.Default.DarkTheme ? 1 : 0;

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
			this.EMSOptionsToggle.BackColor = Theme.MenuItemBackColor;
			this.EMSOptionsToggle.ForeColor = Theme.MenuItemForeColor;
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
			this.EditorButtonRemoveNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonRemoveNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonRemoveNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonCopyNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonCopyNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonCopyNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonExportNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonExportNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonExportNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonImportNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonImportNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonImportNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.EditorButtonScriptNode.BackColor = Theme.ButtonBackColor;
			this.EditorButtonScriptNode.ForeColor = Theme.ButtonForeColor;
			this.EditorButtonScriptNode.FlatAppearance.BorderColor = Theme.ButtonFlatColor;

			// Textboxes
			this.EditorCommandPrompt.BackColor = Theme.PrimBackColor;
			this.EditorCommandPrompt.ForeColor = Theme.PrimForeColor;
			this.EditorFindTextBox.BackColor = Theme.TextBoxBackColor;
			this.EditorFindTextBox.ForeColor = Theme.TextBoxForeColor;
		}

		#endregion

		#region Manage Controls

		private void CreateBackupsForFiles(bool forced)
		{
			try
			{

				if (this.SyncDBs.Count > 0)
				{

					foreach (var sdb in this.SyncDBs)
					{

						var from = sdb.FullPath;
						var to = $"{sdb.FullPath}.bacc";

						if (forced || (!forced && !File.Exists(to)))
						{

							File.Copy(from, to, true);

						}

					}

					if (forced)
					{

						MessageBox.Show("All files have been successfully backed up.", "Success",
							MessageBoxButtons.OK, MessageBoxIcon.Information);

					}

				}
				else
				{

					throw new Exception("No files are open and directory is not chosen");

				}

			}
			catch (Exception ex)
			{

				if (forced)
				{

					MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
		}

		private void ToggleControlsAfterLoad(bool enable)
		{
			this.EMSMainReloadFiles.Enabled = enable;
			this.EMSMainSaveFiles.Enabled = enable;
			this.EMSDatabaseReloadDB.Enabled = enable;
			this.EMSDatabaseSaveDB.Enabled = enable;
			this.EMSDatabaseCombineDB.Enabled = enable;
			this.EMSOptionsCreate.Enabled = enable;
			this.EMSOptionsRestore.Enabled = enable;
			this.EMSOptionsUnlock.Enabled = enable;
			this.EMSWindowsRun.Enabled = enable;
		}

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

		private void ManageButtonRemoveNode(TreeNode node)
		{
			if (node == null || node.Level != 2)
			{

				this.EditorButtonRemoveNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Parent.Text);

			if (sdb == null)
			{

				this.EditorButtonRemoveNode.Enabled = false;
				return;

			}

			var manager = sdb.Database.GetManager(node.Parent.Text);
			this.EditorButtonRemoveNode.Enabled = manager != null && !manager.IsReadOnly;
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
			this.EditorButtonExportNode.Enabled = manager != null;
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
			this.EditorButtonImportNode.Enabled = manager != null;
		}

		private void ManageButtonScriptNode(TreeNode node)
		{
			if (node == null || node.Level != 2)
			{

				this.EditorButtonScriptNode.Enabled = false;
				return;

			}

			var sdb = this.SyncDBs.Find(_ => _.Filename == node.Parent.Parent.Text);

			if (sdb == null)
			{

				this.EditorButtonScriptNode.Enabled = false;
				return;

			}

			var manager = sdb.Database.GetManager(node.Parent.Text);
			this.EditorButtonScriptNode.Enabled =
				manager != null &&
				!typeof(DBModelPart).IsAssignableFrom(manager.CollectionType) &&
				!typeof(FNGroup).IsAssignableFrom(manager.CollectionType) &&
				!typeof(STRBlock).IsAssignableFrom(manager.CollectionType);
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
				AutoUpgradeEnabled = true,
				CheckFileExists = true,
				CheckPathExists = true,
				Filter = "Endscript Files | *.end",
				Multiselect = false,
				Title = "Select Version 1 .end launcher to load",
			};

			if (browser.ShowDialog() == DialogResult.OK)
			{

				this.LoadSynchronizedDatabases(browser.FileName, true);

			}
		}

		private void EMSMainReloadFiles_Click(object sender, EventArgs e)
		{
			var file = Configurations.Default.LaunchFile;

			if (File.Exists(file))
			{

				this.LoadSynchronizedDatabases(file, true);

			}
			else
			{

				MessageBox.Show($"Launch file {file} does not exist or was moved.", "Warning", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void EMSMainSaveFiles_Click(object sender, EventArgs e)
		{
			this.SaveSynchronizedDatabases();
		}

		private void EMSMainExit_Click(object sender, EventArgs e)
		{
			this.Editor_FormClosing(this, null);
			this.Close();
		}

		private void EMSDatabaseLoadDB_Click(object sender, EventArgs e)

		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSDatabaseReloadDB_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSDatabaseSaveDB_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSDatabaseCombineDB_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSToolsHasher_Click(object sender, EventArgs e)
		{
			var hasher = new Hasher() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(hasher);
			hasher.Show();
		}

		private void EMSToolsRaider_Click(object sender, EventArgs e)
		{
			var raider = new Raider() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(raider);
			raider.Show();
		}

		private void EMSToolsSwatcher_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSOptionsCreate_Click(object sender, EventArgs e)
		{
			this.CreateBackupsForFiles(true);
		}

		private void EMSOptionsRestore_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSOptionsUnlock_Click(object sender, EventArgs e)
		{
			try
			{

				if (this.SyncDBs.Count > 0)
				{

					var path = this.SyncDBs[0].Folder;

					MemoryUnlock.FastUnlock(path + @"\GLOBAL\CARHEADERSMEMORYFILE.BIN");
					MemoryUnlock.FastUnlock(path + @"\GLOBAL\FRONTENDMEMORYFILE.BIN");
					MemoryUnlock.FastUnlock(path + @"\GLOBAL\INGAMEMEMORYFILE.BIN");
					MemoryUnlock.FastUnlock(path + @"\GLOBAL\PERMANENTMEMORYFILE.BIN");
					MemoryUnlock.LongUnlock(path + @"\GLOBAL\GLOBALMEMORYFILE.BIN");

					MessageBox.Show("Memory files were successfully unlocked for modding.", "Success");

				}
				else
				{

					throw new Exception("No files are open and directory is not chosen");

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void EMSOptionsToggle_Click(object sender, EventArgs e)
		{
			Configurations.Default.DarkTheme = !Configurations.Default.DarkTheme;
			Configurations.Default.Save();
			this.ToggleTheme();
		}

		private void EMSScriptingProcess_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not ready yet. Stay for the updates!", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void EMSScriptingGenerate_Click(object sender, EventArgs e)
		{
			if (this.EditorPropertyGrid.SelectedObject != null &&
				this.EditorPropertyGrid.SelectedGridItem.GridItemType == GridItemType.Property)
			{

				var path = this.EditorTreeView.SelectedNode.FullPath;
				var property = this.EditorPropertyGrid.SelectedGridItem.Label;
				var value = this.EditorPropertyGrid.SelectedGridItem.Value;
				var type = value.GetType();

				if (this.EditorPropertyGrid.SelectedGridItem.PropertyDescriptor.IsReadOnly) return;

				if (type != typeof(string) && typeof(IEnumerable).IsAssignableFrom(type)) return;

				var str = this.GenerateEndCommand(eCommandType.update, path, property, value.ToString());
				this.WriteLineToEndCommandPrompt(str);

			}
		}

		private void EMSScriptingClear_Click(object sender, EventArgs e)
		{
			this.EditorCommandPrompt.Text = String.Empty;
		}

		private void EMSWindowsRun_Click(object sender, EventArgs e)
		{
			try
			{

				// Considering at least ONE file is currently open
				if (this.SyncDBs.Count > 0)
				{

					var path = this.SyncDBs[0].Folder;
					var game = this.SyncDBs[0].Database.GameINT;
					var exe = path;

					exe += game switch
					{
						GameINT.Carbon => @"\NFSC.EXE",
						GameINT.MostWanted => @"\SPEED.EXE",
						GameINT.Prostreet => @"\NFS.EXE",
						GameINT.Undercover => @"\NFS.EXE",
						GameINT.Underground1 => @"\SPEED.EXE",
						GameINT.Underground2 => @"\SPEED2.EXE",
						_ => throw new Exception($"Game {game} is an invalid game type")
					};

					Process.Start(new ProcessStartInfo(exe) { WorkingDirectory = path });

				}
				else
				{

					throw new Exception("No files are open and directory is not chosen");

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void EMSWindowsNew_Click(object sender, EventArgs e)
		{
			var path = Process.GetCurrentProcess().MainModule.FileName;
			Process.Start(new ProcessStartInfo() { FileName = path });
		}

		private void EMSHelpAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Binary by MaxHwoy v2.0.0.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		private void EMSHelpTutorials_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming soon TM", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		#endregion

		#region Button Controls

		private void EditorButtonAddNode_Click(object sender, EventArgs e)
		{
			// This button is enabled only in managers, so it is 
			// safe to assume that we are in a manager TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);

			using var input = new Input("Enter name of the new collection");

			while (true) // use loop instead of recursion to prevent stack overflow
			{

				if (input.ShowDialog() == DialogResult.OK)
				{

					try
					{

						manager.Add(input.Value);
						var path = this.EditorTreeView.SelectedNode.FullPath;
						var str = this.GenerateEndCommand(eCommandType.add, path, input.Value);
						this.WriteLineToEndCommandPrompt(str);
						this.LoadTreeView(path);
						break;

					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}

				}
				else
				{

					break;

				}

			}
		}

		private void EditorButtonRemoveNode_Click(object sender, EventArgs e)
		{
			// This button is enabled only in collections, so it is 
			// safe to assume that we are in a collection TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Parent.Text;
			var cname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);
			
			try
			{

				this.EditorPropertyGrid.SelectedObject = null;
				manager.Remove(cname);
				var str = this.GenerateEndCommand(eCommandType.remove, this.EditorTreeView.SelectedNode.FullPath);
				this.WriteLineToEndCommandPrompt(str);
				this.LoadTreeView(this.EditorTreeView.SelectedNode.Parent.FullPath);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void EditorButtonCopyNode_Click(object sender, EventArgs e)
		{
			// This button is enabled only in collections, so it is 
			// safe to assume that we are in a collection TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Parent.Text;
			var cname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);

			using var input = new Input("Enter name of the new collection");

			while (true) // use loop instead of recursion to prevent stack overflow
			{

				if (input.ShowDialog() == DialogResult.OK)
				{

					try
					{

						manager.Clone(input.Value, cname);
						var path = this.EditorTreeView.SelectedNode.FullPath;
						var str = this.GenerateEndCommand(eCommandType.copy, path, input.Value);
						this.WriteLineToEndCommandPrompt(str);
						this.LoadTreeView(path);
						break;

					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}

				}
				else
				{

					break;

				}

			}
		}

		private void EditorButtonOpenEditor_Click(object sender, EventArgs e)
		{
			// This button is enabled only in collections, so it is 
			// safe to assume that we are in a collection TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Parent.Text;
			var cname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);

			var collection = manager[manager.FindIndex(cname)];

			if (collection is DBModelPart model)
			{

				using var editor = new CarPartsEditor(model);
				editor.ShowDialog();
				this.EditorPropertyGrid.Refresh();

			}
			else if (collection is FNGroup fng)
			{

				MessageBox.Show("Coming Soon M2", "SoonTM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
			else if (collection is TPKBlock tpk)
			{

				using var editor = new TextureEditor(tpk);
				editor.ShowDialog();
				this.EditorPropertyGrid.Refresh();

			}
			else if (collection is STRBlock str)
			{

				using var editor = new StringEditor(str);
				editor.ShowDialog();
				this.EditorPropertyGrid.Refresh();

			}
		}

		private void EditorButtonExportNode_Click(object sender, EventArgs e)
		{
			// This button is enabled only in collections, so it is 
			// safe to assume that we are in a collection TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Parent.Text;
			var cname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);

			using var exporter = new Exporter(manager.AllowsNoSerialization)
			{
				StartPosition = FormStartPosition.CenterScreen
			};

			if (exporter.ShowDialog() == DialogResult.OK)
			{

				using var dialog = new SaveFileDialog()
				{
					AddExtension = true,
					AutoUpgradeEnabled = true,
					CheckPathExists = true,
					DefaultExt = ".bin",
					Filter = "Binary Files|*.bin|Any Files|*.*",
					OverwritePrompt = true,
					SupportMultiDottedExtensions = true,
					Title = "Select filename where collection should be exported",
				};

				if (dialog.ShowDialog() == DialogResult.OK)
				{

					try
					{

						using var bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Create));
						manager.Export(cname, bw, exporter.Serialized);
						MessageBox.Show($"Collection {cname} has been exported to path {dialog.FileName}", "Info",
							MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;

					}

				}

			}
		}

		private void EditorButtonImportNode_Click(object sender, EventArgs e)
		{
			// This button is enabled only in managers, so it is 
			// safe to assume that we are in a manager TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);

			using var importer = new Importer()
			{
				StartPosition = FormStartPosition.CenterScreen
			};

			if (importer.ShowDialog() == DialogResult.OK)
			{

				using var dialog = new OpenFileDialog()
				{
					AutoUpgradeEnabled = true,
					CheckFileExists = true,
					CheckPathExists = true,
					Filter = "Binary Files|*.bin|All Files|*.*",
					Multiselect = false,
					SupportMultiDottedExtensions = true,
					Title = "Select file with collection to import"
				};

				if (dialog.ShowDialog() == DialogResult.OK)
				{

					try
					{

						var type = (Nikki.Reflection.Enum.eSerializeType)importer.SerializationIndex;
						using var br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));
						manager.Import(type, br);
						MessageBox.Show($"File {dialog.FileName} has been imported with type {type}", "Info",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.LoadTreeView(this.EditorTreeView.SelectedNode.FullPath);

					}
					catch (Exception ex)
					{
					
						MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					
					}

				}

			}
		}

		private void EditorButtonScriptNode_Click(object sender, EventArgs e)
		{
			// This button is enabled only in collections, so it is 
			// safe to assume that we are in a collection TreeNode

			var fname = this.EditorTreeView.SelectedNode.Parent.Parent.Text;
			var mname = this.EditorTreeView.SelectedNode.Parent.Text;
			var cname = this.EditorTreeView.SelectedNode.Text;

			var sdb = this.SyncDBs.Find(_ => _.Filename == fname);
			var manager = sdb.Database.GetManager(mname);
			var collection = manager[manager.IndexOf(cname)] as Collectable;

			var properties = collection.GetAccessibles().ToList();
			properties.Sort();

			var lines = new List<string>(properties.Count);
			var path = this.EditorTreeView.SelectedNode.FullPath;

			foreach (var property in properties)
			{

				if (property.Equals("CollectionName", StringComparison.InvariantCulture)) continue;
				var value = collection.GetValue(property);
				if (String.IsNullOrEmpty(value)) value = empty;
				lines.Add(this.GenerateEndCommand(eCommandType.update, path, property, value));

			}

			foreach (TreeNode node in this.EditorTreeView.SelectedNode.Nodes)
			{

				if (node.Nodes == null) continue;

				foreach (TreeNode subnode in node.Nodes)
				{

					path = subnode.FullPath;
					var expand = node.Text;
					var name = subnode.Text;
					var part = collection.GetSubPart(name, expand);
					if (part == null) continue;

					foreach (var property in part.GetAccessibles())
					{

						var value = part.GetValue(property);
						if (String.IsNullOrEmpty(value)) value = empty;
						lines.Add(this.GenerateEndCommand(eCommandType.update, path, property, value));

					}

				}

			}

			this.WriteLineToEndCommandPrompt(lines);
		}

		private void RecursiveNodeSelection(string path, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{

				if (node.FullPath == path)
				{

					this.EditorTreeView.SelectedNode = node;
					return;

				}
				else
				{

					this.RecursiveNodeSelection(path, node.Nodes);

				}

			}
		}

		private void RecursiveTreeHiglights(string match, TreeNodeCollection nodes)
		{

			foreach (TreeNode node in nodes)
			{

				node.BackColor = String.IsNullOrEmpty(match) || !node.Text.Contains(match)
					? this.EditorTreeView.BackColor
					: Configurations.Default.DarkTheme
						? Color.FromArgb(160, 20, 30)
						: Color.FromArgb(60, 255, 60);

				if (node.Nodes.Count > 0) this.RecursiveTreeHiglights(match, node.Nodes);

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

				this.SyncDBs.Clear();

				var watch = new Stopwatch();
				watch.Start();

				this.LoadAllDB(launch);

				watch.Stop();
				this.EditorStatusLabel.Text = $"Files: {launch.Files.Count} | Loading Time: {watch.ElapsedMilliseconds}ms | Script: {filename}";
				this.LoadTreeView();
				this.ToggleControlsAfterLoad(true);

				if (Configurations.Default.AutoBackups) this.CreateBackupsForFiles(false);

				Configurations.Default.LaunchFile = filename;
				Configurations.Default.Save();

			}
			catch (Exception e)
			{
			
				if (showerrors)
				{
			
					MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			
				}
			
				this.ToggleControlsAfterLoad(false);
			
			}
		}

		private void LoadTreeView(string selected = null)
		{
			this.EditorTreeView.Nodes.Clear();
			this.SyncDBs.Sort((x, y) => x.Filename.CompareTo(y.Filename));

			foreach (var db in this.SyncDBs)
			{

				this.EditorTreeView.Nodes.Add(db.GetTreeNodes());

			}

			if (!String.IsNullOrEmpty(selected))
			{

				this.RecursiveNodeSelection(selected, this.EditorTreeView.Nodes);

			}
			else
			{

				this.ManageButtonOpenEditor(null);
				this.ManageButtonAddNode(null);
				this.ManageButtonRemoveNode(null);
				this.ManageButtonCopyNode(null);
				this.ManageButtonExportNode(null);
				this.ManageButtonImportNode(null);
				this.ManageButtonScriptNode(null);

			}
		}

		private async void LoadAllDB(Launch launch)
		{
			var tasks = new List<Task>(launch.Files.Count);

			foreach (var file in launch.Files)
			{

				var sdb = new SynchronizedDatabase(launch.GameID, launch.Directory, file);
				this.SyncDBs.Add(sdb);
				tasks.Add(this.LoadOneDB(sdb));

			}

			await Task.WhenAll(tasks);
		}

		private Task LoadOneDB(SynchronizedDatabase sdb)
		{
			sdb.Load();
			return Task.CompletedTask;
		}

		#endregion

		#region Saving

		private void SaveSynchronizedDatabases()
		{
			try
			{

				var watch = new Stopwatch();
				watch.Start();

				this.SaveAllDB();

				watch.Stop();
				var filename = Configurations.Default.LaunchFile;
				this.EditorStatusLabel.Text = $"Files: {this.SyncDBs.Count} | Saving Time: {watch.ElapsedMilliseconds}ms | Script: {filename}";

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private async void SaveAllDB()
		{
			var tasks = new List<Task>(this.SyncDBs.Count);

			foreach (var sdb in this.SyncDBs)
			{

				tasks.Add(this.SaveOneDB(sdb));

			}

			await Task.WhenAll(tasks);
		}

		private Task SaveOneDB(SynchronizedDatabase sdb)
		{
			sdb.Save();
			return Task.CompletedTask;
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
			this.ManageButtonRemoveNode(e.Node);
			this.ManageButtonCopyNode(e.Node);
			this.ManageButtonExportNode(e.Node);
			this.ManageButtonImportNode(e.Node);
			this.ManageButtonScriptNode(e.Node);

			this.EditorPropertyGrid.SelectedObject = selected;
		}

		private void EditorTreeView_DoubleClick(object sender, EventArgs e)
		{
			if (this.EditorButtonOpenEditor.Enabled)
			{

				this.EditorButtonOpenEditor_Click(null, EventArgs.Empty);

			}
		}

		#endregion

		#region PropertyGrid Controls

		private void WriteLineToEndCommandPrompt(string line)
		{
			if (String.IsNullOrEmpty(this.EditorCommandPrompt.Text) ||
				this.EditorCommandPrompt.Text.EndsWith(Environment.NewLine))
			{

				this.EditorCommandPrompt.Text += line;

			}
			else
			{

				this.EditorCommandPrompt.Text += Environment.NewLine + line;

			}

			if (!this.EditorCommandPrompt.Text.EndsWith(Environment.NewLine))
			{

				this.EditorCommandPrompt.Text += Environment.NewLine;

			}

			this.EditorCommandPrompt.SelectionStart = this.EditorCommandPrompt.Text.Length - 1;
			this.EditorCommandPrompt.ScrollToCaret();
		}

		private void WriteLineToEndCommandPrompt(IEnumerable<string> lines)
		{
			var size = lines.Aggregate(0, (result, str) => result += str.Length + 2);
			var sb = new StringBuilder(size);

			foreach (var line in lines) sb.Append(line + Environment.NewLine);
			this.WriteLineToEndCommandPrompt(sb.ToString());
		}

		private string GenerateEndCommand(eCommandType type, string nodepath)
		{
			const string space = " ";
			var line = type.ToString() + space;
			var splits = nodepath.Split(this.EditorTreeView.PathSeparator);

			for (int loop = 0; loop < splits.Length - 1; ++loop)
			{

				var split = splits[loop];
				line += split.Contains(' ') ? $"\"{split}\"" + space : split + space;

			}

			line += splits[^1].Contains(' ') ? $"\"{splits[^1]}\"" : splits[^1];
			return line;
		}

		private string GenerateEndCommand(eCommandType type, string nodepath, params string[] args)
		{
			const string space = " ";
			var line = type.ToString() + space;
			var splits = nodepath.Split(this.EditorTreeView.PathSeparator);

			foreach (var split in splits)
			{

				line += split.Contains(' ') ? $"\"{split}\"" + space : split + space;

			}

			for (int loop = 0; loop < args.Length - 1; ++loop)
			{

				var arg = args[loop];
				line += arg.Contains(' ') ? $"\"{arg}\"" + space : arg + space;

			}

			line += args[^1].Contains(' ') ? $"\"{args[^1]}\"" : args[^1];
			return line;
		}

		private void EditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			var value = e.ChangedItem.Value.ToString();
			if (String.IsNullOrEmpty(value)) value = empty;
			
			var str = this.GenerateEndCommand(eCommandType.update, this.EditorTreeView.SelectedNode.FullPath,
				e.ChangedItem.Label, value);
			
			this.WriteLineToEndCommandPrompt(str);

			if (e.ChangedItem.Label == "CollectionName")
			{

				this.EditorTreeView.SelectedNode.Text = e.ChangedItem.Value.ToString();
				this.EditorPropertyGrid.Refresh();

			}
		}

		private void EditorFindTextBox_TextChanged(object sender, EventArgs e)
		{
			this.RecursiveTreeHiglights(this.EditorFindTextBox.Text, this.EditorTreeView.Nodes);
		}

		#endregion

		#region Editor Main

		private void Editor_Load(object sender, EventArgs e)
		{
			var file = Configurations.Default.LaunchFile;
			if (!File.Exists(file)) return;
			else this.LoadSynchronizedDatabases(file, false);
		}

		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SyncDBs = null;

			foreach (var form in this._openforms)
			{

				try { form.Close(); }
				catch { }

			}
		}

		#endregion

		#region Exception

		internal void EmergencySaveDatabase()
		{
			var date = DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss");
			string backup = $"DB_{date}";


			Directory.CreateDirectory(backup);

			foreach (var sdb in this.SyncDBs)
			{

				var filepath = $"{backup}\\{sdb.Filename.Replace('\\', '_')}";
				Directory.CreateDirectory(filepath);

				foreach (var manager in sdb.Database.Managers)
				{

					var managedpath = $"{filepath}\\{manager.Name}";
					Directory.CreateDirectory(managedpath);

					foreach (Collectable collection in manager)
					{

						if (collection is IAssembly asm)
						{

							var cpath = $"{managedpath}\\{collection.CollectionName}.bin";

							using var bw = new BinaryWriter(File.Open(cpath, FileMode.Create));
							asm.Serialize(bw);

						}

					}

				}

			}
		}

		#endregion
	}
}
