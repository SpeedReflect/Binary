namespace Binary.UI
{
	partial class StringEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringEditor));
			this.StrEditorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.StringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReplaceStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FindPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FindNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HasherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RaiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxText = new System.Windows.Forms.TextBox();
			this.TextBoxLabel = new System.Windows.Forms.TextBox();
			this.TextBoxKey = new System.Windows.Forms.TextBox();
			this.StringEditorTextBox = new System.Windows.Forms.TextBox();
			this.StrEditorListView = new System.Windows.Forms.ListView();
			this.ColumnIndex = new System.Windows.Forms.ColumnHeader();
			this.ColumnKey = new System.Windows.Forms.ColumnHeader();
			this.ColumnLabel = new System.Windows.Forms.ColumnHeader();
			this.ColumnText = new System.Windows.Forms.ColumnHeader();
			this.StrEditorMenuStrip.SuspendLayout();
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
			// StrEditorMenuStrip
			// 
			this.StrEditorMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StrEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StringToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.ToolsToolStripMenuItem});
			this.StrEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.StrEditorMenuStrip.Name = "StrEditorMenuStrip";
			this.StrEditorMenuStrip.Size = new System.Drawing.Size(767, 24);
			this.StrEditorMenuStrip.TabIndex = 0;
			this.StrEditorMenuStrip.Text = "StrEditorMenuStrip";
			// 
			// StringToolStripMenuItem
			// 
			this.StringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStringToolStripMenuItem,
            this.RemoveStringToolStripMenuItem,
            this.EditStringToolStripMenuItem});
			this.StringToolStripMenuItem.Name = "StringToolStripMenuItem";
			this.StringToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.StringToolStripMenuItem.Text = "String";
			// 
			// AddStringToolStripMenuItem
			// 
			this.AddStringToolStripMenuItem.Name = "AddStringToolStripMenuItem";
			this.AddStringToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.AddStringToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.AddStringToolStripMenuItem.Text = "Add String";
			this.AddStringToolStripMenuItem.Click += new System.EventHandler(this.AddStringToolStripMenuItem_Click);
			// 
			// RemoveStringToolStripMenuItem
			// 
			this.RemoveStringToolStripMenuItem.Enabled = false;
			this.RemoveStringToolStripMenuItem.Name = "RemoveStringToolStripMenuItem";
			this.RemoveStringToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.RemoveStringToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.RemoveStringToolStripMenuItem.Text = "Remove String";
			this.RemoveStringToolStripMenuItem.Click += new System.EventHandler(this.RemoveStringToolStripMenuItem_Click);
			// 
			// EditStringToolStripMenuItem
			// 
			this.EditStringToolStripMenuItem.Enabled = false;
			this.EditStringToolStripMenuItem.Name = "EditStringToolStripMenuItem";
			this.EditStringToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.EditStringToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.EditStringToolStripMenuItem.Text = "Edit String";
			this.EditStringToolStripMenuItem.Click += new System.EventHandler(this.EditStringToolStripMenuItem_Click);
			// 
			// OptionsToolStripMenuItem
			// 
			this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReplaceStringToolStripMenuItem,
            this.FindPreviousToolStripMenuItem,
            this.FindNextToolStripMenuItem});
			this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
			this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.OptionsToolStripMenuItem.Text = "Options";
			// 
			// ReplaceStringToolStripMenuItem
			// 
			this.ReplaceStringToolStripMenuItem.Name = "ReplaceStringToolStripMenuItem";
			this.ReplaceStringToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.ReplaceStringToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.ReplaceStringToolStripMenuItem.Text = "Find and Replace";
			this.ReplaceStringToolStripMenuItem.Click += new System.EventHandler(this.ReplaceStringToolStripMenuItem_Click);
			// 
			// FindPreviousToolStripMenuItem
			// 
			this.FindPreviousToolStripMenuItem.Enabled = false;
			this.FindPreviousToolStripMenuItem.Name = "FindPreviousToolStripMenuItem";
			this.FindPreviousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.FindPreviousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.FindPreviousToolStripMenuItem.Text = "Find Previous";
			this.FindPreviousToolStripMenuItem.Click += new System.EventHandler(this.FindPreviousToolStripMenuItem_Click);
			// 
			// FindNextToolStripMenuItem
			// 
			this.FindNextToolStripMenuItem.Enabled = false;
			this.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem";
			this.FindNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.FindNextToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.FindNextToolStripMenuItem.Text = "Find Next";
			this.FindNextToolStripMenuItem.Click += new System.EventHandler(this.FindNextToolStripMenuItem_Click);
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
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel1MinSize = 95;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.StrEditorListView);
			this.splitContainer1.Size = new System.Drawing.Size(767, 346);
			this.splitContainer1.SplitterDistance = 95;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label3);
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this.TextBoxText);
			this.splitContainer2.Panel1.Controls.Add(this.TextBoxLabel);
			this.splitContainer2.Panel1.Controls.Add(this.TextBoxKey);
			this.splitContainer2.Panel1MinSize = 300;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.StringEditorTextBox);
			this.splitContainer2.Panel2MinSize = 300;
			this.splitContainer2.Size = new System.Drawing.Size(767, 95);
			this.splitContainer2.SplitterDistance = 341;
			this.splitContainer2.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Search by Text";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Search by Label";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search by Key";
			// 
			// TextBoxText
			// 
			this.TextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxText.Location = new System.Drawing.Point(103, 65);
			this.TextBoxText.Name = "TextBoxText";
			this.TextBoxText.Size = new System.Drawing.Size(227, 23);
			this.TextBoxText.TabIndex = 2;
			this.TextBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
			// 
			// TextBoxLabel
			// 
			this.TextBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxLabel.Location = new System.Drawing.Point(103, 36);
			this.TextBoxLabel.Name = "TextBoxLabel";
			this.TextBoxLabel.Size = new System.Drawing.Size(227, 23);
			this.TextBoxLabel.TabIndex = 1;
			this.TextBoxLabel.TextChanged += new System.EventHandler(this.TextBoxLabel_TextChanged);
			// 
			// TextBoxKey
			// 
			this.TextBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxKey.Location = new System.Drawing.Point(103, 7);
			this.TextBoxKey.Name = "TextBoxKey";
			this.TextBoxKey.Size = new System.Drawing.Size(227, 23);
			this.TextBoxKey.TabIndex = 0;
			this.TextBoxKey.TextChanged += new System.EventHandler(this.TextBoxKey_TextChanged);
			// 
			// StringEditorTextBox
			// 
			this.StringEditorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StringEditorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StringEditorTextBox.Enabled = false;
			this.StringEditorTextBox.Location = new System.Drawing.Point(14, 7);
			this.StringEditorTextBox.Multiline = true;
			this.StringEditorTextBox.Name = "StringEditorTextBox";
			this.StringEditorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.StringEditorTextBox.Size = new System.Drawing.Size(394, 81);
			this.StringEditorTextBox.TabIndex = 0;
			this.StringEditorTextBox.TextChanged += new System.EventHandler(this.StringEditorTextBox_TextChanged);
			this.StringEditorTextBox.Validated += new System.EventHandler(this.StringEditorTextBox_Validated);
			// 
			// StrEditorListView
			// 
			this.StrEditorListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StrEditorListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StrEditorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIndex,
            this.ColumnKey,
            this.ColumnLabel,
            this.ColumnText});
			this.StrEditorListView.FullRowSelect = true;
			this.StrEditorListView.HideSelection = false;
			this.StrEditorListView.Location = new System.Drawing.Point(3, 1);
			this.StrEditorListView.MultiSelect = false;
			this.StrEditorListView.Name = "StrEditorListView";
			this.StrEditorListView.OwnerDraw = true;
			this.StrEditorListView.Size = new System.Drawing.Size(761, 242);
			this.StrEditorListView.TabIndex = 0;
			this.StrEditorListView.UseCompatibleStateImageBehavior = false;
			this.StrEditorListView.View = System.Windows.Forms.View.Details;
			this.StrEditorListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.StrEditorListView_ColumnClick);
			this.StrEditorListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.StrEditorListView_DrawColumnHeader);
			this.StrEditorListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.StrEditorListView_DrawItem);
			this.StrEditorListView.SelectedIndexChanged += new System.EventHandler(this.StrEditorListView_SelectedIndexChanged);
			this.StrEditorListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StrEditorListView_MouseDoubleClick);
			// 
			// ColumnIndex
			// 
			this.ColumnIndex.Text = "Index";
			// 
			// ColumnKey
			// 
			this.ColumnKey.Text = "Key";
			this.ColumnKey.Width = 100;
			// 
			// ColumnLabel
			// 
			this.ColumnLabel.Text = "Label";
			this.ColumnLabel.Width = 200;
			// 
			// ColumnText
			// 
			this.ColumnText.Text = "Text";
			this.ColumnText.Width = 300;
			// 
			// StringEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(767, 370);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.StrEditorMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.StrEditorMenuStrip;
			this.MinimumSize = new System.Drawing.Size(699, 398);
			this.Name = "StringEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "String Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StringEditor_FormClosing);
			this.StrEditorMenuStrip.ResumeLayout(false);
			this.StrEditorMenuStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip StrEditorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem StringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddStringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveStringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReplaceStringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HasherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RaiderToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxText;
		private System.Windows.Forms.TextBox TextBoxLabel;
		private System.Windows.Forms.TextBox TextBoxKey;
		private System.Windows.Forms.TextBox StringEditorTextBox;
		private System.Windows.Forms.ListView StrEditorListView;
		private System.Windows.Forms.ColumnHeader ColumnIndex;
		private System.Windows.Forms.ColumnHeader ColumnKey;
		private System.Windows.Forms.ColumnHeader ColumnLabel;
		private System.Windows.Forms.ColumnHeader ColumnText;
		private System.Windows.Forms.ToolStripMenuItem FindPreviousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FindNextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditStringToolStripMenuItem;
	}
}