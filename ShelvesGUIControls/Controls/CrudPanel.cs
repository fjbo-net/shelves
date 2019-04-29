using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.GUI.Controls.Interfaces;
using Shelves.GUI.Colors.Entitites;

namespace Shelves.GUI.Controls
{
	public partial class CrudPanel : UserControl, IColorable
	{
		public CrudPanel()
		{
			InitializeComponent();
			ApplyColorPalette(new Colors.PaletteCollection.Base());
			SetDefaults();
		}

		#region Properties
		private string defaultTitle;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                HeadingLabel.Text = !string.IsNullOrEmpty(value) ? value : defaultTitle;
            }
        }

        private string itemType;
        [
            Category(),
            Description("Defines the type of item (or class) being displayed by CRUD panel.")
        ]
        public string ItemType
        {
            get => itemType;
            set
            {
                itemType = value;
                if (string.IsNullOrEmpty(value)) return;
                foreach (var control in Controls)
                {
                    if (control is ActionButton button) button.Text = $"{button.DefaultText} {itemType}";
                }
            }
        }

		protected static Color EvenRow = Colors.Neutral.MediumGray;
		#endregion



		protected virtual void Add() { }
		protected virtual void Edit() { }
		protected virtual void Delete() { }

		
		public ActionButton AddButton(string label)
		{
			ActionButton newButton = new ActionButton();

			if (!string.IsNullOrEmpty(label) && !string.IsNullOrWhiteSpace(label)) newButton.Text = label;

			if(AddActionButton != null)
			{
				newButton.Font = AddActionButton.Font;
				newButton.BackColor = AddActionButton.BackColor;
				newButton.ForeColor = AddActionButton.ForeColor;
			}

			ActionsPanel.Controls.Add(newButton);

			return newButton;
		}

		public void ApplyColorPalette()
        {

        }

        public void ApplyColorPalette(Colors.ColorPalette palette)
        {
			
        }

		private void SetDefaults()
		{
			defaultTitle = HeadingLabel.Text;
		}

		private void CrudPanel_Resize(object sender, EventArgs e)
		{
			foreach (ColumnHeader column in ListView.Columns) column.Width = ListView.Width / ListView.Columns.Count;
		}

		private void DeleteActionButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show(
				"Are you sure you want to delete the selected part?\nPress 'Yes' to proceed, or 'No' to cancel.",
				$"{Text}: Confirm Deletion",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Exclamation);

			if (result == DialogResult.No) return;

			Delete();
		}

		private void EditActionButton_Click(object sender, EventArgs e) => Edit();

		private void AddActionButton_Click(object sender, EventArgs e) => Add();
	}
}
