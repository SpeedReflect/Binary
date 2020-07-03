using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Binary.Properties;
using Nikki.Support.Shared.Class;
using CoreExtensions.Management;



namespace Binary
{
	public partial class StringEditor : Form
	{
		private STRBlock STR { get; }
		private readonly List<Form> _openforms;
		public List<string> Commands { get; }

		private static readonly Color _highlight_light = Color.FromArgb(60, 255, 60);
		private static readonly Color _highlight_dark = Color.FromArgb(160, 20, 30);

		public StringEditor(STRBlock str)
		{
			this.InitializeComponent();
			this.STR = str;
			this._openforms = new List<Form>();
			this.Commands = new List<string>();
			this.Text = $"{this.STR.CollectionName} Editor";
			this.StrEditorListView.Columns[^1].Width = -2;
			this.ToggleTheme();
			this.LoadListView();
			this.ToggleMenuStripControls();
		}

		#region Theme

		private void ToggleTheme()
		{

		}

		#endregion

		private void LoadListView(int index = -1)
		{
			this.StrEditorListView.Items.Clear();
			this.StrEditorListView.BeginUpdate();

			var count = 0;

			foreach (var record in this.STR.GetRecords())
			{

				var item = new ListViewItem()
				{
					Text = (count++).ToString()
				};

				item.SubItems.Add($"0x{record.Key:X8}");
				item.SubItems.Add(record.Label);
				item.SubItems.Add(record.Text);
				this.StrEditorListView.Items.Add(item);

			}

			this.StrEditorListView.EndUpdate();

			if (index < 0 || index >= this.StrEditorListView.Items.Count) return;

			this.FastItemSelection(index);
		}

		private void ToggleMenuStripControls()
		{
			if (this.StrEditorListView.SelectedItems.Count == 0)
			{

				this.RemoveStringToolStripMenuItem.Enabled = false;
				this.EditStringToolStripMenuItem.Enabled = false;
				this.StringEditorTextBox.Enabled = false;

			}
			else
			{

				this.RemoveStringToolStripMenuItem.Enabled = true;
				this.EditStringToolStripMenuItem.Enabled = true;
				this.StringEditorTextBox.Enabled = true;

			}
		}

		private uint GetSelectedKey()
		{
			return this.StrEditorListView.SelectedItems.Count == 0
				? UInt32.MaxValue
				: Convert.ToUInt32(this.StrEditorListView.SelectedItems[0].SubItems[1].Text, 16);
		}

		private int FastFindIndex(uint key)
		{
			int count = 0;

			foreach (var record in this.STR.GetRecords())
			{

				if (record.Key == key) return count;
				++count;

			}

			return -1;
		}

		private void FastItemSelection(int index)
		{
			this.StrEditorListView.Items[index].Selected = true;
			this.StrEditorListView.Select();
			this.StrEditorListView.HideSelection = false;
			this.StrEditorListView.Items[index].EnsureVisible();
		}

		private void AddStringToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void RemoveStringToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{

				var index = this.StrEditorListView.SelectedIndices[0];
				var key = this.GetSelectedKey();
				this.STR.RemoveRecord(key);

				if (this.STR.StringRecordCount == 0)
				{

					this.LoadListView();
					this.StringEditorTextBox.Text = String.Empty;
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

		private void EditStringToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ReplaceStringToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void FindPreviousToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Considering it is activated
			if (this.StrEditorListView.Items.Count == 0) return;

			var index = this.StrEditorListView.SelectedIndices.Count == 0
				? this.StrEditorListView.Items.Count - 1 : this.StrEditorListView.SelectedIndices[0] - 1;

			for (int i = index; i >= 0; --i)
			{

				if (this.StrEditorListView.Items[i].BackColor != this.StrEditorListView.BackColor)
				{

					this.FastItemSelection(i);
					return;

				}

			}

			for (int i = this.StrEditorListView.Items.Count - 1; i > index; --i)
			{

				if (this.StrEditorListView.Items[i].BackColor != this.StrEditorListView.BackColor)
				{

					this.FastItemSelection(i);
					return;

				}

			}
		}

		private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Considering it is activated
			if (this.StrEditorListView.Items.Count == 0) return;

			var index = this.StrEditorListView.SelectedIndices.Count == 0
				? 0 : this.StrEditorListView.SelectedIndices[0] + 1;

			for (int i = index; i < this.StrEditorListView.Items.Count; ++i)
			{

				if (this.StrEditorListView.Items[i].BackColor != this.StrEditorListView.BackColor)
				{

					this.FastItemSelection(i);
					return;

				}

			}

			for (int i = 0; i < index; ++i)
			{

				if (this.StrEditorListView.Items[i].BackColor != this.StrEditorListView.BackColor)
				{

					this.FastItemSelection(i);
					return;

				}

			}
		}

