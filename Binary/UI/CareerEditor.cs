using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Binary.Tools;
using Binary.Prompt;
using Binary.Properties;
using Endscript.Enums;
using Nikki.Reflection.Abstract;
using Nikki.Support.Shared.Class;
using CoreExtensions.Management;



namespace Binary.UI
{
	public partial class CareerEditor : Form
	{
		private GCareer Career { get; }
		private readonly List<Form> _openforms;
		private readonly string _careerpath;
		private const string empty = "\"\"";
		public List<string> Commands { get; }

		public CareerEditor(GCareer career, string path)
		{
			this._openforms = new List<Form>();
			this.Commands = new List<string>();
			this.Career = career;
			this._careerpath = path;
			this.InitializeComponent();
			this.splitContainer2.FixedPanel = FixedPanel.Panel1;
			this.Text = $"{this.Career.CollectionName} Editor";
			this.ToggleTheme();
			this.LoadTreeView();
			this.ToggleMenuStripControls(null);
		}

		#region Theme

		private void ToggleTheme()
		{
			// Renderers
			this.CareerEditorMenuStrip.Renderer = new Theme.MenuStripRenderer();

			// Primary colors and controls
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;

			// Tree view
			this.CareerTreeView.BackColor = Theme.PrimBackColor;
			this.CareerTreeView.ForeColor = Theme.PrimForeColor;

			// Property grid
			this.CareerPropertyGrid.BackColor = Theme.PrimBackColor;
			this.CareerPropertyGrid.CategorySplitterColor = Theme.ButtonBackColor;
			this.CareerPropertyGrid.CategoryForeColor = Theme.TextBoxForeColor;
			this.CareerPropertyGrid.CommandsBackColor = Theme.PrimBackColor;
			this.CareerPropertyGrid.CommandsForeColor = Theme.PrimForeColor;
			this.CareerPropertyGrid.CommandsBorderColor = Theme.PrimBackColor;
			this.CareerPropertyGrid.DisabledItemForeColor = Theme.LabelTextColor;
			this.CareerPropertyGrid.LineColor = Theme.ButtonBackColor;
			this.CareerPropertyGrid.SelectedItemWithFocusBackColor = Theme.FocusedBackColor;
			this.CareerPropertyGrid.SelectedItemWithFocusForeColor = Theme.FocusedForeColor;
			this.CareerPropertyGrid.ViewBorderColor = Theme.RegBorderColor;
			this.CareerPropertyGrid.ViewBackColor = Theme.PrimBackColor;
			this.CareerPropertyGrid.ViewForeColor = Theme.PrimForeColor;
			this.CareerPropertyGrid.HelpBackColor = Theme.PrimBackColor;
			this.CareerPropertyGrid.HelpForeColor = Theme.PrimForeColor;
			this.CareerPropertyGrid.HelpBorderColor = Theme.RegBorderColor;

			// Search bar
			this.CareerSearchBar.BackColor = Theme.TextBoxBackColor;
			this.CareerSearchBar.ForeColor = Theme.TextBoxForeColor;

			// Menu strip and menu items
			this.CareerEditorMenuStrip.ForeColor = Theme.LabelTextColor;
			this.AddCollectionToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.AddCollectionToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.RemoveCollectionToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.RemoveCollectionToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.CopyCollectionToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.CopyCollectionToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.ScriptCollectionToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.ScriptCollectionToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.HasherToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.HasherToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.RaiderToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.RaiderToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
		}

		#endregion

		#region Methods

		private object GetSelectedObject(TreeNode node)
		{
			if (node is null)
			{

				return null;

			}
			else if (node.Level == 1)
			{

				return this.Career.GetCollection(node.Text, node.Parent.Text);

			}
			else if (node.Level == 3)
			{

				var cname = node.Parent.Parent.Text;
				var root = node.Parent.Parent.Parent.Text;
				var collection = this.Career.GetCollection(cname, root);
				return collection?.GetSubPart(node.Text, node.Parent.Text);

			}
			else
			{

				return null;

			}
		}

