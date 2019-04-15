using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelves.GUI.Controls.Controls
{
	public partial class ExtendedTextbox : UserControl
	{
		public ExtendedTextbox()
		{
			Init();
			_textbox.KeyPress += FilterKeyPresses;
		}

		protected void Init()
		{
			InitializeComponent();
			_textbox.BackColor = Colors.Neutral.PaperWhite;
		}

		private void ExtendedTextbox_Load(object sender, EventArgs e)
		{

		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public string Label {
			get => _label.Text;
			set => _label.Text = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			get => _textbox.Text;
			set => _textbox.Text = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public ExtendedTextboxType Type {
			get => _type;
			set => _type = value;
		}
		private ExtendedTextboxType _type = ExtendedTextboxType.Text;

		private void FilterKeyPresses(object sender, KeyPressEventArgs e)
		{
			IEnumerable<int> backspace = new int[]{ 8 };
			IEnumerable<int> period = new int[] { '.' };
			var digits = Enumerable.Range('0', '9' - '0' + 1);

			switch(Type)
			{
				case ExtendedTextboxType.Int:
					if ( !(digits.Concat(backspace)).Contains(e.KeyChar) ) e.Handled = true;
					break;
				case ExtendedTextboxType.Double:
					if ( !
						(digits.Concat(backspace).Concat(period)).Contains(e.KeyChar)
						|| (e.KeyChar == '.' && _textbox.Text.Contains('.'))
						) e.Handled = true;
					break;
			}
			Console.WriteLine($"Key pressed '{e.KeyChar}' [{(int)e.KeyChar}]");
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		protected new bool Enabled
		{
			get => _textbox.Enabled;
			set => _textbox.Enabled  = value;
		}
	}

	public enum ExtendedTextboxType
	{
		Text,
		Int,
		Double,
		Custom
	}
}
