using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Binary.Tools;
using Binary.Prompt;
using Binary.Properties;
using Nikki.Utils;
using Nikki.Utils.EA;
using Nikki.Reflection.Enum;
using Nikki.Support.Shared.Class;
using ILWrapper.Enums;
using Endscript.Enums;
using CoreExtensions.Management;



namespace Binary.UI
{
	public partial class TextureEditor : Form
	{
		private TPKBlock TPK { get; }
		private readonly List<Form> _openforms;
		private readonly string _tpkpath;
		public List<string> Commands { get; }

		public TextureEditor(TPKBlock tpk, string path)
		{
			this.InitializeComponent();
			this.TPK = tpk;
			this._tpkpath = path;
			this._openforms = new List<Form>();
			this.Commands = new List<string>();
			this.Text = $"{this.TPK.CollectionName} Editor";
			this.TexEditorImage.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.TexEditorImage.BorderStyle = BorderStyle.FixedSingle;
			this.TexEditorImage.Width = this.panel1.Width;
			this.TexEditorImage.Height = this.panel1.Height;
			this.TexEditorListView.Columns[^1].Width = -2;
			this.ToggleTheme();
			this.LoadListView();
			this.ToggleMenuStripControls();
			
		}

		#region Theme

		private void ToggleTheme()
		{
			// Renderers
			this.TexEditorMenuStrip.Renderer = new Theme.MenuStripRenderer();

			// Primary colors and controls
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;

			// Image
			this.panel1.BackgroundImage = Configurations.Default.DarkTheme
				? Resources.DarkTransparent : Resources.LightTransparent;

			// List view
			this.TexEditorListView.BackColor = Theme.PrimBackColor;
			this.TexEditorListView.ForeColor = Theme.PrimForeColor;

			// Property grid
			this.TexEditorPropertyGrid.BackColor = Theme.PrimBackColor;
			this.TexEditorPropertyGrid.CategorySplitterColor = Theme.ButtonBackColor;
			this.TexEditorPropertyGrid.CategoryForeColor = Theme.TextBoxForeColor;
			this.TexEditorPropertyGrid.CommandsBackColor = Theme.PrimBackColor;
			this.TexEditorPropertyGrid.CommandsForeColor = Theme.PrimForeColor;
			this.TexEditorPropertyGrid.CommandsBorderColor = Theme.PrimBackColor;
			this.TexEditorPropertyGrid.DisabledItemForeColor = Theme.LabelTextColor;
			this.TexEditorPropertyGrid.LineColor = Theme.ButtonBackColor;
			this.TexEditorPropertyGrid.SelectedItemWithFocusBackColor = Theme.FocusedBackColor;
			this.TexEditorPropertyGrid.SelectedItemWithFocusForeColor = Theme.FocusedForeColor;
			this.TexEditorPropertyGrid.ViewBorderColor = Theme.RegBorderColor;
			this.TexEditorPropertyGrid.ViewBackColor = Theme.PrimBackColor;
			this.TexEditorPropertyGrid.ViewForeColor = Theme.PrimForeColor;

			// Menu strip and menu items
			this.TexEditorMenuStrip.ForeColor = Theme.LabelTextColor;
			
			this.TexEditorAddTextureItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorAddTextureItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorCopyTextureItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorCopyTextureItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorExportAllItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorExportAllItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorExportTextureItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorExportTextureItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorHasherItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorHasherItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorRaiderItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorRaiderItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorRemoveTextureItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorRemoveTextureItem.ForeColor = Theme.MenuItemForeColor;
			this.TexEditorReplaceTextureItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorReplaceTextureItem.ForeColor = Theme.MenuItemForeColor;
		}

		#endregion

		#region Methods

