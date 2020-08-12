namespace Binary.UI
{
	partial class VectorEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorEditor));
			this.VectorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExportSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddPathSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemovePathSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveUpPathSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveDownPathSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.VectorTreeView = new System.Windows.Forms.TreeView();
			this.VectorPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.VectorMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// VectorMenuStrip
			// 
			this.VectorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem,
            this.PathsToolStripMenuItem});
			this.VectorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.VectorMenuStrip.Name = "VectorMenuStrip";
			this.VectorMenuStrip.Size = new System.Drawing.Size(743, 24);
			this.VectorMenuStrip.TabIndex = 0;
			this.VectorMenuStrip.Text = "VectorMenuStrip";
			// 
			// MainToolStripMenuItem
			// 
			this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportSVGToolStripMenuItem,
            this.ExportSVGToolStripMenuItem,
            this.PreviewToolStripMenuItem});
			this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
			this.MainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.MainToolStripMenuItem.Text = "Main";
			// 
			// ImportSVGToolStripMenuItem
			// 
			this.ImportSVGToolStripMenuItem.Name = "ImportSVGToolStripMenuItem";
			this.ImportSVGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.ImportSVGToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.ImportSVGToolStripMenuItem.Text = "Import SVG";
			this.ImportSVGToolStripMenuItem.Click += new System.EventHandler(this.ImportSVGToolStripMenuItem_Click);
			// 
			// ExportSVGToolStripMenuItem
			// 
			this.ExportSVGToolStripMenuItem.Name = "ExportSVGToolStripMenuItem";
			this.ExportSVGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.ExportSVGToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.ExportSVGToolStripMenuItem.Text = "Export SVG";
			this.ExportSVGToolStripMenuItem.Click += new System.EventHandler(this.ExportSVGToolStripMenuItem_Click);
			// 
			// PreviewToolStripMenuItem
			// 
			this.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem";
			this.PreviewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.PreviewToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.PreviewToolStripMenuItem.Text = "Preview";
			this.PreviewToolStripMenuItem.Click += new System.EventHandler(this.PreviewToolStripMenuItem_Click);
			// 
			// PathsToolStripMenuItem
			// 
			this.PathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPathSetToolStripMenuItem,
            this.RemovePathSetToolStripMenuItem,
            this.MoveUpPathSetToolStripMenuItem,
            this.MoveDownPathSetToolStripMenuItem});
			this.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem";
			this.PathsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.PathsToolStripMenuItem.Text = "Paths";
			// 
			// AddPathSetToolStripMenuItem
			// 
			this.AddPathSetToolStripMenuItem.Name = "AddPathSetToolStripMenuItem";
			this.AddPathSetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.AddPathSetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.AddPathSetToolStripMenuItem.Text = "Add PathSet";
			this.AddPathSetToolStripMenuItem.Click += new System.EventHandler(this.AddPathSetToolStripMenuItem_Click);
			// 
			// RemovePathSetToolStripMenuItem
			// 
			this.RemovePathSetToolStripMenuItem.Name = "RemovePathSetToolStripMenuItem";
			this.RemovePathSetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.RemovePathSetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.RemovePathSetToolStripMenuItem.Text = "Remove PathSet";
			this.RemovePathSetToolStripMenuItem.Click += new System.EventHandler(this.RemovePathSetToolStripMenuItem_Click);
			// 
			// MoveUpPathSetToolStripMenuItem
			// 
			this.MoveUpPathSetToolStripMenuItem.Name = "MoveUpPathSetToolStripMenuItem";
			this.MoveUpPathSetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.MoveUpPathSetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.MoveUpPathSetToolStripMenuItem.Text = "Move PathSet Up";
			this.MoveUpPathSetToolStripMenuItem.Click += new System.EventHandler(this.MoveUpPathSetToolStripMenuItem_Click);
			// 
			// MoveDownPathSetToolStripMenuItem
			// 
			this.MoveDownPathSetToolStripMenuItem.Name = "MoveDownPathSetToolStripMenuItem";
			this.MoveDownPathSetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.MoveDownPathSetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.MoveDownPathSetToolStripMenuItem.Text = "Move PathSet Down";
			this.MoveDownPathSetToolStripMenuItem.Click += new System.EventHandler(this.MoveDownPathSetToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.VectorTreeView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.VectorPropertyGrid);
			this.splitContainer1.Size = new System.Drawing.Size(743, 325);
			this.splitContainer1.SplitterDistance = 282;
			this.splitContainer1.TabIndex = 1;
			// 
			// VectorTreeView
			// 
			this.VectorTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VectorTreeView.Location = new System.Drawing.Point(12, 3);
			this.VectorTreeView.Name = "VectorTreeView";
			this.VectorTreeView.PathSeparator = "|";
			this.VectorTreeView.Size = new System.Drawing.Size(267, 310);
			this.VectorTreeView.TabIndex = 0;
			this.VectorTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.VectorTreeView_BeforeSelect);
			this.VectorTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.VectorTreeView_AfterSelect);
			// 
			// VectorPropertyGrid
			// 
			this.VectorPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VectorPropertyGrid.Location = new System.Drawing.Point(3, 3);
			this.VectorPropertyGrid.Name = "VectorPropertyGrid";
			this.VectorPropertyGrid.Size = new System.Drawing.Size(442, 310);
			this.VectorPropertyGrid.TabIndex = 0;
			// 
			// VectorEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(743, 349);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.VectorMenuStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.VectorMenuStrip;
			this.Name = "VectorEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vector Editor";
			this.VectorMenuStrip.ResumeLayout(false);
			this.VectorMenuStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip VectorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ImportSVGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExportSVGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PathsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddPathSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemovePathSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveUpPathSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveDownPathSetToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView VectorTreeView;
		private System.Windows.Forms.PropertyGrid VectorPropertyGrid;
	}
}