		private void LoadTreeView(string selected = null)
		{
			this.CareerTreeView.Nodes.Clear();
			this.CareerTreeView.BeginUpdate();

			for (int i = 0; i < this.Career.AllRootNames.Length; ++i)
			{

				var root = this.Career.GetRoot(this.Career.AllRootNames[i]);
				var node = new TreeNode(this.Career.AllRootNames[i]);

				foreach (Collectable collection in root)
				{

					node.Nodes.Add(Utils.GetCollectionNodes(collection));

				}

				this.CareerTreeView.Nodes.Add(node);

			}

			this.CareerTreeView.EndUpdate();

			if (!String.IsNullOrEmpty(selected))
			{

				this.RecursiveNodeSelection(selected, this.CareerTreeView.Nodes);

			}
		}

		private void RecursiveNodeSelection(string path, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{

				if (node.FullPath == path)
				{

					this.CareerTreeView.SelectedNode = node;
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
					? this.CareerTreeView.BackColor
					: Configurations.Default.DarkTheme
						? Color.FromArgb(160, 20, 30)
						: Color.FromArgb(60, 255, 60);

				if (node.Nodes.Count > 0) this.RecursiveTreeHiglights(match, node.Nodes);

			}

		}

		private void ToggleMenuStripControls(TreeNode node)
		{
			if (node is null)
			{

				this.AddCollectionToolStripMenuItem.Enabled = false;
				this.RemoveCollectionToolStripMenuItem.Enabled = false;
				this.CopyCollectionToolStripMenuItem.Enabled = false;
				this.ScriptCollectionToolStripMenuItem.Enabled = false;

			}
			else
			{

				this.AddCollectionToolStripMenuItem.Enabled = node.Level == 0;
				this.RemoveCollectionToolStripMenuItem.Enabled = node.Level == 1;
				this.CopyCollectionToolStripMenuItem.Enabled = node.Level == 1;
				this.ScriptCollectionToolStripMenuItem.Enabled = node.Level == 1;

			}
		}

		#endregion

		#region Editing

		private void CareerPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			var value = e.ChangedItem.Value.ToString();
			var node = this.CareerTreeView.SelectedNode;

			if (e.ChangedItem.Label == "CollectionName")
			{

				node.Text = value;
				this.CareerPropertyGrid.Refresh();

			}

			this.GenerateUpdateInCareerCommand(node.FullPath, e.ChangedItem.Label, value);
			this.CareerPropertyGrid.Refresh();
		}

		private void CareerTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (this.CareerTreeView.SelectedNode != null)
			{

				this.CareerTreeView.SelectedNode.ForeColor = this.CareerTreeView.ForeColor;

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

		private void CareerTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(e.Node?.FullPath);
			var selected = this.GetSelectedObject(e.Node);
			this.ToggleMenuStripControls(e.Node);
			this.CareerPropertyGrid.SelectedObject = selected;
		}

		private void CareerSearchBar_TextChanged(object sender, EventArgs e)
		{
			this.RecursiveTreeHiglights(this.CareerSearchBar.Text, this.CareerTreeView.Nodes);
		}

		#endregion

		#region Menu Strip

		private void AddCollectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Considering this option is enabled only in roots

			var text = this.CareerTreeView.SelectedNode.Text;
			using var input = new Input("Enter name of the new collection");

