using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binary.Properties;
using ILWrapper.Enums;
using Nikki.Reflection.Enum;
using Nikki.Support.Shared.Class;
using Nikki.Utils;

namespace Binary
{
	public partial class TextureEditor : Form
	{
		private TPKBlock TPK { get; }

		public TextureEditor(TPKBlock tpk)
		{
			this.InitializeComponent();
			this.TPK = tpk;
			this.TexEditorPreview.SizeMode = PictureBoxSizeMode.StretchImage;
			this.TexEditorPreview.Image = Resources.Transparent;
			this.TexEditorPreview.Controls.Add(this.TexEditorImage);
			this.TexEditorImage.Location = new Point(0, 0);
			this.TexEditorImage.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.LoadListView();
			
		}

		private void LoadListView()
		{
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
		}

		private void TexEditorListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.TexEditorListView.SelectedItems.Count == 0) return;

			var item = this.TexEditorListView.SelectedItems[0];
			var key = Convert.ToUInt32(item.SubItems[1].Text, 16);

			var texture = this.TPK.FindTexture(key, eKeyType.BINKEY);

			if (texture == null) return;

			this.TexEditorPropertyGrid.SelectedObject = texture;

			var data = texture.GetDDSArray();
			var image = new ILWrapper.Image(data);

			using var ms = new MemoryStream();
			image.Save(ms, ImageType.PNG);

			if (this.TexEditorImage.Image != null)
			{

				var disposer = this.TexEditorImage.Image;
				this.TexEditorImage.Image = null;
				disposer.Dispose();

			}

			this.TexEditorImage.Image = Image.FromStream(ms);
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

		private void TexEditorAddTextureItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorRemoveTextureItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorCopyTextureItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorReplaceTextureItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorExportTextureItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorFindTextureItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorExportAllItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorHasherItem_Click(object sender, EventArgs e)
		{

		}

		private void TexEditorRaiderItem_Click(object sender, EventArgs e)
		{

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
	}
}
