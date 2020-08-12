using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Binary.Tools;
using Binary.Prompt;
using Binary.Interact;
using Binary.Properties;
using Nikki.Core;
using Nikki.Support.Shared.Class;
using Nikki.Support.Shared.Parts.CarParts;



namespace Binary.UI
{
	public partial class CarPartsEditor : Form
	{
		private DBModelPart Model { get; }
		private readonly List<Form> _openforms;

		public CarPartsEditor(DBModelPart model)
		{
			this._openforms = new List<Form>();
			this.InitializeComponent();
			this.ToggleTheme();
			this.Model = model;
			this.Text = $"{this.Model.CollectionName} Editor";
			this.LoadTreeView();
			this.ToggleMenuStripControls(null);

			if (this.Model.GameINT != GameINT.MostWanted && this.Model.GameINT != GameINT.Underground2)
			{

				this.FindAndReplaceToolStripMenuItem.Enabled = false;

			}
		}

		#region Theme

		private void ToggleTheme()
		{
			// Renderers
			this.CarPartsEditorMenuStrip.Renderer = new Theme.MenuStripRenderer();

			// Primary colors and controls
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;

			// Tree view
			this.CarPartsTreeView.BackColor = Theme.PrimBackColor;
			this.CarPartsTreeView.ForeColor = Theme.PrimForeColor;

			// Property grid
			this.CarPartsPropertyGrid.BackColor = Theme.PrimBackColor;
			this.CarPartsPropertyGrid.CategorySplitterColor = Theme.ButtonBackColor;
			this.CarPartsPropertyGrid.CategoryForeColor = Theme.TextBoxForeColor;
			this.CarPartsPropertyGrid.CommandsBackColor = Theme.PrimBackColor;
			this.CarPartsPropertyGrid.CommandsForeColor = Theme.PrimForeColor;
			this.CarPartsPropertyGrid.CommandsBorderColor = Theme.PrimBackColor;
			this.CarPartsPropertyGrid.DisabledItemForeColor = Theme.LabelTextColor;
			this.CarPartsPropertyGrid.LineColor = Theme.ButtonBackColor;
			this.CarPartsPropertyGrid.SelectedItemWithFocusBackColor = Theme.FocusedBackColor;
			this.CarPartsPropertyGrid.SelectedItemWithFocusForeColor = Theme.FocusedForeColor;
			this.CarPartsPropertyGrid.ViewBorderColor = Theme.RegBorderColor;
			this.CarPartsPropertyGrid.ViewBackColor = Theme.PrimBackColor;
			this.CarPartsPropertyGrid.ViewForeColor = Theme.PrimForeColor;
			this.CarPartsPropertyGrid.HelpBackColor = Theme.PrimBackColor;
			this.CarPartsPropertyGrid.HelpForeColor = Theme.PrimForeColor;
			this.CarPartsPropertyGrid.HelpBorderColor = Theme.RegBorderColor;

			// Menu strip and menu items
			this.CarPartsEditorMenuStrip.ForeColor = Theme.LabelTextColor;
			this.AddPartToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.AddPartToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.RemovePartToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.RemovePartToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.CopyPartToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.CopyPartToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.MoveUpPartsToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.MoveUpPartsToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.MoveDownPartsToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.MoveDownPartsToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.MoveFirstPartsToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.MoveFirstPartsToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.MoveLastPartsToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.MoveLastPartsToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.ReversePartsToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.ReversePartsToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.SortPartsByNameToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.SortPartsByNameToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.FindAndReplaceToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.FindAndReplaceToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.AddAttributeToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.AddAttributeToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.RemoveAttributeToolStripMenuItem.BackColor = Theme.MenuItemBackColor;			
			this.RemoveAttributeToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.MoveUpAttributesToolStripMenuItem.BackColor = Theme.MenuItemBackColor;			
			this.MoveUpAttributesToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.MoveDownAttributesToolStripMenuItem.BackColor = Theme.MenuItemBackColor;			
			this.MoveDownAttributesToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.ReverseAttributesToolStripMenuItem.BackColor = Theme.MenuItemBackColor;			
			this.ReverseAttributesToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.SortAttributesByKeyToolStripMenuItem.BackColor = Theme.MenuItemBackColor;			
			this.SortAttributesByKeyToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.HasherToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.HasherToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
			this.RaiderToolStripMenuItem.BackColor = Theme.MenuItemBackColor;
			this.RaiderToolStripMenuItem.ForeColor = Theme.MenuItemForeColor;
		}

