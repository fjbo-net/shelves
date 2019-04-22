using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.BusinessLayer.Inventory;
using Shelves.BusinessLayer.Products;
using Shelves.GUI.Controls;
using Shelves.GUI.Colors;
using Shelves.GUI.Controls.Entities;
using Shelves.GUI.Forms;

namespace Shelves.App
{
	public partial class Dashboard : ActionFormResponsive
	{
		public Dashboard()
		{
			WindowState = FormWindowState.Maximized;
			Inventory.addProducts(new List<Product> { new Product(1,"Product 1", 5, 100, 20, 5.00), new Product(2, "Product 2", 5, 100, 20, 10.00)});
			InitializeComponent();
			Init();
		}

		#region Properties
		private Inventory Inventory => Inventory.Instance;
		private DataTable productData;
		#endregion

		public override void DefineDynamicResizables()
		{
			var crudPanels = new List<CrudPanel>() { PartsCrudPanel, ProductCrudPanel };
			foreach (CrudPanel panel in crudPanels)
			{
				DynamicResizableControl resizable = new DynamicResizableControl(panel, this);
				int layoutPanelPadding = FlowLayoutPanel.Padding.Left
										+ FlowLayoutPanel.Padding.Right,

					layoutPanelMargin = FlowLayoutPanel.Margin.Left
										+ FlowLayoutPanel.Margin.Right,

					panelPadding =	panel.Padding.Left
									+ panel.Padding.Right,

					panelMargin =	panel.Margin.Left
									+ panel.Margin.Right;

				resizable.AddResizingRule(
					Dimension.Width,
					width => (int)	((FlowLayoutPanel.Width -
										(layoutPanelPadding
										+ layoutPanelPadding
										+ panelMargin
										+ panelPadding))),
					SizeMode.Small);

				resizable.AddResizingRule
					(Dimension.Width,
					width => (int)	((FlowLayoutPanel.Width -
										(layoutPanelPadding
										+ layoutPanelMargin
										+ panelMargin
										+ panelPadding))),
					SizeMode.Medium);

				resizable.AddResizingRule
					(Dimension.Width,
					width => (int)	((FlowLayoutPanel.Width -
										(layoutPanelPadding
										+ layoutPanelMargin
										+ panelMargin
										+ panelPadding)) - 2)
									/ crudPanels.Count);
				base.DynamicResizables.Add(resizable);
			}

			FitComponents();

			PerformLayout();
		}

		public override void FitComponents()
		{
			if (Width > 1200) FitComponentsToFull();
			else if (Width > 800) FitComponentsToMedium();
			else FitComponentsToSmall();
		}

		private void Dashboard_Resize(object sender, EventArgs e) => ParentControl_Resize(sender, e);

		private void Dashboard_Load(object sender, EventArgs e)
		{
			DefineDynamicResizables();

			IList<Part> parts = Inventory.getParts();
			PartsCrudPanel.BindTo(ref parts);

			IList<Product> products = Inventory.getProducts();
			ProductCrudPanel.BindTo(ref products);

			ProductCrudPanel.Add(new Product(id: 3, name: "Product 3", min: 5, max: 100, inStock: 15, price: 15.00));
		}
	}
}
