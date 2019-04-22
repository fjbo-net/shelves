using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelves.GUI.Controls
{
	public partial class CrudPanelWithSearchBox : CrudPanel
	{
		public CrudPanelWithSearchBox()
		{
			InitializeComponent();
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public bool DisplaySearchbox { get; set; } = true;

		public void HideSearchBox()
		{
			if (!SearchBox.Visible) return;

			SearchBox.Hide();
			HeaderPanel.Height -= SearchBox.Height;
		}

		public void ShowSearchBox()
		{
			if (SearchBox.Visible) return;

			HeaderPanel.Height += SearchBox.Height;
			SearchBox.Show();
		}

		public void ToggleSearchBox()
		{
			if (SearchBox == null) return;

			if (DisplaySearchbox) ShowSearchBox();
			else HideSearchBox();
		}

		protected void CrudPanelWithSearchBox_Paint(object sender, PaintEventArgs e)
		{
			ToggleSearchBox();
		}
	}
}
