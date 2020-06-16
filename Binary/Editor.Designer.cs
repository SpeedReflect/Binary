namespace Binary
{
	partial class Editor
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.EditorPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.EditorTreeView = new System.Windows.Forms.TreeView();
			this.EditorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.EditorMenuStripMain = new System.Windows.Forms.ToolStripMenuItem();
			this.EditorMenuStripMainLoadFile = new System.Windows.Forms.ToolStripMenuItem();
			this.EditorMenuStripMainLoadEnd = new System.Windows.Forms.ToolStripMenuItem();
			this.EditorMenuStripEditors = new System.Windows.Forms.ToolStripMenuItem();
			this.EditorMenuStripOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.EditorMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// EditorPropertyGrid
			// 
			this.EditorPropertyGrid.HelpVisible = false;
			this.EditorPropertyGrid.Location = new System.Drawing.Point(343, 65);
			this.EditorPropertyGrid.Name = "EditorPropertyGrid";
			this.EditorPropertyGrid.Size = new System.Drawing.Size(573, 373);
			this.EditorPropertyGrid.TabIndex = 0;
			this.EditorPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.EditorPropertyGrid_PropertyValueChanged);
			// 
			// EditorTreeView
			// 
			this.EditorTreeView.Location = new System.Drawing.Point(14, 65);
			this.EditorTreeView.Name = "EditorTreeView";
			this.EditorTreeView.Size = new System.Drawing.Size(310, 373);
			this.EditorTreeView.TabIndex = 1;
			this.EditorTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EditorTreeView_AfterSelect);
			// 
			// EditorMenuStrip
			// 
			this.EditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorMenuStripMain,
            this.EditorMenuStripEditors,
            this.EditorMenuStripOptions});
			this.EditorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.EditorMenuStrip.Name = "EditorMenuStrip";
			this.EditorMenuStrip.Size = new System.Drawing.Size(928, 24);
			this.EditorMenuStrip.TabIndex = 2;
			this.EditorMenuStrip.Text = "EditorMenuStrip";
			// 
			// EditorMenuStripMain
			// 
			this.EditorMenuStripMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorMenuStripMainLoadFile,
            this.EditorMenuStripMainLoadEnd});
			this.EditorMenuStripMain.Name = "EditorMenuStripMain";
			this.EditorMenuStripMain.Size = new System.Drawing.Size(46, 20);
			this.EditorMenuStripMain.Text = "Main";
			// 
			// EditorMenuStripMainLoadFile
			// 
			this.EditorMenuStripMainLoadFile.Name = "EditorMenuStripMainLoadFile";
			this.EditorMenuStripMainLoadFile.Size = new System.Drawing.Size(144, 22);
			this.EditorMenuStripMainLoadFile.Text = "Open File";
			this.EditorMenuStripMainLoadFile.Click += new System.EventHandler(this.EditorMenuStripMainLoadFile_Click);
			// 
			// EditorMenuStripMainLoadEnd
			// 
			this.EditorMenuStripMainLoadEnd.Name = "EditorMenuStripMainLoadEnd";
			this.EditorMenuStripMainLoadEnd.Size = new System.Drawing.Size(144, 22);
			this.EditorMenuStripMainLoadEnd.Text = "Open EndFile";
			// 
			// EditorMenuStripEditors
			// 
			this.EditorMenuStripEditors.Name = "EditorMenuStripEditors";
			this.EditorMenuStripEditors.Size = new System.Drawing.Size(55, 20);
			this.EditorMenuStripEditors.Text = "Editors";
			// 
			// EditorMenuStripOptions
			// 
			this.EditorMenuStripOptions.Name = "EditorMenuStripOptions";
			this.EditorMenuStripOptions.Size = new System.Drawing.Size(61, 20);
			this.EditorMenuStripOptions.Text = "Options";
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 450);
			this.Controls.Add(this.EditorTreeView);
			this.Controls.Add(this.EditorPropertyGrid);
			this.Controls.Add(this.EditorMenuStrip);
			this.Name = "Editor";
			this.Text = "Binary by MaxHwoy";
			this.Load += new System.EventHandler(this.Editor_Load);
			this.EditorMenuStrip.ResumeLayout(false);
			this.EditorMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PropertyGrid EditorPropertyGrid;
		private System.Windows.Forms.TreeView EditorTreeView;
		private System.Windows.Forms.MenuStrip EditorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripMain;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripMainLoadFile;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripMainLoadEnd;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripEditors;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripOptions;
	}
}

