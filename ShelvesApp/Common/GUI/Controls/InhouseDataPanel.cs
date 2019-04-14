using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.BusinessLayer.Parts;
using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.BusinessLayer.Helpers;
using Shelves.BusinessLayer.Entities;

namespace Shelves.App.Common.GUI.Controls
{
	public partial class InHousePartDataPanel : UserControl
	{
		public InHousePartDataPanel()
		{
			InitializeComponent();

			Reset();
		}

		private Inhouse _part;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Inhouse Part
		{
			get {
				BindPart();
				return _part;
			}
			
			set
			{
				_part = value;
				BindGUI();
			}
		}

		private void BindPart()
		{
			_part.setID(IdExtendedTextbox.Text);
			_part.setName(NameExtendedTextbox.Text);
			_part.setMin(MinInventoryExtendedTextbox.Text);
			_part.setMax(MaxInventoryExtendedTextbox.Text);
			_part.setInStock(InStockExtendedTextbox.Text);
			_part.setPrice(PriceExtendedTextbox.Text);
			_part.setMachineID(MachineIdExtendedTextbox.Text);
		}

		private void BindGUI()
		{
			IdExtendedTextbox.Text = _part.getID().ToString();
			NameExtendedTextbox.Text = _part.getName();
			InStockExtendedTextbox.Text = _part.getInStock().ToString();
			PriceExtendedTextbox.Text = _part.getPrice().ToString();
			MinInventoryExtendedTextbox.Text = _part.getMin().ToString();
			MaxInventoryExtendedTextbox.Text = _part.getMax().ToString();
			MachineIdExtendedTextbox.Text = _part.getMachineID().ToString();
		}

		public void Reset()
		{
			Part = new Inhouse();
		}


		public ValidationResult Validate()
		{
			List<string> errors = new List<string>();
			List<ValidationResult> results = new List<ValidationResult>();

			int id, inStock, min, max;
			double price;

			//if (int.TryParse(IdExtendedTextbox.Text, out id)) results.Add(Validation.Validate(id, Inhouse.IDValidationConditions));

			return new ValidationResult(errors.Count > 0, errors);
		}
	}
}
