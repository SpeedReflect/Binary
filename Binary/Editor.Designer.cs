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
			this.EMSMainNewLauncher = new System.Windows.Forms.ToolStripMenuItem();
			this.EMSMainLoadLauncher = new System.Windows.Forms.ToolStripMenuItem();
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
			this.EditorTreeView.PathSeparator = "|";
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
            this.EMSMainNewLauncher,
            this.EMSMainLoadLauncher});
			this.EditorMenuStripMain.Name = "EditorMenuStripMain";
			this.EditorMenuStripMain.Size = new System.Drawing.Size(46, 20);
			this.EditorMenuStripMain.Text = "Main";
			// 
			// EMSMainNewLauncher
			// 
			this.EMSMainNewLauncher.Name = "EMSMainNewLauncher";
			this.EMSMainNewLauncher.Size = new System.Drawing.Size(152, 22);
			this.EMSMainNewLauncher.Text = "New Launcher";
			this.EMSMainNewLauncher.Click += new System.EventHandler(this.EMSMainNewLauncher_Click);
			// 
			// EMSMainLoadLauncher
			// 
			this.EMSMainLoadLauncher.Name = "EMSMainLoadLauncher";
			this.EMSMainLoadLauncher.Size = new System.Drawing.Size(152, 22);
			this.EMSMainLoadLauncher.Text = "Load Launcher";
			this.EMSMainLoadLauncher.Click += new System.EventHandler(this.EMSMainLoadLauncher_Click);
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
		private System.Windows.Forms.ToolStripMenuItem EMSMainLoadLauncher;
		private System.Windows.Forms.ToolStripMenuItem EMSMainNewLauncher;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripEditors;
		private System.Windows.Forms.ToolStripMenuItem EditorMenuStripOptions;
	}
}

