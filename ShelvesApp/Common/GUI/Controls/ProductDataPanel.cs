using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.BusinessLayer.Products;
using Shelves.BusinessLayer.Helpers;
using Shelves.BusinessLayer.Entities;
using Shelves.App.Common.GUI.Forms;

namespace Shelves.App.Common.GUI.Controls
{
	public partial class ProductDataPanel : UserControl
	{
		public ProductDataPanel()
		{
			InitializeComponent();

			Reset();
		}

		private Product _product;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Product Product
		{
			get {
				BindPart();
				return _product;
			}
			
			set
			{
				_product = value;
				BindGUI();
			}
		}

		private void BindPart()
		{
			_product.setID(IdExtendedTextbox.Text);
			_product.setName(NameExtendedTextbox.Text);
			_product.setMin(MinInventoryExtendedTextbox.Text);
			_product.setMax(MaxInventoryExtendedTextbox.Text);
			_product.setInStock(InStockExtendedTextbox.Text);
			_product.setPrice(PriceExtendedTextbox.Text);
		}

		private void BindGUI()
		{
			IdExtendedTextbox.Text = _product.getID().ToString();
			NameExtendedTextbox.Text = _product.getName();
			InStockExtendedTextbox.Text = _product.getInStock().ToString();
			PriceExtendedTextbox.Text = _product.getPrice().ToString();
			MinInventoryExtendedTextbox.Text = _product.getMin().ToString();
			MaxInventoryExtendedTextbox.Text = _product.getMax().ToString();
		}

		public void Reset()
		{
			Product = new Product();
		}


		public ValidationResult Validate()
		{
			List<string> errors = new List<string>();
			List<ValidationResult> results = new List<ValidationResult>();

			int id, inStock, min, max;
			double price;

			//if (int.TryParse(IdExtendedTextbox.Text, out id)) results.Add(Validation.Validate(id, Product.I));
			//if (int.TryParse(IdExtendedTextbox.Text, out id)) results.Add(Validation.Validate(id, Product));

			return new ValidationResult(errors.Count > 0, errors);
		}
	}
}