		#endregion

		#region Methods

		private object GetSelectedObject(TreeNode node)
		{
			// Since there are only 2 levels overall, check node level
			if (node is null)
			{

				return null;

			}
			else if (node.Level == 0)
			{

				return this.Model.GetRealPart(node.Index);

			}
			else
			{

				var index = node.Parent.Index;
				return this.Model.GetRealPart(index).GetAttribute(node.Index);

			}
		}

		private void LoadTreeView(string selected = null)
		{
			this.CarPartsTreeView.Nodes.Clear();
			this.CarPartsTreeView.BeginUpdate();
			var nodes = new TreeNode[this.Model.CarPartsCount];
			int count = 0;

			foreach (var realpart in this.Model.ModelCarParts)
			{

				var level0 = new TreeNode(realpart.PartName);

				foreach (var attribute in realpart.Attributes)
				{

					var level1 = new TreeNode(attribute.ToString());
					level0.Nodes.Add(level1);

				}

				nodes[count++] = level0;

			}

			this.CarPartsTreeView.Nodes.AddRange(nodes);
			this.CarPartsTreeView.EndUpdate();

			if (!String.IsNullOrEmpty(selected))
			{

				this.RecursiveNodeSelection(selected, this.CarPartsTreeView.Nodes);

			}
		}

		private void RecursiveNodeSelection(string path, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{

				if (node.FullPath == path)
				{

					this.CarPartsTreeView.SelectedNode = node;
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
					? this.CarPartsTreeView.BackColor
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

				this.AddPartToolStripMenuItem.Enabled = true;
				this.RemovePartToolStripMenuItem.Enabled = false;
				this.CopyPartToolStripMenuItem.Enabled = false;
				this.MoveUpPartsToolStripMenuItem.Enabled = false;
				this.MoveDownPartsToolStripMenuItem.Enabled = false;
				this.MoveFirstPartsToolStripMenuItem.Enabled = false;
				this.MoveLastPartsToolStripMenuItem.Enabled = false;
				this.ReversePartsToolStripMenuItem.Enabled = false;
				this.SortPartsByNameToolStripMenuItem.Enabled = false;
				this.AddAttributeToolStripMenuItem.Enabled = false;
				this.RemoveAttributeToolStripMenuItem.Enabled = false;
				this.MoveUpAttributesToolStripMenuItem.Enabled = false;
				this.MoveDownAttributesToolStripMenuItem.Enabled = false;
				this.ReverseAttributesToolStripMenuItem.Enabled = false;
				this.SortAttributesByKeyToolStripMenuItem.Enabled = false;

			}
			else
			{

				this.AddPartToolStripMenuItem.Enabled = node.Level == 0;
				this.RemovePartToolStripMenuItem.Enabled = node.Level == 0;
				this.CopyPartToolStripMenuItem.Enabled = node.Level == 0;
				this.MoveUpPartsToolStripMenuItem.Enabled = node.Level == 0;
				this.MoveDownPartsToolStripMenuItem.Enabled = node.Level == 0;
				this.MoveFirstPartsToolStripMenuItem.Enabled = node.Level == 0;
				this.MoveLastPartsToolStripMenuItem.Enabled = node.Level == 0;
				this.ReversePartsToolStripMenuItem.Enabled = node.Level == 0;
				this.SortPartsByNameToolStripMenuItem.Enabled = node.Level == 0;
				this.AddAttributeToolStripMenuItem.Enabled = node.Level == 0;
				this.RemoveAttributeToolStripMenuItem.Enabled = node.Level == 1;
				this.MoveUpAttributesToolStripMenuItem.Enabled = node.Level == 1;
				this.MoveDownAttributesToolStripMenuItem.Enabled = node.Level == 1;
				this.ReverseAttributesToolStripMenuItem.Enabled = node.Level == 0;
				this.SortAttributesByKeyToolStripMenuItem.Enabled = node.Level == 0;

			}
		}

		#endregion

		#region Menu Strip Controls

		private void AddPartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node or no node at all

			this.Model.AddRealPart();
			this.CarPartsTreeView.Nodes.Add(this.Model.GetLastPart().PartName);
		}

