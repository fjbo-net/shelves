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
		private static readonly List<ValidationCondition<int>> IDValidationConditions = new List<ValidationCondition<int>>()
		{
			new ValidationCondition<int>(id => (id > 0), "ID must be greater than zero.")
		};
		private static readonly List<ValidationCondition<string>> NameValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(name => !string.IsNullOrEmpty(name), "Name must not be empty")
		};
		private static readonly List<ValidationCondition<double>> PriceValidationConditions = new List<ValidationCondition<double>>()
		{
			new ValidationCondition<double>(price => price > 0, "Price must be greater than zero")
		};
		private static readonly List<ValidationCondition<int>> MinValidationConditions = new List<ValidationCondition<int>>() {
			new ValidationCondition<int>(min => min > 0, "Minimum value must be greater than zero")
		};
		private static readonly List<ValidationCondition<int>> MaxValidationConditions = new List<ValidationCondition<int>>() {
			new ValidationCondition<int>(max => max > 0, "Maximum value must be greater than zero")
		};
		#endregion


		#region Properties
		protected int partID, inStock, min, max;
		protected double price;
		protected string name;
		List<ValidationCondition<int>> InStockValidationConditions;
		#endregion


		#region Methods
		public void setName(String newName)
		{
			if (Validation.IsValid(newName, Part.NameValidationConditions)) this.name = newName;
		}
		public string getName() => name;


		public void setPrice(double newPrice)
		{
			if (Validation.IsValid(newPrice, Part.PriceValidationConditions)) this.price = newPrice;
		}
		public double getPrice() => price;

		public void setInStock(int newInStock)
		{
			if (Validation.IsValid(newInStock, this.InStockValidationConditions)) this.inStock = newInStock;
		}
		public int getInStock() => inStock;

		public void setMin(int newMin)
		{
			if(Validation.IsValid(newMin, Part.MinValidationConditions)) min = newMin;
		}
		public int getMin() => min;

		public void setMax(int newMax)
		{
			if(Validation.IsValid(newMax, Part.MaxValidationConditions)) max = newMax;
		}
		public int getMax() => max;

		public void setPartID(int newPartId)
		{
			if (Validation.IsValid(newPartId, Part.IDValidationConditions)) partID = newPartId;
		}
		public void setID(int newID) => setPartID(newID);
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
				new ValidationCondition<int>( inStock => Validation.IsValid(this.min, Part.MinValidationConditions), "Minimum stock amount needs to be set to a valid amount."),
				new ValidationCondition<int>( inStock => Validation.IsValid(this.max, Part.MaxValidationConditions), "Maximum stock amount needs to be set to a valid amount."),
				new ValidationCondition<int>( inStock => inStock >= this.min, "Inventory level must be greater or equal to the minimum stock amount."),
				new ValidationCondition<int>( inStock => inStock <= this.max, "Inventory level must be less or equal to the maximum stock amount.")
			};
		}
		#endregion
	}
}
