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
using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.BusinessLayer.Products;
using Shelves.GUI.Colors;
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


		protected override void CloseButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			ProductDataPanel.Reset();
			this.Hide();
		}

		private void ResetActionBUtton_Click(object sender, EventArgs e) => ResetGui();

		private void SaveActionButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void ProductForm_Resize(object sender, EventArgs e) => ParentControl_Resize(sender, e);

		private void ProductForm_Load(object sender, EventArgs e)
		{
			DefineDynamicResizables();

			IList<Part> parts = Inventory.Instance.getParts();
		}
	}
}
