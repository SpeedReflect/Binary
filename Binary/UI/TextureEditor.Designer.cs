namespace Binary.UI
{
	partial class TextureEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureEditor));
			this.TexEditorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.TexEditorTexturesStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorAddTextureItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorRemoveTextureItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorCopyTextureItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorReplaceTextureItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorExportTextureItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorOptionsStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorExportAllItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorImportFromItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorToolsStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorHasherItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorRaiderItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.TexEditorListView = new System.Windows.Forms.ListView();
			this.ColumnIndex = new System.Windows.Forms.ColumnHeader();
			this.ColumnKey = new System.Windows.Forms.ColumnHeader();
			this.ColumnCollectionName = new System.Windows.Forms.ColumnHeader();
			this.ColumnCompression = new System.Windows.Forms.ColumnHeader();
			this.TexEditorPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TexEditorImage = new System.Windows.Forms.PictureBox();
			this.AddTextureDialog = new System.Windows.Forms.OpenFileDialog();
			this.ReplaceTextureDialog = new System.Windows.Forms.OpenFileDialog();
			this.ExportTextureDialog = new System.Windows.Forms.SaveFileDialog();
			this.TexEditorFindReplaceItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TexEditorMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TexEditorImage)).BeginInit();
			this.SuspendLayout();
			// 
			// TexEditorMenuStrip
			// 
			this.TexEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TexEditorTexturesStrip,
            this.TexEditorOptionsStrip,
            this.TexEditorToolsStrip});
			this.TexEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.TexEditorMenuStrip.Name = "TexEditorMenuStrip";
			this.TexEditorMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.TexEditorMenuStrip.Size = new System.Drawing.Size(1148, 24);
			this.TexEditorMenuStrip.TabIndex = 0;
			this.TexEditorMenuStrip.Text = "StrEditorMenuStrip";
			// 
			// TexEditorTexturesStrip
			// 
			this.TexEditorTexturesStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TexEditorAddTextureItem,
            this.TexEditorRemoveTextureItem,
            this.TexEditorCopyTextureItem,
            this.TexEditorReplaceTextureItem,
            this.TexEditorExportTextureItem});
			this.TexEditorTexturesStrip.Name = "TexEditorTexturesStrip";
			this.TexEditorTexturesStrip.Size = new System.Drawing.Size(62, 20);
			this.TexEditorTexturesStrip.Text = "Textures";
			// 
			// TexEditorAddTextureItem
			// 
			this.TexEditorAddTextureItem.Name = "TexEditorAddTextureItem";
			this.TexEditorAddTextureItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.TexEditorAddTextureItem.Size = new System.Drawing.Size(200, 22);
			this.TexEditorAddTextureItem.Text = "Add Texture";
			this.TexEditorAddTextureItem.Click += new System.EventHandler(this.TexEditorAddTextureItem_Click);
			// 
			// TexEditorRemoveTextureItem
			// 
			this.TexEditorRemoveTextureItem.Name = "TexEditorRemoveTextureItem";
			this.TexEditorRemoveTextureItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.TexEditorRemoveTextureItem.Size = new System.Drawing.Size(200, 22);
			this.TexEditorRemoveTextureItem.Text = "Remove Texture";
			this.TexEditorRemoveTextureItem.Click += new System.EventHandler(this.TexEditorRemoveTextureItem_Click);
			// 
			// TexEditorCopyTextureItem
			// 
			this.TexEditorCopyTextureItem.Name = "TexEditorCopyTextureItem";
			this.TexEditorCopyTextureItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.TexEditorCopyTextureItem.Size = new System.Drawing.Size(200, 22);
			this.TexEditorCopyTextureItem.Text = "Copy Texture";
			this.TexEditorCopyTextureItem.Click += new System.EventHandler(this.TexEditorCopyTextureItem_Click);
			// 
			// TexEditorReplaceTextureItem
			// 
			this.TexEditorReplaceTextureItem.Name = "TexEditorReplaceTextureItem";
			this.TexEditorReplaceTextureItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.TexEditorReplaceTextureItem.Size = new System.Drawing.Size(200, 22);
			this.TexEditorReplaceTextureItem.Text = "Replace Texture";
			this.TexEditorReplaceTextureItem.Click += new System.EventHandler(this.TexEditorReplaceTextureItem_Click);
			// 
			// TexEditorExportTextureItem
			// 
			this.TexEditorExportTextureItem.Name = "TexEditorExportTextureItem";
			this.TexEditorExportTextureItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.TexEditorExportTextureItem.Size = new System.Drawing.Size(200, 22);
			this.TexEditorExportTextureItem.Text = "Export Texture";
			this.TexEditorExportTextureItem.Click += new System.EventHandler(this.TexEditorExportTextureItem_Click);
			// 
			// TexEditorOptionsStrip
			// 
			this.TexEditorOptionsStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TexEditorExportAllItem,
            this.TexEditorImportFromItem,
            this.TexEditorFindReplaceItem});
			this.TexEditorOptionsStrip.Name = "TexEditorOptionsStrip";
			this.TexEditorOptionsStrip.Size = new System.Drawing.Size(61, 20);
			this.TexEditorOptionsStrip.Text = "Options";
			// 
			// TexEditorExportAllItem
			// 
			this.TexEditorExportAllItem.Name = "TexEditorExportAllItem";
			this.TexEditorExportAllItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
			this.TexEditorExportAllItem.Size = new System.Drawing.Size(246, 22);
			this.TexEditorExportAllItem.Text = "Export All";
			this.TexEditorExportAllItem.Click += new System.EventHandler(this.TexEditorExportAllItem_Click);
			// 
			// TexEditorImportFromItem
			// 
			this.TexEditorImportFromItem.Name = "TexEditorImportFromItem";
			this.TexEditorImportFromItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
			this.TexEditorImportFromItem.Size = new System.Drawing.Size(246, 22);
			this.TexEditorImportFromItem.Text = "Import From Folder";
			this.TexEditorImportFromItem.Click += new System.EventHandler(this.TexEditorImportFromItem_Click);
			// 
			// TexEditorFindReplaceItem
			// 
			this.TexEditorFindReplaceItem.Name = "TexEditorFindReplaceItem";
			this.TexEditorFindReplaceItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
			| System.Windows.Forms.Keys.R)));
			this.TexEditorFindReplaceItem.Size = new System.Drawing.Size(246, 22);
			this.TexEditorFindReplaceItem.Text = "Find And Replace";
			this.TexEditorFindReplaceItem.Click += new System.EventHandler(this.TexEditorFindReplaceItem_Click);
			// 
			// TexEditorToolsStrip
			// 
			this.TexEditorToolsStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TexEditorHasherItem,
            this.TexEditorRaiderItem});
			this.TexEditorToolsStrip.Name = "TexEditorToolsStrip";
			this.TexEditorToolsStrip.Size = new System.Drawing.Size(46, 20);
			this.TexEditorToolsStrip.Text = "Tools";
			// 
			// TexEditorHasherItem
			// 
			this.TexEditorHasherItem.Name = "TexEditorHasherItem";
			this.TexEditorHasherItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
			this.TexEditorHasherItem.Size = new System.Drawing.Size(150, 22);
			this.TexEditorHasherItem.Text = "Hasher";
			this.TexEditorHasherItem.Click += new System.EventHandler(this.TexEditorHasherItem_Click);
			// 
			// TexEditorRaiderItem
			// 
			this.TexEditorRaiderItem.Name = "TexEditorRaiderItem";
			this.TexEditorRaiderItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.TexEditorRaiderItem.Size = new System.Drawing.Size(150, 22);
			this.TexEditorRaiderItem.Text = "Raider";
			this.TexEditorRaiderItem.Click += new System.EventHandler(this.TexEditorRaiderItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel1MinSize = 300;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Panel2MinSize = 524;
			this.splitContainer1.Size = new System.Drawing.Size(1148, 603);
			this.splitContainer1.SplitterDistance = 532;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.TexEditorListView);
			this.splitContainer2.Panel1MinSize = 200;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.TexEditorPropertyGrid);
			this.splitContainer2.Panel2MinSize = 200;
			this.splitContainer2.Size = new System.Drawing.Size(532, 603);
			this.splitContainer2.SplitterDistance = 271;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 0;
			// 
			// TexEditorListView
			// 
			this.TexEditorListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TexEditorListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TexEditorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIndex,
            this.ColumnKey,
            this.ColumnCollectionName,
            this.ColumnCompression});
			this.TexEditorListView.FullRowSelect = true;
			this.TexEditorListView.HideSelection = false;
			this.TexEditorListView.Location = new System.Drawing.Point(12, 3);
			this.TexEditorListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TexEditorListView.MultiSelect = false;
			this.TexEditorListView.Name = "TexEditorListView";
			this.TexEditorListView.OwnerDraw = true;
			this.TexEditorListView.Size = new System.Drawing.Size(514, 261);
			this.TexEditorListView.TabIndex = 0;
			this.TexEditorListView.UseCompatibleStateImageBehavior = false;
			this.TexEditorListView.View = System.Windows.Forms.View.Details;
			this.TexEditorListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.TexEditorListView_ColumnClick);
			this.TexEditorListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.TexEditorListView_ColumnWidthChanging);
			this.TexEditorListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.TexEditorListView_DrawColumnHeader);
			this.TexEditorListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.TexEditorListView_DrawItem);
			this.TexEditorListView.SelectedIndexChanged += new System.EventHandler(this.TexEditorListView_SelectedIndexChanged);
			// 
			// ColumnIndex
			// 
			this.ColumnIndex.Text = "Index";
			// 
			// ColumnKey
			// 
			this.ColumnKey.Text = "BinKey";
			this.ColumnKey.Width = 100;
			// 
			// ColumnCollectionName
			// 
			this.ColumnCollectionName.Text = "CollectionName";
			this.ColumnCollectionName.Width = 260;
			// 
			// ColumnCompression
			// 
			this.ColumnCompression.Text = "Format";
			this.ColumnCompression.Width = 70;
			// 
			// TexEditorPropertyGrid
			// 
			this.TexEditorPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TexEditorPropertyGrid.HelpVisible = false;
			this.TexEditorPropertyGrid.Location = new System.Drawing.Point(14, 3);
			this.TexEditorPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TexEditorPropertyGrid.Name = "TexEditorPropertyGrid";
			this.TexEditorPropertyGrid.Size = new System.Drawing.Size(512, 288);
			this.TexEditorPropertyGrid.TabIndex = 0;
			this.TexEditorPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.TexEditorPropertyGrid_PropertyValueChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.TexEditorImage);
			this.panel1.Location = new System.Drawing.Point(6, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(566, 570);
			this.panel1.TabIndex = 1;
			// 
			// TexEditorImage
			// 
			this.TexEditorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TexEditorImage.Location = new System.Drawing.Point(0, 0);
			this.TexEditorImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TexEditorImage.Name = "TexEditorImage";
			this.TexEditorImage.Size = new System.Drawing.Size(560, 560);
			this.TexEditorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.TexEditorImage.TabIndex = 0;
			this.TexEditorImage.TabStop = false;
			// 
			// AddTextureDialog
			// 
			this.AddTextureDialog.Filter = "Direct Draw Surface Files|*.dds";
			this.AddTextureDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.AddTextureDialog_FileOk);
			// 
			// ReplaceTextureDialog
			// 
			this.ReplaceTextureDialog.Filter = "Direct Draw Surface Files|*.dds";
			this.ReplaceTextureDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ReplaceTextureDialog_FileOk);
			// 
			// TextureEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1148, 627);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.TexEditorMenuStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.TexEditorMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(1164, 666);
			this.Name = "TextureEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Texture Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextureEditor_FormClosing);
			this.TexEditorMenuStrip.ResumeLayout(false);
			this.TexEditorMenuStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TexEditorImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip TexEditorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem TexEditorTexturesStrip;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ListView TexEditorListView;
		private System.Windows.Forms.PropertyGrid TexEditorPropertyGrid;
		private System.Windows.Forms.PictureBox TexEditorImage;
		private System.Windows.Forms.ToolStripMenuItem TexEditorAddTextureItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorRemoveTextureItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorCopyTextureItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorReplaceTextureItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorExportTextureItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorOptionsStrip;
		private System.Windows.Forms.ToolStripMenuItem TexEditorExportAllItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorImportFromItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorFindReplaceItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorToolsStrip;
		private System.Windows.Forms.ToolStripMenuItem TexEditorHasherItem;
		private System.Windows.Forms.ToolStripMenuItem TexEditorRaiderItem;
		private System.Windows.Forms.ColumnHeader ColumnIndex;
		private System.Windows.Forms.ColumnHeader ColumnKey;
		private System.Windows.Forms.ColumnHeader ColumnCollectionName;
		private System.Windows.Forms.ColumnHeader ColumnCompression;
		private System.Windows.Forms.OpenFileDialog AddTextureDialog;
		private System.Windows.Forms.OpenFileDialog ReplaceTextureDialog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SaveFileDialog ExportTextureDialog;
	}
}