		private void RemovePartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			var index = this.CarPartsTreeView.SelectedNode.Index;
			this.Model.RemovePart(index);
			this.CarPartsTreeView.Nodes.RemoveAt(index);

			if (this.CarPartsTreeView.Nodes.Count == 0)
			{

				this.ToggleMenuStripControls(this.CarPartsTreeView.SelectedNode);
				this.CarPartsPropertyGrid.SelectedObject = null;

			}
		}

		private void CopyPartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			var index = this.CarPartsTreeView.SelectedNode.Index;
			this.Model.ClonePart(index);

			var realpart = this.Model.GetLastPart();

			var level0 = new TreeNode(realpart.PartName);

			foreach (var attribute in realpart.Attributes)
			{

				var level1 = new TreeNode(attribute.ToString());
				level0.Nodes.Add(level1);

			}

			this.CarPartsTreeView.Nodes.Add(level0);
		}

		private void MoveUpPartsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			var path = this.CarPartsTreeView.SelectedNode.FullPath;
			var index1 = this.CarPartsTreeView.SelectedNode.Index;
			var index2 = index1 - 1;

			if (index2 < 0)
			{

				MessageBox.Show("Unable to move up because selected node is the up most node",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}

			// Switch parts
			this.CarPartsTreeView.BeginUpdate();

			var temp = this.Model.ModelCarParts[index1];
			this.Model.ModelCarParts[index1] = this.Model.ModelCarParts[index2];
			this.Model.ModelCarParts[index2] = temp;

			var node1 = this.CarPartsTreeView.Nodes[index1];
			var node2 = this.CarPartsTreeView.Nodes[index2];

			node1.Text = this.Model.ModelCarParts[index1].PartName;
			node2.Text = this.Model.ModelCarParts[index2].PartName;

			node1.Nodes.Clear();
			node2.Nodes.Clear();

			foreach (var attribute in this.Model.ModelCarParts[index1].Attributes)
			{

				node1.Nodes.Add(new TreeNode(attribute.ToString()));

			}

			foreach (var attribute in this.Model.ModelCarParts[index2].Attributes)
			{

				node2.Nodes.Add(new TreeNode(attribute.ToString()));

			}

			this.CarPartsTreeView.SelectedNode = this.CarPartsTreeView.Nodes[index2];
			this.CarPartsTreeView.EndUpdate();
		}

		private void MoveDownPartsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			var path = this.CarPartsTreeView.SelectedNode.FullPath;
			var index1 = this.CarPartsTreeView.SelectedNode.Index;
			var index2 = index1 + 1;

			if (index2 >= this.Model.CarPartsCount)
			{

				MessageBox.Show("Unable to move down because selected node is the down most node",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}

			// Switch parts
			this.CarPartsTreeView.BeginUpdate();

			var temp = this.Model.ModelCarParts[index1];
			this.Model.ModelCarParts[index1] = this.Model.ModelCarParts[index2];
			this.Model.ModelCarParts[index2] = temp;

			var node1 = this.CarPartsTreeView.Nodes[index1];
			var node2 = this.CarPartsTreeView.Nodes[index2];

			node1.Text = this.Model.ModelCarParts[index1].PartName;
			node2.Text = this.Model.ModelCarParts[index2].PartName;

			node1.Nodes.Clear();
			node2.Nodes.Clear();

			foreach (var attribute in this.Model.ModelCarParts[index1].Attributes)
			{

				node1.Nodes.Add(new TreeNode(attribute.ToString()));

			}

			foreach (var attribute in this.Model.ModelCarParts[index2].Attributes)
			{

				node2.Nodes.Add(new TreeNode(attribute.ToString()));

			}

			this.CarPartsTreeView.SelectedNode = this.CarPartsTreeView.Nodes[index2];
			this.CarPartsTreeView.EndUpdate();
		}

		private void MoveFirstPartsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			if (this.CarPartsTreeView.Nodes.Count == 0 || this.CarPartsTreeView.Nodes.Count == 1) return;

			var path = this.CarPartsTreeView.SelectedNode.FullPath;
			var index = this.CarPartsTreeView.SelectedNode.Index;
			var part = this.Model.ModelCarParts[index];

			// Remove part
			this.Model.RemovePart(index);
			this.CarPartsTreeView.Nodes.RemoveAt(index);

			// Add to the front
			this.Model.ModelCarParts.Insert(0, part);
			this.CarPartsTreeView.Nodes.Insert(0, part.PartName);

			foreach (var attribute in part.Attributes)
			{

				this.CarPartsTreeView.Nodes[0].Nodes.Add(attribute.ToString());

			}

			this.CarPartsTreeView.SelectedNode = this.CarPartsTreeView.Nodes[0];
		}

		private void MoveLastPartsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			if (this.CarPartsTreeView.Nodes.Count == 0 || this.CarPartsTreeView.Nodes.Count == 1) return;

			var path = this.CarPartsTreeView.SelectedNode.FullPath;
			var index = this.CarPartsTreeView.SelectedNode.Index;
			var part = this.Model.ModelCarParts[index];

			// Remove part
			this.Model.RemovePart(index);
			this.CarPartsTreeView.Nodes.RemoveAt(index);

			// Add to the back
			this.Model.ModelCarParts.Add(part);
			this.CarPartsTreeView.Nodes.Add(part.PartName);

			foreach (var attribute in part.Attributes)
			{

				this.CarPartsTreeView.Nodes[^1].Nodes.Add(attribute.ToString());

			}

			this.CarPartsTreeView.SelectedNode = this.CarPartsTreeView.Nodes[^1];
		}

		private void ReversePartsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Model.ReverseParts();
			this.LoadTreeView(this.CarPartsTreeView.SelectedNode.FullPath);
		}

		private void SortPartsByNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Model.SortByProperty(nameof(RealCarPart.PartName));
			this.LoadTreeView(this.CarPartsTreeView.SelectedNode.FullPath);
		}

		private void FindAndReplaceToolStripMenuItem_Click(object sende, EventArgs e)
		{
			if (this.CarPartsTreeView.Nodes.Count == 0) return;

			using var with = new Input("Enter string to replace with");
			using var input = new Input("Enter string to search for",
										new Predicate<string>(_ => !String.IsNullOrEmpty(_)),
										"Input string cannot be null or empty");

			if (input.ShowDialog() == DialogResult.OK && with.ShowDialog() == DialogResult.OK)
			{

				using var check = new Check("Make case-sensitive replace?", false);

				if (check.ShowDialog() == DialogResult.OK)
				{

					var options = check.Value
						? RegexOptions.Multiline | RegexOptions.CultureInvariant
						: RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase;

					this.CarPartsTreeView.BeginUpdate();

					for (int i = 0; i < this.Model.CarPartsCount; ++i)
					{

						// Very quick and dirty way to replace node's and part's name
						var part = this.Model.GetRealPart(i);
						var value = part.GetValue("PartLabel");
						value = Regex.Replace(value, input.Value, with.Value, options);
						part.SetValue("PartLabel", value);
						this.CarPartsTreeView.Nodes[i].Text = value;

					}

					this.CarPartsTreeView.EndUpdate();

				}

			}
		}

		private void AddAttributeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in a real car part node

			using var creator = new AttribCreator(this.Model.GameINT)
			{
				StartPosition = FormStartPosition.CenterScreen
			};

			if (creator.ShowDialog() == DialogResult.OK)
			{

				var node = this.CarPartsTreeView.SelectedNode;
				var realpart = this.Model.GetRealPart(node.Index);
				realpart.AddAttribute(creator.KeyChosen);
				var attribute = realpart.Attributes[^1];
				node.Nodes.Add(attribute.ToString());
				this.CarPartsPropertyGrid.Refresh();

			}
		}

		private void RemoveAttributeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in an attribute node

			var node = this.CarPartsTreeView.SelectedNode;
			var realpart = this.Model.GetRealPart(node.Parent.Index);
			realpart.Attributes.RemoveAt(node.Index);
			this.CarPartsTreeView.SelectedNode = node.Parent;
			node.Parent.Nodes.RemoveAt(node.Index);
		}

		private void MoveUpAttributesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in an attribute node

			var path = this.CarPartsTreeView.SelectedNode.FullPath;
			var index1 = this.CarPartsTreeView.SelectedNode.Index;
			var index2 = index1 - 1;
			var parent = this.CarPartsTreeView.SelectedNode.Parent.Index;
			var realpart = this.Model.GetRealPart(parent);

			if (index2 < 0)
			{

				MessageBox.Show("Unable to move up because selected node is the up most node",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}

			// Switch attributes
			var temp = realpart.Attributes[index1];
			realpart.Attributes[index1] = realpart.Attributes[index2];
			realpart.Attributes[index2] = temp;

			this.CarPartsTreeView.Nodes[parent].Nodes[index1].Text = realpart.Attributes[index1].ToString();
			this.CarPartsTreeView.Nodes[parent].Nodes[index2].Text = realpart.Attributes[index2].ToString();

			this.CarPartsTreeView.SelectedNode = this.CarPartsTreeView.Nodes[parent].Nodes[index2];
		}

		private void MoveDownAttributesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Assuming we are in an attribute node

			var path = this.CarPartsTreeView.SelectedNode.FullPath;
			var index1 = this.CarPartsTreeView.SelectedNode.Index;
			var index2 = index1 + 1;
			var parent = this.CarPartsTreeView.SelectedNode.Parent.Index;
			var realpart = this.Model.GetRealPart(parent);

			if (index2 >= realpart.Length)
			{

				MessageBox.Show("Unable to move up because selected node is the up most node",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}

			// Switch attributes
			var temp = realpart.Attributes[index1];
			realpart.Attributes[index1] = realpart.Attributes[index2];
			realpart.Attributes[index2] = temp;

			this.CarPartsTreeView.Nodes[parent].Nodes[index1].Text = realpart.Attributes[index1].ToString();
			this.CarPartsTreeView.Nodes[parent].Nodes[index2].Text = realpart.Attributes[index2].ToString();

			this.CarPartsTreeView.SelectedNode = this.CarPartsTreeView.Nodes[parent].Nodes[index2];
		}

		private void ReverseAttributesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Model.GetRealPart(this.CarPartsTreeView.SelectedNode.Index).Attributes.Reverse();
			this.LoadTreeView(this.CarPartsTreeView.SelectedNode.FullPath);
		}

		private void SortAttributesByKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var realpart = this.Model.GetRealPart(this.CarPartsTreeView.SelectedNode.Index);
			realpart.Attributes.Sort((x, y) => x.Key.CompareTo(y.Key));
			this.LoadTreeView(this.CarPartsTreeView.SelectedNode.FullPath);
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

		#region TreeView and Grid

		private void CarPartsTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (this.CarPartsTreeView.SelectedNode != null)
			{

				this.CarPartsTreeView.SelectedNode.ForeColor = this.CarPartsTreeView.ForeColor;

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

		private void CarPartsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(e.Node?.FullPath);
			var selected = this.GetSelectedObject(e.Node);
			this.ToggleMenuStripControls(e.Node);
			this.CarPartsPropertyGrid.SelectedObject = selected;
		}

		private void CarPartsPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			this.CarPartsTreeView.SelectedNode.Text = this.CarPartsPropertyGrid.SelectedObject.ToString();
			this.CarPartsPropertyGrid.Refresh();

			if (this.CarPartsTreeView.SelectedNode.Level == 1)
			{

				var index = this.CarPartsTreeView.SelectedNode.Parent.Index;
				this.CarPartsTreeView.SelectedNode.Parent.Text = this.Model.ModelCarParts[index].ToString();

			}
		}

		#endregion

		private void CarPartsEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (var form in this._openforms)
			{

				try { form.Close(); }
				catch { }

			}
		}
	}
}