		private void LoadListView(int index = -1)
		{
			this.TexEditorListView.Items.Clear();
			var list = this.TPK.GetTextures();
			this.TexEditorListView.BeginUpdate();

			var count = 0;

			foreach (var texture in list)
			{

				var item = new ListViewItem
				{
					Text = (count++).ToString()
				};

				var compression = texture.Compression.ToString().Substring(8); // TEXCOMP_ = 8
				item.SubItems.Add($"0x{texture.BinKey:X8}");
				item.SubItems.Add(texture.CollectionName);
				item.SubItems.Add(compression);
				this.TexEditorListView.Items.Add(item);

			}

			this.TexEditorListView.EndUpdate();

			if (index < 0 || index >= this.TexEditorListView.Items.Count) return;

			this.TexEditorListView.Items[index].Selected = true;
			this.TexEditorListView.Select();
			this.TexEditorListView.HideSelection = false;
			this.TexEditorListView.Items[index].EnsureVisible();
		}

		private void ToggleMenuStripControls()
		{
			if (this.TexEditorListView.SelectedItems.Count == 0)
			{

				this.TexEditorRemoveTextureItem.Enabled = false;
				this.TexEditorCopyTextureItem.Enabled = false;
				this.TexEditorReplaceTextureItem.Enabled = false;
				this.TexEditorExportTextureItem.Enabled = false;

			}
			else
			{

				this.TexEditorRemoveTextureItem.Enabled = true;
				this.TexEditorCopyTextureItem.Enabled = true;
				this.TexEditorReplaceTextureItem.Enabled = true;
				this.TexEditorExportTextureItem.Enabled = true;

			}
		}

		private uint GetSelectedKey()
		{
			return this.TexEditorListView.SelectedItems.Count == 0
				? UInt32.MaxValue
				: Convert.ToUInt32(this.TexEditorListView.SelectedItems[0].SubItems[1].Text, 16);
		}

		private void DisposeImage()
		{
			if (this.TexEditorImage.Image != null)
			{

				var disposer = this.TexEditorImage.Image;
				this.TexEditorImage.Image = null;
				disposer.Dispose();

			}
		}

		#endregion

		#region Menu Strip

		private void TexEditorAddTextureItem_Click(object sender, EventArgs e)
		{
			if (this.AddTextureDialog.ShowDialog() == DialogResult.OK)
			{

				using var input = new Input("Enter name of the new texture");

				while (true) // use loop instead of recursion to prevent stack overflow
				{

					if (input.ShowDialog() == DialogResult.OK)
					{

						try
						{

							this.TPK.AddTexture(input.Value, this.AddTextureDialog.FileName);

							if (this.TexEditorListView.SelectedIndices.Count > 0)
							{

								this.LoadListView(this.TexEditorListView.SelectedIndices[0]);

							}
							else this.LoadListView();
							this.GenerateAddTextureCommand(input.Value, this.AddTextureDialog.FileName);
							break;

						}
						catch (Exception ex)
						{

							MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

						}

					}
					else
					{

						break;

					}

				}

			}
		}

