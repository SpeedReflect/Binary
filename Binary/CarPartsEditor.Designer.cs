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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.CarPartsTreeView = new System.Windows.Forms.TreeView();
			this.CarPartsPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.CarPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemovePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SwitchPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReversePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SortPartsByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SwitchAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReverseAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SortAttributesByKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HasherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RaiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
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
			this.CarPartsPropertyGrid.Size = new System.Drawing.Size(590, 379);
			this.CarPartsPropertyGrid.TabIndex = 0;
			this.CarPartsPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.CarPartsPropertyGrid_PropertyValueChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarPartsToolStripMenuItem,
            this.AttributesToolStripMenuItem,
            this.ToolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(918, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// CarPartsToolStripMenuItem
			// 
			this.CarPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPartToolStripMenuItem,
            this.RemovePartToolStripMenuItem,
            this.CopyPartToolStripMenuItem,
            this.SwitchPartsToolStripMenuItem,
            this.ReversePartsToolStripMenuItem,
            this.SortPartsByNameToolStripMenuItem});
			this.CarPartsToolStripMenuItem.Name = "CarPartsToolStripMenuItem";
			this.CarPartsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.CarPartsToolStripMenuItem.Text = "Car Parts";
			// 
			// AddPartToolStripMenuItem
			// 
			this.AddPartToolStripMenuItem.Name = "AddPartToolStripMenuItem";
			this.AddPartToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.AddPartToolStripMenuItem.Text = "Add Part";
			this.AddPartToolStripMenuItem.Click += new System.EventHandler(this.AddPartToolStripMenuItem_Click);
			// 
			// RemovePartToolStripMenuItem
			// 
			this.RemovePartToolStripMenuItem.Name = "RemovePartToolStripMenuItem";
			this.RemovePartToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.RemovePartToolStripMenuItem.Text = "Remove Part";
			this.RemovePartToolStripMenuItem.Click += new System.EventHandler(this.RemovePartToolStripMenuItem_Click);
			// 
			// CopyPartToolStripMenuItem
			// 
			this.CopyPartToolStripMenuItem.Name = "CopyPartToolStripMenuItem";
			this.CopyPartToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.CopyPartToolStripMenuItem.Text = "Copy Part";
			this.CopyPartToolStripMenuItem.Click += new System.EventHandler(this.CopyPartToolStripMenuItem_Click);
			// 
			// SwitchPartsToolStripMenuItem
			// 
			this.SwitchPartsToolStripMenuItem.Name = "SwitchPartsToolStripMenuItem";
			this.SwitchPartsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.SwitchPartsToolStripMenuItem.Text = "Switch Parts";
			this.SwitchPartsToolStripMenuItem.Click += new System.EventHandler(this.SwitchPartsToolStripMenuItem_Click);
			// 
			// ReversePartsToolStripMenuItem
			// 
			this.ReversePartsToolStripMenuItem.Name = "ReversePartsToolStripMenuItem";
			this.ReversePartsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.ReversePartsToolStripMenuItem.Text = "Reverse Parts";
			this.ReversePartsToolStripMenuItem.Click += new System.EventHandler(this.ReversePartsToolStripMenuItem_Click);
			// 
			// SortPartsByNameToolStripMenuItem
			// 
			this.SortPartsByNameToolStripMenuItem.Name = "SortPartsByNameToolStripMenuItem";
			this.SortPartsByNameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.SortPartsByNameToolStripMenuItem.Text = "Sort Parts By Name";
			this.SortPartsByNameToolStripMenuItem.Click += new System.EventHandler(this.SortPartsByNameToolStripMenuItem_Click);
			// 
			// AttributesToolStripMenuItem
			// 
			this.AttributesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAttributeToolStripMenuItem,
            this.RemoveAttributeToolStripMenuItem,
            this.SwitchAttributesToolStripMenuItem,
            this.ReverseAttributesToolStripMenuItem,
            this.SortAttributesByKeyToolStripMenuItem});
			this.AttributesToolStripMenuItem.Name = "AttributesToolStripMenuItem";
			this.AttributesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.AttributesToolStripMenuItem.Text = "Attributes";
			// 
			// AddAttributeToolStripMenuItem
			// 
			this.AddAttributeToolStripMenuItem.Name = "AddAttributeToolStripMenuItem";
			this.AddAttributeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.AddAttributeToolStripMenuItem.Text = "Add Attribute";
			this.AddAttributeToolStripMenuItem.Click += new System.EventHandler(this.AddAttributeToolStripMenuItem_Click);
			// 
			// RemoveAttributeToolStripMenuItem
			// 
			this.RemoveAttributeToolStripMenuItem.Name = "RemoveAttributeToolStripMenuItem";
			this.RemoveAttributeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.RemoveAttributeToolStripMenuItem.Text = "Remove Attribute";
			this.RemoveAttributeToolStripMenuItem.Click += new System.EventHandler(this.RemoveAttributeToolStripMenuItem_Click);
			// 
			// SwitchAttributesToolStripMenuItem
			// 
			this.SwitchAttributesToolStripMenuItem.Name = "SwitchAttributesToolStripMenuItem";
			this.SwitchAttributesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.SwitchAttributesToolStripMenuItem.Text = "Switch Attributes";
			this.SwitchAttributesToolStripMenuItem.Click += new System.EventHandler(this.SwitchAttributesToolStripMenuItem_Click);
			// 
			// ReverseAttributesToolStripMenuItem
			// 
			this.ReverseAttributesToolStripMenuItem.Name = "ReverseAttributesToolStripMenuItem";
			this.ReverseAttributesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.ReverseAttributesToolStripMenuItem.Text = "Reverse Attributes";
			this.ReverseAttributesToolStripMenuItem.Click += new System.EventHandler(this.ReverseAttributesToolStripMenuItem_Click);
			// 
			// SortAttributesByKeyToolStripMenuItem
			// 
			this.SortAttributesByKeyToolStripMenuItem.Name = "SortAttributesByKeyToolStripMenuItem";
			this.SortAttributesByKeyToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 420);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(931, 456);
			this.Name = "CarPartsEditor";
			this.Text = "Car Parts Editor";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView CarPartsTreeView;
		private System.Windows.Forms.PropertyGrid CarPartsPropertyGrid;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem CarPartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddPartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemovePartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyPartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SwitchPartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReversePartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SortPartsByNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddAttributeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveAttributeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SwitchAttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReverseAttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SortAttributesByKeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HasherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RaiderToolStripMenuItem;
	}
}