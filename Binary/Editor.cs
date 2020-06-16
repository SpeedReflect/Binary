using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Binary.Enums;
using Binary.Endscript;
using Binary.Properties;

using Nikki.Core;
using Nikki.Utils;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;
using CoreExtensions.Management;



namespace Binary
{
	public partial class Editor : Form
	{
		private readonly List<SyncDatabase> SyncDBs;

		public Editor()
		{
			this.SyncDBs = new List<SyncDatabase>();
			this.InitializeComponent();
			this.ToggleTheme();
		}

		private void ToggleTheme()
		{
			if (Configurations.Default.DarkTheme) this.ToggleDarkTheme();
			else this.ToggleLightTheme();
		}

		private void ToggleLightTheme()
		{
			this.BackColor = Theme.Light.MainBackColor;
			this.ForeColor = Theme.Light.MainForeColor;

		}

		private void ToggleDarkTheme()
		{
			this.BackColor = Theme.Dark.MainBackColor;
			this.ForeColor = Theme.Dark.MainForeColor;

		}

		private void LoadSynchronizedDatabases(string filename)
		{
			try
			{

				Parser.Deserialize(filename, out Launch launch);

				if (launch.UsageID != eUsage.Modder)
				{

					throw new Exception($"Usage type of the endscript is stated to be {launch.Usage}, while should be Modder");

				}

				if (launch.GameID == GameINT.None)
				{

					throw new Exception($"Invalid stated game type named {launch.Game}");

				}

				if (!Directory.Exists(launch.Directory))
				{

					throw new DirectoryNotFoundException($"Directory named {launch.Directory} does not exist");

				}

				launch.CheckFiles();
				launch.LoadLinks();

				foreach (var file in launch.Files)
				{

					var sdb = new SyncDatabase(launch.GameID, launch.Directory, file);
					sdb.Load();
					this.SyncDBs.Add(sdb);

				}

				this.LoadTreeView();

			}
			catch (Exception e)
			{

				MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void LoadTreeView()
		{
			this.EditorTreeView.Nodes.Clear();
			this.SyncDBs.Sort((x, y) => x.Filename.CompareTo(y.Filename));

			foreach (var db in this.SyncDBs)
			{

				this.EditorTreeView.Nodes.Add(db.GetTreeNodes());

			}

		}

		private void Editor_Load(object sender, EventArgs e)
		{

		}

		private void EMSMainNewLauncher_Click(object sender, EventArgs e)
		{

		}

		private void EMSMainLoadLauncher_Click(object sender, EventArgs e)
		{
			var browser = new OpenFileDialog()
			{
				CheckFileExists = true,
				Filter = "Endscript Files | *.end",
				Multiselect = false,
			};

			if (browser.ShowDialog() == DialogResult.OK)
			{

				this.LoadSynchronizedDatabases(browser.FileName);

			}
		}

		private void EditorTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(e.Node.FullPath);
			this.EditorPropertyGrid.SelectedObject = Utils.GetReflective(e.Node.FullPath,
				this.EditorTreeView.PathSeparator, this.SyncDBs);
		}

		private void EditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.ChangedItem.Label == "CollectionName")
			{

				this.EditorTreeView.SelectedNode.Text = e.ChangedItem.Value.ToString();
				this.EditorPropertyGrid.Refresh();

			}
		}
	}
}