		private void HasherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var hasher = new Hasher() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(hasher);
			hasher.Show();
		}

		private void RaiderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var raider = new Raider() { StartPosition = FormStartPosition.CenterScreen };
			this._openforms.Add(raider);
			raider.Show();
		}

		private void TextBoxKey_TextChanged(object sender, EventArgs e)
		{
			this.StrEditorListView.BeginUpdate();

			if (String.IsNullOrEmpty(this.TextBoxKey.Text))
			{

				foreach (ListViewItem item in this.StrEditorListView.Items)
				{

					item.BackColor = this.StrEditorListView.BackColor;

				}

				this.TextBoxLabel.Enabled = true;
				this.TextBoxText.Enabled = true;
				this.FindNextToolStripMenuItem.Enabled = false;
				this.FindPreviousToolStripMenuItem.Enabled = false;

			}
			else
			{

				var find = this.TextBoxKey.Text.ToUpperInvariant();
				
				foreach (ListViewItem item in this.StrEditorListView.Items)
				{

					var value = item.SubItems[1].Text.ToUpperInvariant();
					item.BackColor = !value.Contains(find)
						? this.StrEditorListView.BackColor
						: Configurations.Default.DarkTheme
							? _highlight_dark
							: _highlight_light;

				}

				this.TextBoxLabel.Enabled = false;
				this.TextBoxText.Enabled = false;
				this.FindNextToolStripMenuItem.Enabled = true;
				this.FindPreviousToolStripMenuItem.Enabled = true;

			}

			this.StrEditorListView.EndUpdate();
		}

		private void TextBoxLabel_TextChanged(object sender, EventArgs e)
		{
			this.StrEditorListView.BeginUpdate();

			if (String.IsNullOrEmpty(this.TextBoxLabel.Text))
			{

				foreach (ListViewItem item in this.StrEditorListView.Items)
				{

					item.BackColor = this.StrEditorListView.BackColor;

				}

				this.TextBoxKey.Enabled = true;
				this.TextBoxText.Enabled = true;
				this.FindNextToolStripMenuItem.Enabled = false;
				this.FindPreviousToolStripMenuItem.Enabled = false;

			}
			else
			{

				var find = this.TextBoxLabel.Text.ToUpperInvariant();

				foreach (ListViewItem item in this.StrEditorListView.Items)
				{

					var value = item.SubItems[2].Text.ToUpperInvariant();
					item.BackColor = !value.Contains(find)
						? this.StrEditorListView.BackColor
						: Configurations.Default.DarkTheme
							? _highlight_dark
							: _highlight_light;

				}

				this.TextBoxKey.Enabled = false;
				this.TextBoxText.Enabled = false;
				this.FindNextToolStripMenuItem.Enabled = true;
				this.FindPreviousToolStripMenuItem.Enabled = true;

			}

			this.StrEditorListView.EndUpdate();
		}

		private void TextBoxText_TextChanged(object sender, EventArgs e)
		{
			this.StrEditorListView.BeginUpdate();

			if (String.IsNullOrEmpty(this.TextBoxText.Text))
			{

				foreach (ListViewItem item in this.StrEditorListView.Items)
				{

					item.BackColor = this.StrEditorListView.BackColor;

				}

				this.TextBoxKey.Enabled = true;
				this.TextBoxLabel.Enabled = true;
				this.FindNextToolStripMenuItem.Enabled = false;
				this.FindPreviousToolStripMenuItem.Enabled = false;

			}
			else
			{

				var find = this.TextBoxText.Text.ToUpperInvariant();

				foreach (ListViewItem item in this.StrEditorListView.Items)
				{

					var value = item.SubItems[3].Text.ToUpperInvariant();
					item.BackColor = !value.Contains(find)
						? this.StrEditorListView.BackColor
						: Configurations.Default.DarkTheme
							? _highlight_dark
							: _highlight_light;

				}

				this.TextBoxKey.Enabled = false;
				this.TextBoxLabel.Enabled = false;
				this.FindNextToolStripMenuItem.Enabled = true;
				this.FindPreviousToolStripMenuItem.Enabled = true;

			}

			this.StrEditorListView.EndUpdate();
		}

		private void StringEditorTextBox_TextChanged(object sender, EventArgs e)
		{
			// Considering it is enabled because string record was selected

			var key = this.GetSelectedKey();
			var record = this.STR.GetRecord(key);

			if (record == null) return;

			var selected = this.StrEditorListView.SelectedItems[0];
			record.Text = this.StringEditorTextBox.Text ?? String.Empty;
			selected.SubItems[3].Text = record.Text;
			
			var upper = record.Text.ToUpperInvariant();
			
			if (!String.IsNullOrEmpty(this.TextBoxText.Text))
			{
			
				selected.BackColor = !upper.Contains(this.TextBoxText.Text.ToUpperInvariant())
					? this.StrEditorListView.BackColor
					: Configurations.Default.DarkTheme
						? _highlight_dark
						: _highlight_light;
			
			}			
		}

		private void StrEditorListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.StrEditorListView.SelectedItems.Count == 0)
			{

				this.StringEditorTextBox.Text = String.Empty;
				this.ToggleMenuStripControls();
				return;

			}

			var key = this.GetSelectedKey();
			var record = this.STR.GetRecord(key);

			if (record == null) return;

			this.StringEditorTextBox.Text = record.Text;
			this.ToggleMenuStripControls();
		}

		private void StrEditorListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.EditStringToolStripMenuItem_Click(this.EditStringToolStripMenuItem, EventArgs.Empty);
		}

		private void StringEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (var form in this._openforms)
			{

				try { form.Close(); }
				catch { }

			}
		}

		private void StrEditorListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			var brush = new SolidBrush(Theme.TextBoxBackColor);
			e.Graphics.FillRectangle(brush, e.Bounds);
			e.DrawText();
		}

		private void StrEditorListView_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			e.DrawDefault = true;
		}

		private void StrEditorListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			uint key;
			int index;

			if (this.StrEditorListView.SelectedItems.Count == 0)
			{

				key = 0xFFFFFFFF;
				index = -1;

			}
			else
			{

				key = this.GetSelectedKey();
				index = 0;

			}

			switch (e.Column)
			{
				case 1: // Key
					this.STR.SortRecordsByKey();
					if (index == 0) index = this.FastFindIndex(key);
					this.LoadListView(index);
					break;

				case 2: // Label
					this.STR.SortRecordsByLabel();
					if (index == 0) index = this.FastFindIndex(key);
					this.LoadListView(index);
					break;

				case 3: // Text
					this.STR.SortRecordsByText();
					if (index == 0) index = this.FastFindIndex(key);
					this.LoadListView(index);
					break;

				default:
					return;

			}

			if (!String.IsNullOrEmpty(this.TextBoxKey.Text))
			{

				this.TextBoxKey_TextChanged(this.TextBoxKey, EventArgs.Empty);

			}
			else if (!String.IsNullOrEmpty(this.TextBoxLabel.Text))
			{

				this.TextBoxLabel_TextChanged(this.TextBoxLabel, EventArgs.Empty);

			}
			else if (!String.IsNullOrEmpty(this.TextBoxText.Text))
			{

				this.TextBoxText_TextChanged(this.TextBoxText, EventArgs.Empty);

			}
		}
	}
}
