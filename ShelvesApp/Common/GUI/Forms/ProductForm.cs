using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.App.Common.GUI.Controls;
using Shelves.BusinessLayer.Inventory;
using Shelves.BusinessLayer.Entities;
using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.BusinessLayer.Products;
using Shelves.GUI.Colors;
using Shelves.GUI.Controls;
using Shelves.GUI.Controls.Entities;
using Shelves.GUI.Forms;

namespace Shelves.App.Common.GUI.Forms
{
	public partial class ProductForm : ActionFormResponsive
	{
		public ProductForm()
		{
			InitializeComponent();
			Init();

			IList<Part> allParts = Inventory.Instance.getParts();
			InventoryPartsCrudPanel.BindTo(ref allParts);
			
			AssociatedPartsCrudPanel.AddActionButton.Hide();

			var attachButton = InventoryPartsCrudPanel.AddButton("Associate");
			attachButton.Enabled = false;

			attachButton.Click += (object clickSender, EventArgs clickEvent) =>
			{
				foreach (int index in InventoryPartsCrudPanel.SelectedIndices)
				{
					if (index < 0) continue;
					var part = InventoryPartsCrudPanel[index];
					if (part != null) AssociatedPartsCrudPanel.Add(part);
				}
			};

			if (!InventoryPartsCrudPanel.UpdateGuiMethods.ContainsKey("AttachButtonToggle")) InventoryPartsCrudPanel.UpdateGuiMethods.Add("AttachButtonToggle", () => {
				bool enableButton = InventoryPartsCrudPanel.SelectedIndices.Count > 0;

				foreach(int index in InventoryPartsCrudPanel.SelectedIndices)
				{
					if (index < 0) continue;
					var part = InventoryPartsCrudPanel[index];
					if (AssociatedPartsCrudPanel.Contains(part)) enableButton = false;
				}

				attachButton.Enabled =  enableButton;
			});
		}

		public Product Product
		{
			get => ProductDataPanel.Product;
			set => ProductDataPanel.Product = value;
		}


		public override void DefineDynamicResizables()
		{
			var crudPanels = new List<UserControl> {
				InventoryPartsCrudPanel,
				AssociatedPartsCrudPanel
			};

			DynamicResizableControl crudPanelsContainer = new DynamicResizableControl(CrudPanelsFlowLayoutPanel, this);

			crudPanelsContainer.AddResizingRule
				(Dimension.Width,
				width => FlowLayoutPanel.ClientSize.Width
							- (	GetHorizontalMargin(CrudPanelsFlowLayoutPanel)
								+ GetHorizontalPadding(CrudPanelsFlowLayoutPanel)
								+ GetHorizontalMargin(FlowLayoutPanel)
								+ GetHorizontalPadding(FlowLayoutPanel)),
				SizeMode.Small);

			crudPanelsContainer.AddResizingRule
				(Dimension.Width,
				width => FlowLayoutPanel.ClientSize.Width
									- (ProductDataPanel.Width
										+ GetHorizontalMargin(FlowLayoutPanel)
										+ GetHorizontalPadding(FlowLayoutPanel)
										+ GetHorizontalMargin(CrudPanelsFlowLayoutPanel)
										+ GetHorizontalPadding(CrudPanelsFlowLayoutPanel)
										+ 48),
				SizeMode.Medium);

			crudPanelsContainer.AddResizingRule
				(Dimension.Width,
				width => FlowLayoutPanel.ClientSize.Width
									- (ProductDataPanel.Width
										+ GetHorizontalMargin(FlowLayoutPanel)
										+ GetHorizontalPadding(FlowLayoutPanel)
										+ GetHorizontalMargin(CrudPanelsFlowLayoutPanel)
										+ GetHorizontalPadding(CrudPanelsFlowLayoutPanel)
										+ 48),
				SizeMode.Full);

			crudPanelsContainer.AddResizingRule
				(Dimension.Height,
				height => FlowLayoutPanel.ClientSize.Height
							- (	GetVerticalPadding(CrudPanelsFlowLayoutPanel)
								+ 48),
				SizeMode.All);

			foreach (var control in crudPanels)
			{
				DynamicResizableControl resizableControl = new DynamicResizableControl(control, this);

				resizableControl.AddResizingRule
					(Dimension.Width,
						width => CrudPanelsFlowLayoutPanel.ClientSize.Width - 12,
						SizeMode.All);

				base.DynamicResizables.Add(resizableControl);
			}

			base.DynamicResizables.Add(crudPanelsContainer);

			FitComponents();

			PerformLayout();
		}

		public override void FitComponents()
		{
			if (Width > 1200) FitComponentsToFull();
			else if (Width > 800) FitComponentsToMedium();
			else FitComponentsToSmall();
		}

		protected override void Init()
		{
			base.Init();
			if (SaveActionButton != null)
			{
				SaveActionButton.BackColor = Neutral.White;
				SaveActionButton.ForeColor = Neutral.DeepGray;
			}
		}


		public void Reset() => ProductDataPanel.Reset();
		public void ResetGui() => ProductDataPanel.ResetGui();

		public new ValidationResult Validate() => ProductDataPanel.Validate();


		protected override void CloseButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
						"Are you sure that you want to close this window? Any changes will be lost.\nPress 'Yes' to close or 'No' to cancel.",
						$"{Title} is about to close...",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Exclamation);

			if (result == DialogResult.No)
			{
				DialogResult = DialogResult.None;
				return;
			}

			DialogResult = DialogResult.Cancel;
			ProductDataPanel.Reset();
			this.Hide();
		}

		private void ResetActionBUtton_Click(object sender, EventArgs e) => ResetGui();

		private void SaveActionButton_Click(object sender, EventArgs e)
		{
			var validationResut = Validate();

			if (validationResut.IsValid)
			{
				DialogResult = DialogResult.OK;
				this.Hide();
			}
			else
			{
				MessageBox.Show(validationResut.ErrorMessagesAsString(),
								$"{this.Title}: Invalid data",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}

		private void ProductForm_Resize(object sender, EventArgs e) => ParentControl_Resize(sender, e);

		private void ProductForm_Load(object sender, EventArgs e)
		{
			DefineDynamicResizables();
			
			IList<Part> associatedParts = Product.getAssociatedParts();
			IList<Part> partsToRemove = new List<Part>();

			var allParts = Inventory.Instance.getParts();
			
			foreach (Part part in associatedParts)
			{
				if (!allParts.Contains(part)) partsToRemove.Add(part);
			}

			foreach (Part part in partsToRemove) associatedParts.Remove(part);

			AssociatedPartsCrudPanel.BindTo(ref associatedParts);
		}

		private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.None) e.Cancel = true;
		}
	}
}
