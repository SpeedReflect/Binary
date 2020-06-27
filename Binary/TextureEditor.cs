using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Binary.Endscript;
using Binary.Properties;
using ILWrapper.Enums;
using Nikki.Reflection.Enum;
using Nikki.Support.Shared.Class;
using Nikki.Utils;
using Nikki.Utils.EA;
using CoreExtensions.Management;



namespace Binary
{
	public partial class TextureEditor : Form
	{
		private TPKBlock TPK { get; }
		public List<string> Commands { get; }

		public TextureEditor(TPKBlock tpk)
		{
			this.InitializeComponent();
			this.TPK = tpk;
			this.Commands = new List<string>();
			this.Text = $"{this.TPK.CollectionName} Editor";
			this.TexEditorPreview.SizeMode = PictureBoxSizeMode.StretchImage;
			this.TexEditorPreview.Controls.Add(this.TexEditorImage);
			this.TexEditorImage.Location = new Point(0, 0);
			this.TexEditorImage.BackColor = Color.FromArgb(0, 0, 0, 0);
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
			this.TexEditorPreview.Image = Configurations.Default.DarkTheme
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
			this.TexEditorFindTextureItem.BackColor = Theme.MenuItemBackColor;
			this.TexEditorFindTextureItem.ForeColor = Theme.MenuItemForeColor;
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
			var list = this.TPK.GetTextures() as IEnumerable;

			var count = 0;

			foreach (Texture texture in list)
			{

				var item = new ListViewItem
				{
					Text = (count++).ToString()
				};

				item.SubItems.Add($"0x{texture.BinKey:X8}");
				item.SubItems.Add(texture.CollectionName);
				item.SubItems.Add(texture.Compression);
				this.TexEditorListView.Items.Add(item);

			}

			if (index < 0 || index >= this.TexEditorListView.Items.Count) return;

			this.TexEditorListView.Items[index].Selected = true;
			this.TexEditorListView.Select();
			this.TexEditorListView.HideSelection = false;
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
							break;

						}
						catch (Exception ex)
						{

							MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

						}

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
			MessageBox.Show("Coming Soon TM", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void TexEditorFindTextureItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming Soon TM", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void TexEditorExportAllItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming Soon TM", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void TexEditorHasherItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorRaiderItem_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region Main

		private void TexEditorListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.TexEditorListView.SelectedItems.Count == 0)
			{

				this.TexEditorPropertyGrid.SelectedObject = null;
				this.DisposeImage();
				this.ToggleMenuStripControls();
				return;

			}

			var item = this.TexEditorListView.SelectedItems[0];
			var key = Convert.ToUInt32(item.SubItems[1].Text, 16);

			var texture = this.TPK.FindTexture(key, eKeyType.BINKEY);

			if (texture == null) return;

			this.TexEditorPropertyGrid.SelectedObject = texture;

			var data = texture.GetDDSArray();
			var image = new ILWrapper.Image(data);

			using var ms = new MemoryStream();
			image.Save(ms, ImageType.PNG);

			this.DisposeImage();

			this.TexEditorImage.Image = Image.FromStream(ms);
			this.ToggleMenuStripControls();
		}

		private void TexEditorPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.ChangedItem.Label == "CollectionName")
			{

				var name = e.ChangedItem.Value.ToString();
				this.TexEditorListView.SelectedItems[0].SubItems[1].Text = $"0x{name.BinHash():X8}";
				this.TexEditorListView.SelectedItems[0].SubItems[2].Text = name;
				this.TexEditorPropertyGrid.Refresh();

			}
		}

		private void TexEditorListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.NewWidth = this.TexEditorListView.Columns[e.ColumnIndex].Width;
			e.Cancel = true;
		}

		private void TextureEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			var disposer = this.TexEditorPreview.Image;
			this.TexEditorPreview.Image = null;
			if (disposer != null) disposer.Dispose();

			disposer = this.TexEditorImage.Image;
			this.TexEditorImage = null;
			if (disposer != null) disposer.Dispose();
		}

		private void AddTextureDialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{

				string error = String.Empty;
				if (!Comp.IsDDSTexture(this.AddTextureDialog.FileName, ref error))
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
			var key = Convert.ToUInt32(this.TexEditorListView.SelectedItems[0].SubItems[1].Text, 16);

			try
			{

				var texture = this.TPK.FindTexture(key, eKeyType.BINKEY);
				texture.Reload(this.ReplaceTextureDialog.FileName);
				this.LoadListView(this.TexEditorListView.SelectedIndices[0]);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;

			}
		}

		#endregion

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
	}
}