		private void TexEditorRemoveTextureItem_Click(object sender, EventArgs e)
		{
			try
			{

				var index = this.TexEditorListView.SelectedIndices[0];
				var key = this.GetSelectedKey();
				this.TPK.RemoveTexture(key, eKeyType.BINKEY);
				this.GenerateRemoveTextureCommand(this.TexEditorListView.Items[index].SubItems[1].Text);

				if (this.TPK.TextureCount == 0)
				{

					this.LoadListView();
					this.TexEditorPropertyGrid.SelectedObject = null;
					this.DisposeImage();
					this.ToggleMenuStripControls();
					return;

				}

				if (index == 0) this.LoadListView(0);
				else this.LoadListView(index - 1);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void TexEditorCopyTextureItem_Click(object sender, EventArgs e)
		{
			using var input = new Input("Enter name of the new texture");

			while (true) // use loop instead of recursion to prevent stack overflow
			{

				if (input.ShowDialog() == DialogResult.OK)
				{

					try
					{

						var index = this.TexEditorListView.SelectedIndices[0];
						var key = this.GetSelectedKey();
						this.TPK.CloneTexture(input.Value, key, eKeyType.BINKEY);
						this.GenerateCopyTextureCommand(this.TexEditorListView.Items[index].SubItems[1].Text, input.Value);
						this.LoadListView(index);
						break;

					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}

				}
				else
				{

					break;

				}

			}
		}

		private void TexEditorReplaceTextureItem_Click(object sender, EventArgs e)
		{
			this.ReplaceTextureDialog.ShowDialog();
		}

		private void TexEditorExportTextureItem_Click(object sender, EventArgs e)
		{
			string FilterExt = "Direct Draw Surface files|*.dds|";
			FilterExt += "Portable Network Graphics files|*.png|";
			FilterExt += "Joint Photographic Group files|*.jpg|";
			FilterExt += "Bitmap Pixel Format files|*.bmp";
			this.ExportTextureDialog.Filter = FilterExt;

			if (this.ExportTextureDialog.ShowDialog() == DialogResult.OK)
			{

				try
				{

					string path = this.ExportTextureDialog.FileName;
					string last = Path.GetExtension(path).ToUpperInvariant()[1..];
					var ext = (ImageType)Enum.Parse(typeof(ImageType), last);

					var index = this.TexEditorListView.SelectedIndices[0];
					var key = this.GetSelectedKey();
					var texture = this.TPK.FindTexture(key, eKeyType.BINKEY);

					if (ext == ImageType.DDS)
					{

						using var bw = new BinaryWriter(File.Open(path, FileMode.Create));
						bw.Write(texture.GetDDSArray(false));

					}
					else
					{

						var data = texture.GetDDSArray(true);
						var image = new ILWrapper.Image(data);
						image.Save(path, ext);

					}

				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
		}

		private void TexEditorExportAllItem_Click(object sender, EventArgs e)
		{
			using var browser = new FolderBrowserDialog()
			{
				AutoUpgradeEnabled = false,
				Description = "Select directory where all textures should be exported",
				RootFolder = Environment.SpecialFolder.MyComputer,
				ShowNewFolderButton = true,
			};

			if (browser.ShowDialog() == DialogResult.OK)
			{

				var textures = this.TPK.GetTextures() as IEnumerable;
				foreach (Texture texture in textures)
				{

					var path = Path.Combine(browser.SelectedPath, texture.CollectionName) + ".dds";
					var data = texture.GetDDSArray(false);
					using var bw = new BinaryWriter(File.Open(path, FileMode.Create));
					bw.Write(data);

				}

				MessageBox.Show($"All textures have been exported", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void TexEditorHasherItem_Click(object sender, EventArgs e)
		{
			var hasher = new Hasher() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(hasher);
			hasher.Show();
		}

		private void TexEditorRaiderItem_Click(object sender, EventArgs e)
		{
			var raider = new Raider() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(raider);
			raider.Show();
		}

		#endregion

		#region List View

		private void TexEditorListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.TexEditorListView.SelectedItems.Count == 0)
			{

				this.TexEditorPropertyGrid.SelectedObject = null;
				this.DisposeImage();
				this.panel1.AutoScroll = false;
				this.TexEditorImage.Width = this.panel1.Width;
				this.TexEditorImage.Height = this.panel1.Height;
				this.ToggleMenuStripControls();
				return;

			}

			var item = this.TexEditorListView.SelectedItems[0];
			var key = Convert.ToUInt32(item.SubItems[1].Text, 16);

			var texture = this.TPK.FindTexture(key, eKeyType.BINKEY);

			if (texture == null) return;

			this.TexEditorPropertyGrid.SelectedObject = texture;

			var data = texture.GetDDSArray(true);
			var image = new ILWrapper.Image(data);

			using var ms = new MemoryStream();
			image.Save(ms, ImageType.PNG);

			this.DisposeImage();

			this.TexEditorImage.BorderStyle = BorderStyle.None;
			this.TexEditorImage.Image = Image.FromStream(ms);
			this.TexEditorImage.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.AutoScroll = true;
			this.ToggleMenuStripControls();
		}

		private void TexEditorListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.NewWidth = this.TexEditorListView.Columns[e.ColumnIndex].Width;
			e.Cancel = true;
		}

		private void TexEditorListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			var brush = new SolidBrush(Theme.TextBoxBackColor);
			e.Graphics.FillRectangle(brush, e.Bounds);
			e.DrawText();
		}

		private void TexEditorListView_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			e.DrawDefault = true;
		}

		private void TexEditorListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			uint key;
			int index;

			if (this.TexEditorPropertyGrid.SelectedObject is null)
			{

				key = 0xFFFFFFFF;
				index = -1;

			}
			else
			{

				key = ((Texture)this.TexEditorPropertyGrid.SelectedObject).BinKey;
				index = 0;

			}

			switch (e.Column)
			{
				case 1: // BinKey
					this.TPK.SortTexturesByType(false);
					if (index == 0) index = this.TPK.GetTextureIndex(key, eKeyType.BINKEY);
					this.LoadListView(index);
					break;

				case 2: // CollectionName
					this.TPK.SortTexturesByType(true);
					if (index == 0) index = this.TPK.GetTextureIndex(key, eKeyType.BINKEY);
					this.LoadListView(index);
					break;

				default:
					break;

			}
		}

		#endregion

		#region Events

		private void TexEditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			var key = this.TexEditorListView.SelectedItems[0].SubItems[1].Text;

			if (e.ChangedItem.Label == "CollectionName")
			{

				var name = e.ChangedItem.Value.ToString();
				this.TexEditorListView.SelectedItems[0].SubItems[1].Text = $"0x{name.BinHash():X8}";
				this.TexEditorListView.SelectedItems[0].SubItems[2].Text = name;
				this.TexEditorPropertyGrid.Refresh();

			}

			this.GenerateUpdateTextureCommand(key, e.ChangedItem.Label, e.ChangedItem.Value.ToString());
		}

