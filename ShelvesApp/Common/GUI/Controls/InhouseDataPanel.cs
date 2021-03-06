﻿using System;
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

		public void Reset() => Part = new Inhouse();

		public void ResetGui()
		{
			int existingId = _part != null ? _part.getID() : 0;
			Inhouse newPart = new Inhouse();
			if (existingId != 0) newPart.setID(existingId);

			Part = newPart;
		}


		public new ValidationResult Validate()
		{
			List<string> errors = new List<string>();
			List<ValidationResult> results = new List<ValidationResult>();

			int id;

			if (!int.TryParse(MinInventoryExtendedTextbox.Text, out int min)) errors.Add("Minimum inventory level value is not a valid integer (whole number).");
			if (!int.TryParse(MaxInventoryExtendedTextbox.Text, out int max)) errors.Add("Maximum inventory level value is not a valid integer (whole number).");
			if (!int.TryParse(InStockExtendedTextbox.Text, out int inStock)) errors.Add("Inventory level value is not a valid integer (whole number).");
			if (!double.TryParse(PriceExtendedTextbox.Text, out double price)) errors.Add("Price value isi not a valid double (decimal number).");

			results.Add(Validation.Validate(NameExtendedTextbox.Text, Inhouse.NameValidationConditions));
			results.Add(Validation.Validate(price, Inhouse.PriceValidationConditions));
			results.Add(Validation.Validate(min, Inhouse.MinValidationConditions));
			results.Add(Validation.Validate(max, Inhouse.MaxValidationConditions));
			results.Add(Validation.Validate(inStock, Inhouse.InStockValidationConditions(min,max)));

			foreach (ValidationResult result in results)
			{
				if (!result.IsValid) errors = errors.Concat(result.ErrorMessages).ToList();
			}

			return new ValidationResult(errors.Count == 0, errors);
		}
	}
}