			while (true) // use loop instead of recursion to prevent stack overflow
			{

				if (input.ShowDialog() == DialogResult.OK)
				{

					try
					{

						this.Career.AddCollection(input.Value, text);
						var path = this.CareerTreeView.SelectedNode.FullPath;
						var collection = this.Career.GetCollection(input.Value, text);
						this.CareerTreeView.SelectedNode.Nodes.Add(Utils.GetCollectionNodes(collection));
						this.GenerateAddInCareerCommand(text, input.Value);
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

		private void RemoveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Considering this option is enabled only in collections

			try
			{

				var node = this.CareerTreeView.SelectedNode;
				this.Career.RemoveCollection(node.Text, node.Parent.Text);
				this.CareerPropertyGrid.SelectedObject = null;
				this.GenerateRemoveInCareerCommand(node.Parent.Text, node.Text);
				this.CareerTreeView.SelectedNode.Remove();

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void CopyCollectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Considering this option is enabled only in collections

			var node = this.CareerTreeView.SelectedNode;
			using var input = new Input("Enter name of the new collection");

			while (true) // use loop instead of recursion to prevent stack overflow
			{

				if (input.ShowDialog() == DialogResult.OK)
				{

					try
					{

						this.Career.CloneCollection(input.Value, node.Text, node.Parent.Text);
						var path = node.FullPath;
						var collection = this.Career.GetCollection(input.Value, node.Parent.Text);
						node.Parent.Nodes.Add(Utils.GetCollectionNodes(collection));
						this.GenerateCopyInCareerCommand(node.Parent.Text, node.Text, input.Value);
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

		private void ScriptCollectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Considering this option is enabled only in collections

			var current = this.CareerTreeView.SelectedNode;
			var collection = this.Career.GetCollection(current.Text, current.Parent.Text);

			var properties = collection.GetAccessibles().ToList();
			properties.Sort();

			var lines = new List<string>(properties.Count);
			var path = current.FullPath;

			foreach (var property in properties)
			{

				if (property.Equals("CollectionName", StringComparison.InvariantCulture)) continue;
				var value = collection.GetValue(property);
				if (String.IsNullOrEmpty(value)) value = empty;
				this.GenerateUpdateInCareerCommand(path, property, value);

			}

			foreach (TreeNode node in current.Nodes)
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
						this.GenerateUpdateInCareerCommand(path, property, value);

					}

				}

			}
		}

		private void HasherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var hasher = new Hasher() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(hasher);
			hasher.Show();
		}

		private void RaiderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var raider = new Raider() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(raider);
			raider.Show();
		}

		#endregion

		#region Events

		private void CareerEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (var form in this._openforms)
			{

				try { form.Close(); }
				catch { }

			}
		}

		private void GenerateUpdateInCareerCommand(string nodepath, string property, string value)
		{
			var splits = nodepath.Split(this.CareerTreeView.PathSeparator, StringSplitOptions.RemoveEmptyEntries);

			// Always 2 options: 2-split path of 4-splits path
			string command = String.Empty;
			if (property.Contains(' ')) property = $"\"{property}\"";
			if (value.Contains(' ')) property = $"\"{value}\"";

			if (splits.Length == 2)
			{

				if (splits[0].Contains(' ')) splits[0] = $"\"{splits[0]}\"";
				if (splits[1].Contains(' ')) splits[1] = $"\"{splits[1]}\"";
				command = $"{eCommandType.update_incareer} {this._careerpath} {splits[0]} " +
					$"{splits[1]} {property} {value}";

			}
			else if (splits.Length == 4)
			{

				if (splits[0].Contains(' ')) splits[0] = $"\"{splits[0]}\"";
				if (splits[1].Contains(' ')) splits[1] = $"\"{splits[1]}\"";
				if (splits[2].Contains(' ')) splits[2] = $"\"{splits[2]}\"";
				if (splits[3].Contains(' ')) splits[3] = $"\"{splits[3]}\"";
				command = $"{eCommandType.update_incareer} {this._careerpath} {splits[0]} " +
					$"{splits[1]} {splits[2]} {splits[3]} {property} {value}";

			}

			this.Commands.Add(command);
		}

		private void GenerateAddInCareerCommand(string root, string cname)
		{
			if (root.Contains(' ')) root = $"\"{root}\"";
			if (cname.Contains(' ')) cname = $"\"{cname}\"";
			var command = $"{eCommandType.add_incareer} {this._careerpath} {root} {cname}";
			this.Commands.Add(command);
		}

		private void GenerateRemoveInCareerCommand(string root, string cname)
		{
			if (root.Contains(' ')) root = $"\"{root}\"";
			if (cname.Contains(' ')) cname = $"\"{cname}\"";
			var command = $"{eCommandType.remove_incareer} {this._careerpath} {root} {cname}";
			this.Commands.Add(command);
		}

		private void GenerateCopyInCareerCommand(string root, string copyname, string newname)
		{
			if (root.Contains(' ')) root = $"\"{root}\"";
			if (copyname.Contains(' ')) copyname = $"\"{copyname}\"";
			if (newname.Contains(' ')) newname = $"\"{newname}\"";
			var command = $"{eCommandType.copy_incareer} {this._careerpath} {root} {copyname} {newname}";
			this.Commands.Add(command);
		}

		#endregion
	}
}
