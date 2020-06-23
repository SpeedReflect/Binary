using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nikki.Core;
using Nikki.Reflection.Enum.CP;



namespace Binary
{
	public partial class AttribCreator : Form
	{
		private const string Boolean = "Boolean";
		private const string Color = "Color";
		private const string Floating = "Floating";
		private const string Integer = "Integer";
		private const string Key = "Key";
		private const string ModelTable = "ModelTable";
		private const string PartID = "PartID";
		private const string String = "String";
		private const string TwoString = "TwoString";

		public uint KeyChosen { get; private set; }

		public AttribCreator(GameINT game)
		{
			this.InitializeComponent();
			this.ToggleTheme();
			this.PopulateAttribTypesBasedOnGame(game);
		}

		private void ToggleTheme()
		{
			this.BackColor = Theme.MainBackColor;
			this.ForeColor = Theme.MainForeColor;
			this.AttribTypeComboBox.BackColor = Theme.TextBoxBackColor;
			this.AttribTypeComboBox.ForeColor = Theme.TextBoxForeColor;
			this.AttribKeyComboBox.BackColor = Theme.TextBoxBackColor;
			this.AttribKeyComboBox.ForeColor = Theme.TextBoxForeColor;
			this.AttribButtonCreate.BackColor = Theme.ButtonBackColor;
			this.AttribButtonCreate.ForeColor = Theme.ButtonForeColor;
			this.AttribButtonCreate.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.AttribButtonHelp.BackColor = Theme.ButtonBackColor;
			this.AttribButtonHelp.ForeColor = Theme.ButtonForeColor;
			this.AttribButtonHelp.FlatAppearance.BorderColor = Theme.ButtonFlatColor;
			this.label1.BackColor = Theme.MainBackColor;
			this.label1.ForeColor = Theme.LabelTextColor;
			this.label2.BackColor = Theme.MainBackColor;
			this.label2.ForeColor = Theme.LabelTextColor;
		}

		private void PopulateAttribTypesBasedOnGame(GameINT game)
		{
			// Since there is not easy type to just "GET" available attribute types,
			// we use what we have available in each module

			switch (game)
			{
				case GameINT.Carbon:
				case GameINT.Prostreet:
				case GameINT.Undercover:
					this.AttribTypeComboBox.Items.AddRange(new string[]
					{
						Boolean, /// <see cref="Nikki.Support.Carbon.Attributes.BoolAttribute"/>
						         /// <see cref="Nikki.Support.Prostreet.Attributes.BoolAttribute"/>						
						
						
						Color,   /// <see cref="Nikki.Support.Carbon.Attributes.ColorAttribute"/>
						         /// <see cref="Nikki.Support.Prostreet.Attributes.ColorAttribute"/>					
						
						
						Floating, /// <see cref="Nikki.Support.Carbon.Attributes.FloatAttribute"/>
						          /// <see cref="Nikki.Support.Prostreet.Attributes.FloatAttribute"/>
						
						
						Integer, /// <see cref="Nikki.Support.Carbon.Attributes.IntAttribute"/>
						         /// <see cref="Nikki.Support.Prostreet.Attributes.IntAttribute"/>
						
						
						Key, /// <see cref="Nikki.Support.Carbon.Attributes.KeyAttribute"/>
						     /// <see cref="Nikki.Support.Prostreet.Attributes.KeyAttribute"/>
						
						
						ModelTable, /// <see cref="Nikki.Support.Carbon.Attributes.ModelTableAttribute"/>
						            /// <see cref="Nikki.Support.Prostreet.Attributes.ModelTableAttribute"/>
						
						
						PartID, /// <see cref="Nikki.Support.Carbon.Attributes.PartIDAttribute"/>
						        /// <see cref="Nikki.Support.Prostreet.Attributes.PartIDAttribute"/>
						
						
						String, /// <see cref="Nikki.Support.Carbon.Attributes.StringAttribute"/>
						        /// <see cref="Nikki.Support.Prostreet.Attributes.StringAttribute"/>
						
						
						TwoString, /// <see cref="Nikki.Support.Carbon.Attributes.TwoStringAttribute"/>
						           /// <see cref="Nikki.Support.Prostreet.Attributes.TwoStringAttribute"/>
					
					});
					this.AttribTypeComboBox.SelectedIndex = 0;
					break;

				case GameINT.Underground2:
				case GameINT.MostWanted:
					this.AttribTypeComboBox.Items.AddRange(new string[]
					{
						Boolean, /// <see cref="Nikki.Support.MostWanted.Attributes.BoolAttribute"/>


						Floating, /// <see cref="Nikki.Support.MostWanted.Attributes.FloatAttribute"/>


						Integer, /// <see cref="Nikki.Support.MostWanted.Attributes.IntAttribute"/>


						Key, /// <see cref="Nikki.Support.MostWanted.Attributes.KeyAttribute"/>


						String, /// <see cref="Nikki.Support.MostWanted.Attributes.StringAttribute"/>

					});
					this.AttribTypeComboBox.SelectedIndex = 0;
					break;

				case GameINT.Underground1:
					break;

				default:
					break;
			}
		}

		private void PopulateAttribKeysBasedOnType()
		{
			string[] values = (this.AttribTypeComboBox.SelectedItem.ToString()) switch
			{
				Boolean => Enum.GetNames(typeof(eAttribBool)),
				Color => Enum.GetNames(typeof(eAttribColor)),
				Floating => Enum.GetNames(typeof(eAttribFloat)),
				Integer => Enum.GetNames(typeof(eAttribInt)),
				Key => Enum.GetNames(typeof(eAttribKey)),
				ModelTable => Enum.GetNames(typeof(eAttribModelTable)),
				PartID => Enum.GetNames(typeof(eAttribPartID)),
				String => Enum.GetNames(typeof(eAttribString)),
				TwoString => Enum.GetNames(typeof(eAttribTwoString)),
				_ => new string[0],
			};

			this.AttribKeyComboBox.Items.Clear();
			Array.Sort(values);
			this.AttribKeyComboBox.Items.AddRange(values);
		}

		private void AttribTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.PopulateAttribKeysBasedOnType();
			this.AttribKeyComboBox.SelectedIndex = 0;
		}

		private void AttribButtonHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Choose attribute type that is going to be applied to a car part. " +
				"Then, based on the type chosen, select attribute key that describes what " +
				"attribute is for", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void AttribButtonCreate_Click(object sender, EventArgs e)
		{
			var type = (this.AttribTypeComboBox.SelectedItem.ToString()) switch
			{
				Boolean => typeof(eAttribBool),
				Color => typeof(eAttribColor),
				Floating => typeof(eAttribFloat),
				Integer => typeof(eAttribInt),
				Key => typeof(eAttribKey),
				ModelTable => typeof(eAttribModelTable),
				PartID => typeof(eAttribPartID),
				String => typeof(eAttribString),
				TwoString => typeof(eAttribTwoString),
				_ => typeof(object),
			};

			this.KeyChosen = (uint)Enum.Parse(type, this.AttribKeyComboBox.SelectedItem.ToString());
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
