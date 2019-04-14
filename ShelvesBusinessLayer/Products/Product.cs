using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using Shelves.BusinessLayer.Parts;
using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.BusinessLayer.Entities;
using Shelves.BusinessLayer.Helpers;
using Shelves.BusinessLayer.Inventory;

namespace Shelves.BusinessLayer.Products
{
	public class Product : IEquatable<Product>, IInventoryItem
	{
		#region Constructors
		public Product()
		{
			this.InStockValidationConditions = new List<ValidationCondition<int>>()
			{
				//new ValidationCondition<int>( inStock => Validation.IsValid(this.min, Product.MinValidationConditions), "Minimum stock amount needs to be set to a valid amount."),
				//new ValidationCondition<int>( inStock => Validation.IsValid(this.max, Product.MaxValidationConditions), "Maximum stock amount needs to be set to a valid amount."),
				new ValidationCondition<int>( inStock => inStock >= this.min, "Inventory level must be greater or equal to the minimum stock amount."),
				new ValidationCondition<int>( inStock => inStock <= this.max, "Inventory level must be less or equal to the maximum stock amount.")
			};
		}

		public Product(int id, string name, int min, int max, int inStock, double price) : this()
		{
			setProductID(id);
			setName(name);
			setMin(min);
			setMax(max);
			setInStock(inStock);
			setPrice(price);
		}
		#endregion


		#region Static Properties
		public static readonly List<ValidationCondition<int>> IDValidationConditions = new List<ValidationCondition<int>>()
		{
			new ValidationCondition<int>(id => (id > 0), "ID must be greater than zero.")
		};
		public static readonly List<ValidationCondition<string>> NameValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(name => !string.IsNullOrEmpty(name), "Name must not be empty")
		};
		public static readonly List<ValidationCondition<double>> PriceValidationConditions = new List<ValidationCondition<double>>()
		{
			new ValidationCondition<double>(price => price > 0, "Price must be greater than zero")
		};
		public static readonly List<ValidationCondition<int>> MinValidationConditions = new List<ValidationCondition<int>>() {
			new ValidationCondition<int>(min => min > 0, "Minimum value must be greater than zero")
		};
		public static readonly List<ValidationCondition<int>> MaxValidationConditions = new List<ValidationCondition<int>>() {
			new ValidationCondition<int>(max => max > 0, "Maximum value must be greater than zero")
		};
		public static DataTable InitializeDataTable()
		{
			DataTable productDataTable = new DataTable();

			productDataTable.Columns.Add("Product ID", typeof(int));
			productDataTable.Columns.Add("Product Name", typeof(string));
			productDataTable.Columns.Add("Inventory Level", typeof(int));
			productDataTable.Columns.Add("Price per Unit", typeof(string));

			return productDataTable;
		}
		#endregion


		#region Properties
		private List<Part> associatedParts;
		private int productID, inStock, min, max;
		private double price;
		private string name;
		private List<ValidationCondition<int>> InStockValidationConditions;
		#endregion


		#region Methods
		public void setName(string newName)
		{
			if (Validation.IsValid(newName, Product.NameValidationConditions)) this.name = newName;
		}
		public string getName() => name;

		public void setPrice(double newPrice)
		{
			if (Validation.IsValid(newPrice, Product.PriceValidationConditions)) this.price = newPrice;
		}
		public void setPrice(string newPrice)
		{
			double value;
			if (double.TryParse(newPrice, out value)) setPrice(value);
		}
		public double getPrice() => price;

		public void setInStock(int newInStock)
		{
			if (Validation.IsValid(newInStock, this.InStockValidationConditions)) this.inStock = newInStock;
		}
		public void setInStock(string newInStock)
		{
			int value;
			if (int.TryParse(newInStock, out value)) setInStock(value);
		}
		public int getInStock() => inStock;

		public void setMin(int newMin)
		{
			if (Validation.IsValid(newMin, Product.MinValidationConditions)) min = newMin;
		}
		public void setMin(string newMin)
		{
			int value;
			if (int.TryParse(newMin, out value)) setMin(value);
		}
		public int getMin() => min;

		public void setMax(int newMax)
		{
			if (Validation.IsValid(newMax, Product.MaxValidationConditions)) this.max = newMax;
		}
		public void setMax(string newMax)
		{
			int value;
			if (int.TryParse(newMax, out value)) setMax(value);
		}
		public int getMax() => max;

		public void addAssociatedPart(Part newPart) { }
		public Part removeAssociatedPart(int byPartId) { return new Inhouse(); }
		public Part lookupAssociatedPart(int byPartId) { return new Inhouse(); }

		public void setProductID(int newProductID)
		{
			if (Validation.IsValid(newProductID, Product.IDValidationConditions)) productID = newProductID;
		}
		public void setProductID(string newProductID)
		{
			int value;
			if (int.TryParse(newProductID, out value)) setProductID(value);
		}
		public void setID(int newProductID) => setProductID(newProductID);
		public void setID(string newProductID) => setProductID(newProductID);
		public int getProductID() => productID;
		public int getID() => getProductID();


		public void AddToDataTable(ref DataTable dataTable)
		{
			DataRow dataRow = dataTable.NewRow();

			dataRow["Product ID"] = this.getProductID();
			dataRow["Product Name"] = this.getName();
			dataRow["Inventory Level"] = this.getInStock();
			dataRow["Price per Unit"] = $"${this.getPrice()}";

			dataTable.Rows.Add(dataRow);
		}

		public ListViewItem ToListViewItem() => new ListViewItem(new[] { this.getProductID().ToString(), this.getName(), this.getInStock().ToString(), this.getPrice().ToString("C") });


		#region Interface Methods
		public bool Equals(Product other)
			{
				if (other == null) return false;
				return (this.productID == other.productID);
			}
			#endregion
		#endregion
	}
}