		private void AddTextureDialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{

				if (!Comp.IsDDSTexture(this.AddTextureDialog.FileName, out string error))
				{

					throw new Exception(error);

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;

			}
		}

		private void ReplaceTextureDialog_FileOk(object sender, CancelEventArgs e)
		{
			var hash = this.TexEditorListView.SelectedItems[0].SubItems[1].Text;
			var key = Convert.ToUInt32(hash, 16);

			try
			{

				if (!Comp.IsDDSTexture(this.ReplaceTextureDialog.FileName, out string error))
				{

					throw new Exception(error);

				}

				var texture = this.TPK.FindTexture(key, eKeyType.BINKEY);
				texture.Reload(this.ReplaceTextureDialog.FileName);
				this.LoadListView(this.TexEditorListView.SelectedIndices[0]);
				this.GenerateReplaceTextureCommand(hash, this.ReplaceTextureDialog.FileName);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;

			}
		}

		private void TextureEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DisposeImage();

			foreach (var form in this._openforms)
			{

				try { form.Close(); }
				catch { }

			}
		}

		#endregion

		#region Commands

		private void GenerateUpdateTextureCommand(string key, string property, string value)
		{
			if (property.Contains(' ')) property = $"\"{property}\"";
			if (value.Contains(' ')) property = $"\"{value}\"";
			var command = $"{eCommandType.update_texture} {this._tpkpath} {key} {property} {value}";
			this.Commands.Add(command);
		}

		private void GenerateAddTextureCommand(string name, string file)
		{
			if (name.Contains(' ')) name = $"\"{name}\"";
			if (file.Contains(' ')) file = $"\"{file}\"";
			var command = $"{eCommandType.add_texture} {this._tpkpath} {name} {file}";
			this.Commands.Add(command);
		}

		private void GenerateRemoveTextureCommand(string key)
		{
			var command = $"{eCommandType.remove_texture} {this._tpkpath} {key}";
			this.Commands.Add(command);
		}

		private void GenerateCopyTextureCommand(string key, string name)
		{
			var command = $"{eCommandType.copy_texture} {this._tpkpath} {key} {name}";
			this.Commands.Add(command);
		}

		private void GenerateReplaceTextureCommand(string key, string file)
		{
			if (file.Contains(' ')) file = $"\"{file}\"";
			var command = $"{eCommandType.replace_texture} {this._tpkpath} {key} {file}";
			this.Commands.Add(command);
		}

		#endregion
	}
}
