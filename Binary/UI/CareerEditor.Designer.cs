namespace Binary.UI
{
	partial class CareerEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CareerEditor));
			this.CareerEditorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ScriptCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HasherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RaiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.CareerSearchBar = new System.Windows.Forms.TextBox();
			this.CareerTreeView = new System.Windows.Forms.TreeView();
			this.CareerPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.CareerEditorMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// CareerEditorMenuStrip
			// 
			this.CareerEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem,
            this.ToolsToolStripMenuItem});
			this.CareerEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.CareerEditorMenuStrip.Name = "CareerEditorMenuStrip";
			this.CareerEditorMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.CareerEditorMenuStrip.Size = new System.Drawing.Size(912, 24);
			this.CareerEditorMenuStrip.TabIndex = 0;
			this.CareerEditorMenuStrip.Text = "VectorMenuStrip";
			// 
			// MainToolStripMenuItem
			// 
			this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCollectionToolStripMenuItem,
            this.RemoveCollectionToolStripMenuItem,
            this.CopyCollectionToolStripMenuItem,
            this.ScriptCollectionToolStripMenuItem});
			this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
			this.MainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.MainToolStripMenuItem.Text = "Main";
			// 
			// AddCollectionToolStripMenuItem
			// 
			this.AddCollectionToolStripMenuItem.Name = "AddCollectionToolStripMenuItem";
			this.AddCollectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.AddCollectionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.AddCollectionToolStripMenuItem.Text = "Add Collection";
			this.AddCollectionToolStripMenuItem.Click += new System.EventHandler(this.AddCollectionToolStripMenuItem_Click);
			// 
			// RemoveCollectionToolStripMenuItem
			// 
			this.RemoveCollectionToolStripMenuItem.Name = "RemoveCollectionToolStripMenuItem";
			this.RemoveCollectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.RemoveCollectionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.RemoveCollectionToolStripMenuItem.Text = "Remove Collection";
			this.RemoveCollectionToolStripMenuItem.Click += new System.EventHandler(this.RemoveCollectionToolStripMenuItem_Click);
			// 
			// CopyCollectionToolStripMenuItem
			// 
			this.CopyCollectionToolStripMenuItem.Name = "CopyCollectionToolStripMenuItem";
			this.CopyCollectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.CopyCollectionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.CopyCollectionToolStripMenuItem.Text = "Copy Collection";
			this.CopyCollectionToolStripMenuItem.Click += new System.EventHandler(this.CopyCollectionToolStripMenuItem_Click);
			// 
			// ScriptCollectionToolStripMenuItem
			// 
			this.ScriptCollectionToolStripMenuItem.Name = "ScriptCollectionToolStripMenuItem";
			this.ScriptCollectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.ScriptCollectionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.ScriptCollectionToolStripMenuItem.Text = "Script Collection";
			this.ScriptCollectionToolStripMenuItem.Click += new System.EventHandler(this.ScriptCollectionToolStripMenuItem_Click);
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
			this.HasherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
			this.HasherToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.HasherToolStripMenuItem.Text = "Hasher";
			this.HasherToolStripMenuItem.Click += new System.EventHandler(this.HasherToolStripMenuItem_Click);
			// 
			// RaiderToolStripMenuItem
			// 
			this.RaiderToolStripMenuItem.Name = "RaiderToolStripMenuItem";
			this.RaiderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.RaiderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.RaiderToolStripMenuItem.Text = "Raider";
			this.RaiderToolStripMenuItem.Click += new System.EventHandler(this.RaiderToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel1MinSize = 200;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.CareerPropertyGrid);
			this.splitContainer1.Panel2MinSize = 350;
			this.splitContainer1.Size = new System.Drawing.Size(912, 398);
			this.splitContainer1.SplitterDistance = 367;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.CareerSearchBar);
			this.splitContainer2.Panel1MinSize = 32;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.CareerTreeView);
			this.splitContainer2.Size = new System.Drawing.Size(367, 398);
			this.splitContainer2.SplitterDistance = 37;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 0;
			// 
			// CareerSearchBar
			// 
			this.CareerSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CareerSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CareerSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CareerSearchBar.Location = new System.Drawing.Point(14, 3);
			this.CareerSearchBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CareerSearchBar.Name = "CareerSearchBar";
			this.CareerSearchBar.Size = new System.Drawing.Size(349, 22);
			this.CareerSearchBar.TabIndex = 0;
			this.CareerSearchBar.TextChanged += new System.EventHandler(this.CareerSearchBar_TextChanged);
			// 
			// CareerTreeView
			// 
			this.CareerTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CareerTreeView.Location = new System.Drawing.Point(14, 3);
			this.CareerTreeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CareerTreeView.Name = "CareerTreeView";
			this.CareerTreeView.PathSeparator = "|";
			this.CareerTreeView.Size = new System.Drawing.Size(348, 334);
			this.CareerTreeView.TabIndex = 0;
			this.CareerTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.CareerTreeView_BeforeSelect);
			this.CareerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CareerTreeView_AfterSelect);
			// 
			// CareerPropertyGrid
			// 
			this.CareerPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CareerPropertyGrid.Location = new System.Drawing.Point(4, 3);
			this.CareerPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CareerPropertyGrid.Name = "CareerPropertyGrid";
			this.CareerPropertyGrid.Size = new System.Drawing.Size(519, 380);
			this.CareerPropertyGrid.TabIndex = 0;
			this.CareerPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.CareerPropertyGrid_PropertyValueChanged);
			// 
			// CareerEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(912, 422);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.CareerEditorMenuStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.CareerEditorMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "CareerEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Career Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CareerEditor_FormClosing);
			this.CareerEditorMenuStrip.ResumeLayout(false);
			this.CareerEditorMenuStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip CareerEditorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddCollectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveCollectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyCollectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ScriptCollectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox CareerSearchBar;
		private System.Windows.Forms.TreeView CareerTreeView;
		private System.Windows.Forms.PropertyGrid CareerPropertyGrid;
		private System.Windows.Forms.ToolStripMenuItem HasherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RaiderToolStripMenuItem;
	}
}