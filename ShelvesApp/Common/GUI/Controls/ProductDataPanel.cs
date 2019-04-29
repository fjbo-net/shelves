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


		// TODO: FJBO: account for associated parts when reseting a product
		public void Reset() => Product = new Product();

		public void ResetGui()
		{
			int currentId = _product != null ? _product.getID() : 0;
			Product newProduct = new Product();
			if (currentId != 0) newProduct.setID(currentId);

			Product = newProduct;
		}


		public new ValidationResult Validate()
		{
			List<string> errors = new List<string>();
			List<ValidationResult> results = new List<ValidationResult>();

			int id;
			
			if (!int.TryParse(MinInventoryExtendedTextbox.Text, out int min)) errors.Add($"Value \"{MinInventoryExtendedTextbox.Text}\" is not a valid integer value (whole number).");
			if (!int.TryParse(MaxInventoryExtendedTextbox.Text, out int max)) errors.Add($"Value \"{MaxInventoryExtendedTextbox.Text}\" is not a valid integer value (whole number).");
			if (!int.TryParse(InStockExtendedTextbox.Text, out int inStock)) errors.Add($"Value \"{InStockExtendedTextbox.Text}\" is not a valid integer value (whole number).");
			if (!double.TryParse(PriceExtendedTextbox.Text, out double price)) errors.Add($"Value \"{InStockExtendedTextbox.Text}\" is not a valid double value (decimal number).");

			results.Add(Validation.Validate(NameExtendedTextbox.Text, Product.NameValidationConditions));
			results.Add(Validation.Validate(price, Product.PriceValidationConditions));
			results.Add(Validation.Validate(min, Product.MinValidationConditions));
			results.Add(Validation.Validate(max, Product.MaxValidationConditions));
			results.Add(Validation.Validate(inStock, Product.InStockValidationConditions(min, max)));

			results.Add(Validation.Validate(_product.getAssociatedParts(), Product.AssociatedPartsValidationConditions));

			foreach(ValidationResult result in results)
			{
				if (!result.IsValid) errors = errors.Concat(result.ErrorMessages).ToList();
			}

			return new ValidationResult(errors.Count == 0, errors);
		}
	}
}
