using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binary.Properties;
using Nikki.Support.Shared.Class;
using Nikki.Support.Shared.Parts.CarParts;



namespace Binary
{
	public partial class CarPartsEditor : Form
	{
		private DBModelPart Model { get; set; }

		public CarPartsEditor(DBModelPart model)
		{
			this.InitializeComponent();
			this.ToggleTheme();
			this.Model = model;
			this.Text = $"{this.Model.CollectionName} Editor";
			this.LoadTreeView();
			this.ToggleMenuStripControls(null);
		}

		private void ToggleTheme()
		{



		}

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
			var nodes = new TreeNode[this.Model.Length];
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
				this.SwitchPartsToolStripMenuItem.Enabled = false;
				this.ReversePartsToolStripMenuItem.Enabled = false;
				this.SortPartsByNameToolStripMenuItem.Enabled = false;
				this.AddAttributeToolStripMenuItem.Enabled = false;
				this.RemoveAttributeToolStripMenuItem.Enabled = false;
				this.SwitchAttributesToolStripMenuItem.Enabled = false;
				this.ReverseAttributesToolStripMenuItem.Enabled = false;
				this.SortAttributesByKeyToolStripMenuItem.Enabled = false;

			}
			else
			{

				this.AddPartToolStripMenuItem.Enabled = node.Level == 0;
				this.RemovePartToolStripMenuItem.Enabled = node.Level == 0;
				this.CopyPartToolStripMenuItem.Enabled = node.Level == 0;
				this.SwitchPartsToolStripMenuItem.Enabled = node.Level == 0;
				this.ReversePartsToolStripMenuItem.Enabled = node.Level == 0;
				this.SortPartsByNameToolStripMenuItem.Enabled = node.Level == 0;
				this.AddAttributeToolStripMenuItem.Enabled = node.Level == 0;
				this.RemoveAttributeToolStripMenuItem.Enabled = node.Level == 0;
				this.SwitchAttributesToolStripMenuItem.Enabled = node.Level == 0;
				this.ReverseAttributesToolStripMenuItem.Enabled = node.Level == 0;
				this.SortAttributesByKeyToolStripMenuItem.Enabled = node.Level == 0;

			}
		}

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

		private void SwitchPartsToolStripMenuItem_Click(object sender, EventArgs e)
		{

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

		private void AddAttributeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using var creator = new AttribCreator(this.Model.GameINT)
			{
				StartPosition = FormStartPosition.CenterScreen
			};

			if (creator.ShowDialog() == DialogResult.OK)
			{

				

			}
		}

		private void RemoveAttributeToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void SwitchAttributesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ReverseAttributesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void SortAttributesByKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void HasherToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void RaiderToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

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
		}
	}
}
