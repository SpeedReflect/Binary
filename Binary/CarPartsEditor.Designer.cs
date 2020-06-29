namespace Binary
{
	partial class CarPartsEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPartsEditor));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.CarPartsTreeView = new System.Windows.Forms.TreeView();
			this.CarPartsPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.CarPartsEditorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.CarPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemovePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveUpPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveDownPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReversePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SortPartsByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveUpAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveDownAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReverseAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SortAttributesByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HasherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RaiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.CarPartsEditorMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.CarPartsTreeView);
			this.splitContainer1.Panel1MinSize = 250;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.CarPartsPropertyGrid);
			this.splitContainer1.Panel2MinSize = 400;
			this.splitContainer1.Size = new System.Drawing.Size(918, 396);
			this.splitContainer1.SplitterDistance = 304;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// CarPartsTreeView
			// 
			this.CarPartsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CarPartsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CarPartsTreeView.Location = new System.Drawing.Point(14, 3);
			this.CarPartsTreeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CarPartsTreeView.Name = "CarPartsTreeView";
			this.CarPartsTreeView.PathSeparator = "|";
			this.CarPartsTreeView.Size = new System.Drawing.Size(286, 379);
			this.CarPartsTreeView.TabIndex = 0;
			this.CarPartsTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.CarPartsTreeView_BeforeSelect);
			this.CarPartsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CarPartsTreeView_AfterSelect);
			// 
			// CarPartsPropertyGrid
			// 
			this.CarPartsPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CarPartsPropertyGrid.Location = new System.Drawing.Point(4, 3);
			this.CarPartsPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CarPartsPropertyGrid.Name = "CarPartsPropertyGrid";
			this.CarPartsPropertyGrid.Size = new System.Drawing.Size(583, 379);
			this.CarPartsPropertyGrid.TabIndex = 0;
			this.CarPartsPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.CarPartsPropertyGrid_PropertyValueChanged);
			// 
			// CarPartsEditorMenuStrip
			// 
			this.CarPartsEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarPartsToolStripMenuItem,
            this.AttributesToolStripMenuItem,
            this.ToolsToolStripMenuItem});
			this.CarPartsEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.CarPartsEditorMenuStrip.Name = "CarPartsEditorMenuStrip";
			this.CarPartsEditorMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.CarPartsEditorMenuStrip.Size = new System.Drawing.Size(918, 24);
			this.CarPartsEditorMenuStrip.TabIndex = 1;
			this.CarPartsEditorMenuStrip.Text = "CarPartsEditorMenuStrip";
			// 
			// CarPartsToolStripMenuItem
			// 
			this.CarPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPartToolStripMenuItem,
            this.RemovePartToolStripMenuItem,
            this.CopyPartToolStripMenuItem,
            this.MoveUpPartsToolStripMenuItem,
            this.MoveDownPartsToolStripMenuItem,
            this.ReversePartsToolStripMenuItem,
            this.SortPartsByNameToolStripMenuItem});
			this.CarPartsToolStripMenuItem.Name = "CarPartsToolStripMenuItem";
			this.CarPartsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.CarPartsToolStripMenuItem.Text = "Car Parts";
			// 
			// AddPartToolStripMenuItem
			// 
			this.AddPartToolStripMenuItem.Name = "AddPartToolStripMenuItem";
			this.AddPartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.AddPartToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.AddPartToolStripMenuItem.Text = "Add Part";
			this.AddPartToolStripMenuItem.Click += new System.EventHandler(this.AddPartToolStripMenuItem_Click);
			// 
			// RemovePartToolStripMenuItem
			// 
			this.RemovePartToolStripMenuItem.Name = "RemovePartToolStripMenuItem";
			this.RemovePartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.RemovePartToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.RemovePartToolStripMenuItem.Text = "Remove Part";
			this.RemovePartToolStripMenuItem.Click += new System.EventHandler(this.RemovePartToolStripMenuItem_Click);
			// 
			// CopyPartToolStripMenuItem
			// 
			this.CopyPartToolStripMenuItem.Name = "CopyPartToolStripMenuItem";
			this.CopyPartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.CopyPartToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.CopyPartToolStripMenuItem.Text = "Copy Part";
			this.CopyPartToolStripMenuItem.Click += new System.EventHandler(this.CopyPartToolStripMenuItem_Click);
			// 
			// MoveUpPartsToolStripMenuItem
			// 
			this.MoveUpPartsToolStripMenuItem.Name = "MoveUpPartsToolStripMenuItem";
			this.MoveUpPartsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.MoveUpPartsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.MoveUpPartsToolStripMenuItem.Text = "Move Part Up";
			this.MoveUpPartsToolStripMenuItem.Click += new System.EventHandler(this.MoveUpPartsToolStripMenuItem_Click);
			// 
			// MoveDownPartsToolStripMenuItem
			// 
			this.MoveDownPartsToolStripMenuItem.Name = "MoveDownPartsToolStripMenuItem";
			this.MoveDownPartsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.MoveDownPartsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.MoveDownPartsToolStripMenuItem.Text = "Move Part Down";
			this.MoveDownPartsToolStripMenuItem.Click += new System.EventHandler(this.MoveDownPartsToolStripMenuItem_Click);
			// 
			// ReversePartsToolStripMenuItem
			// 
			this.ReversePartsToolStripMenuItem.Name = "ReversePartsToolStripMenuItem";
			this.ReversePartsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.ReversePartsToolStripMenuItem.Text = "Reverse Parts";
			this.ReversePartsToolStripMenuItem.Click += new System.EventHandler(this.ReversePartsToolStripMenuItem_Click);
			// 
			// SortPartsByNameToolStripMenuItem
			// 
			this.SortPartsByNameToolStripMenuItem.Name = "SortPartsByNameToolStripMenuItem";
			this.SortPartsByNameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.SortPartsByNameToolStripMenuItem.Text = "Sort Parts By Name";
			this.SortPartsByNameToolStripMenuItem.Click += new System.EventHandler(this.SortPartsByNameToolStripMenuItem_Click);
			// 
			// AttributesToolStripMenuItem
			// 
			this.AttributesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAttributeToolStripMenuItem,
            this.RemoveAttributeToolStripMenuItem,
            this.MoveUpAttributesToolStripMenuItem,
            this.MoveDownAttributesToolStripMenuItem,
            this.ReverseAttributesToolStripMenuItem,
            this.SortAttributesByKeyToolStripMenuItem});
			this.AttributesToolStripMenuItem.Name = "AttributesToolStripMenuItem";
			this.AttributesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.AttributesToolStripMenuItem.Text = "Attributes";
			// 
			// AddAttributeToolStripMenuItem
			// 
			this.AddAttributeToolStripMenuItem.Name = "AddAttributeToolStripMenuItem";
			this.AddAttributeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
			this.AddAttributeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.AddAttributeToolStripMenuItem.Text = "Add Attribute";
			this.AddAttributeToolStripMenuItem.Click += new System.EventHandler(this.AddAttributeToolStripMenuItem_Click);
			// 
			// RemoveAttributeToolStripMenuItem
			// 
			this.RemoveAttributeToolStripMenuItem.Name = "RemoveAttributeToolStripMenuItem";
			this.RemoveAttributeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.RemoveAttributeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.RemoveAttributeToolStripMenuItem.Text = "Remove Attribute";
			this.RemoveAttributeToolStripMenuItem.Click += new System.EventHandler(this.RemoveAttributeToolStripMenuItem_Click);
			// 
			// MoveUpAttributesToolStripMenuItem
			// 
			this.MoveUpAttributesToolStripMenuItem.Name = "MoveUpAttributesToolStripMenuItem";
			this.MoveUpAttributesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
			this.MoveUpAttributesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.MoveUpAttributesToolStripMenuItem.Text = "Move Attribute Up";
			this.MoveUpAttributesToolStripMenuItem.Click += new System.EventHandler(this.MoveUpAttributesToolStripMenuItem_Click);
			// 
			// MoveDownAttributesToolStripMenuItem
			// 
			this.MoveDownAttributesToolStripMenuItem.Name = "MoveDownAttributesToolStripMenuItem";
			this.MoveDownAttributesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.MoveDownAttributesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.MoveDownAttributesToolStripMenuItem.Text = "Move Attribute Down";
			this.MoveDownAttributesToolStripMenuItem.Click += new System.EventHandler(this.MoveDownAttributesToolStripMenuItem_Click);
			// 
			// ReverseAttributesToolStripMenuItem
			// 
			this.ReverseAttributesToolStripMenuItem.Name = "ReverseAttributesToolStripMenuItem";
			this.ReverseAttributesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.ReverseAttributesToolStripMenuItem.Text = "Reverse Attributes";
			this.ReverseAttributesToolStripMenuItem.Click += new System.EventHandler(this.ReverseAttributesToolStripMenuItem_Click);
			// 
			// SortAttributesByKeyToolStripMenuItem
			// 
			this.SortAttributesByKeyToolStripMenuItem.Name = "SortAttributesByKeyToolStripMenuItem";
			this.SortAttributesByKeyToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.SortAttributesByKeyToolStripMenuItem.Text = "Sort Attributes By Key";
			this.SortAttributesByKeyToolStripMenuItem.Click += new System.EventHandler(this.SortAttributesByKeyToolStripMenuItem_Click);
			// 
			// ToolsToolStripMenuItem
			// 
			this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HasherToolStripMenuItem,
            this.RaiderToolStripMenuItem});
			this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
			this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.ToolsToolStripMenuItem.Text = "Tools";
			// 
			// HasherToolStripMenuItem
			// 
			this.HasherToolStripMenuItem.Name = "HasherToolStripMenuItem";
			this.HasherToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.HasherToolStripMenuItem.Text = "Hasher";
			this.HasherToolStripMenuItem.Click += new System.EventHandler(this.HasherToolStripMenuItem_Click);
			// 
			// RaiderToolStripMenuItem
			// 
			this.RaiderToolStripMenuItem.Name = "RaiderToolStripMenuItem";
			this.RaiderToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.RaiderToolStripMenuItem.Text = "Raider";
			this.RaiderToolStripMenuItem.Click += new System.EventHandler(this.RaiderToolStripMenuItem_Click);
			// 
			// CarPartsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(918, 420);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.CarPartsEditorMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(931, 456);
			this.Name = "CarPartsEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Car Parts Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarPartsEditor_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.CarPartsEditorMenuStrip.ResumeLayout(false);
			this.CarPartsEditorMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView CarPartsTreeView;
		private System.Windows.Forms.PropertyGrid CarPartsPropertyGrid;
		private System.Windows.Forms.MenuStrip CarPartsEditorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem CarPartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddPartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemovePartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyPartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveUpPartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReversePartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SortPartsByNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddAttributeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveAttributeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveUpAttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReverseAttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SortAttributesByKeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HasherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RaiderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveDownPartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveDownAttributesToolStripMenuItem;
	}
}