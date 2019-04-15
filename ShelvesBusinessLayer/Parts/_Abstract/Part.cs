using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Shelves.BusinessLayer.Entities;
using Shelves.BusinessLayer.Helpers;
using Shelves.BusinessLayer.Inventory;

namespace Shelves.BusinessLayer.Parts.Abstract
{
    public abstract class Part:IEquatable<Part>, IInventoryItem
	{
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
		protected static int LastId = 0;
		#endregion


		#region Properties
		protected int partID, inStock, min, max;
		protected double price;
		protected string name;
		public List<ValidationCondition<int>> InStockValidationConditions;
		#endregion


		#region Methods
		public void setName(String newName)
		{
			if (IsValidNameValue(newName)) this.name = newName;
		}
		public string getName() => name;
		public ValidationResult ValidateNameValue(string nameValue)
		{
			return Validation.Validate(nameValue, Part.NameValidationConditions);
		}
		public bool IsValidNameValue(string nameValue) => ValidateNameValue(nameValue).IsValid;


		public void setPrice(double newPrice)
		{
			if (IsValidPriceValue(newPrice)) this.price = newPrice;
		}
		public void setPrice(string newPrice)
		{
			double newValue;
			if (double.TryParse(newPrice, out newValue)) setPrice(newValue);
		}
		public double getPrice() => price;
		public ValidationResult ValidatePriceValue(double priceValue)
		{
			return Validation.Validate(priceValue, Part.PriceValidationConditions);
		}
		public bool IsValidPriceValue(double priceValue) => ValidatePriceValue(priceValue).IsValid;


		public void setInStock(int newInStock)
		{
			if (Validation.IsValid(newInStock, this.InStockValidationConditions)) this.inStock = newInStock;
		}
		public void setInStock(string newInstock)
		{
			int newValue;
			if (int.TryParse(newInstock, out newValue)) setInStock(newValue);
		}
		public int getInStock() => inStock;
		public ValidationResult ValidateInStockValue(int inStockValue)
		{
			return Validation.Validate(inStockValue, this.InStockValidationConditions);
		}
		public bool IsValidInStockValue(int inStockValue) => ValidateInStockValue(inStockValue).IsValid;


		public void setMin(int newMin)
		{
			if(IsValidMinValue(newMin)) min = newMin;
		}
		public void setMin(string newMin)
		{
			int newValue;
			if (int.TryParse(newMin, out newValue)) setMin(newValue);
		}
		public int getMin() => min;
		public ValidationResult ValidateMinValue(int minValue)
		{
			return Validation.Validate(minValue, MinValidationConditions);
		}
		public bool IsValidMinValue(int minValue) => ValidateMinValue(minValue).IsValid;


		public void setMax(int newMax)
		{
			if(Validation.IsValid(newMax, Part.MaxValidationConditions)) max = newMax;
		}
		public void setMax(string newMax)
		{
			int newValue;
			if (int.TryParse(newMax, out newValue)) setMax(newValue);
		}
		public int getMax() => max;
		public ValidationResult ValidateMaxValue(int maxValue)
		{
			return Validation.Validate(maxValue, MaxValidationConditions);
		}
		public bool IsValidMaxValue(int maxValue) => ValidateMaxValue(maxValue).IsValid;


		public void setPartID(int newPartId)
		{
			if (Validation.IsValid(newPartId, Part.IDValidationConditions)) partID = newPartId;
		}
		public void setPartID(string newPartId)
		{
			int newValue;
			if (int.TryParse(newPartId, out newValue)) setPartID(newValue);
		}
		public void setID(int newID) => setPartID(newID);
		public void setID(string newID) => setPartID(newID);
		public int getPartID() => partID;
		public int getID() => getPartID();
		

		public bool Equals(Part other)
		{
			if (other == null) return false;
			return (this.partID == other.partID);
		}

		public ListViewItem ToListViewItem() => new ListViewItem(new []{this.getPartID().ToString(), this.getName(), this.getInStock().ToString(), this.getPrice().ToString("C")});


        protected void Init()
		{
			this.InStockValidationConditions = new List<ValidationCondition<int>>()
			{
				//new ValidationCondition<int>( inStock => Validation.IsValid(this.min, Part.MinValidationConditions), "Minimum stock amount needs to be set to a valid amount."),
				//new ValidationCondition<int>( inStock => Validation.IsValid(this.max, Part.MaxValidationConditions), "Maximum stock amount needs to be set to a valid amount."),
				new ValidationCondition<int>( inStock => inStock >= this.min, "Inventory level must be greater or equal to the minimum stock amount."),
				new ValidationCondition<int>( inStock => inStock <= this.max, "Inventory level must be less or equal to the maximum stock amount.")
			};
			this.setPartID(++Part.LastId);
		}
		#endregion
	}
}
