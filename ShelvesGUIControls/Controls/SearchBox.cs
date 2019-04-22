using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Shelves.GUI.Colors;

namespace Shelves.GUI.Controls
{
	public partial class SearchBox : UserControl
	{
		public SearchBox()
		{
			InitializeComponent();
			Init();
		}

		protected void Init()
		{
			SearchActionButton.BackColor = Neutral.PaperWhite;
			SearchActionButton.ForeColor = Neutral.DeepGray;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public string Label
		{
			get => SearchActionButton.Text;
			set => SearchActionButton.Text = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			get => TextBox.Text;
			set => TextBox.Text = value;
		}

		
	}
}
