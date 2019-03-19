using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.GUI.Controls.Entities;
using Shelves.BusinessLayer.Inventory;
using Shelves.BusinessLayer.Parts;
using Shelves.BusinessLayer.Products;

namespace Shelves.App
{
	public partial class MainForm : Form
	{
		private Inventory inventory = new Inventory();
		private DataTable productData;

        private List<DynamicResizableControl> DynamicResizables = new List<DynamicResizableControl>();

		public MainForm()
		{
			Init();
		}

		private void Init()
		{
			InitializeComponent();
			InitializeDataSources();

			//productsDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

			BindDataSources();
		}

		private void InitializeDataSources()
		{
			productData = Product.InitializeDataTable();
		}

		private void BindDataSources()
		{
			Product product1 = new Product();
			product1.setProductID(1);
			product1.setName("Product 1");
			product1.setMin(5);
			product1.setMax(100);
			product1.setInStock(5);
			product1.setPrice(5.00);

			Product product2 = new Product();
			product2.setProductID(2);
			product2.setName("Product 2");
			product2.setMin(5);
			product2.setMax(100);
			product2.setInStock(10);
			product2.setPrice(10.00);

			inventory.addProduct(product1);
			inventory.addProduct(product2);

			product1.AddToDataTable(ref productData);
			product2.AddToDataTable(ref productData);

			productsDataGridView.DataSource = productData;

			foreach(int index in Enumerable.Range(1, 5))
			{
				Inhouse part = new Inhouse();

				part.setPartID(index);
				part.setName($"Part {index}");
				part.setMin(5);
				part.setMax(100);
				part.setInStock(5 + (index * 2));
				part.setPrice(5.00 * index);

				inventory.addPart(part);

				ListViewItem partItem = part.ToListViewItem();

                if (partsListView.Items.Count % 2 == 0) partItem.BackColor = Color.FromArgb(237, 237, 237);

                partsListView.Items.Add(partItem);
            }
		}

        private void FitComponents()
        {
            if(Width > 1200) FitComponentsToFull();
            else if(Width > 800) FitComponentsToMedium();
            else FitComponentsToSmall();
        }

        private void FitComponentsToFull()
        {
            foreach(DynamicResizableControl resizable in DynamicResizables) resizable.Fit(Width,Height);
        }

        private void FitComponentsToMedium()
        {
            foreach (DynamicResizableControl resizable in DynamicResizables) resizable.Fit(Width, Height, SizeMode.Medium);
        }

        private void FitComponentsToSmall()
        {
            foreach (DynamicResizableControl resizable in DynamicResizables) resizable.Fit(Width, Height, SizeMode.Small);
        }

        private void DefineDynamicResizables()
        {
            //DynamicResizableControl partsListViewResizable = new DynamicResizableControl(partsListView, this);
            //partsListViewResizable.AddResizingRule(Dimension.Width, width => partsListViewResizable.Defaults.Width, SizeMode.Small);
            //partsListViewResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.48), SizeMode.Medium);
            //partsListViewResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.48));
            //DynamicResizables.Add(partsListViewResizable);

            DynamicResizableControl partsPanelResizable = new DynamicResizableControl(partsPanel, this);
            partsPanelResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.85), SizeMode.Small);
            partsPanelResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.85), SizeMode.Medium);
            partsPanelResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.47));
            DynamicResizables.Add(partsPanelResizable);

            DynamicResizableControl productsPanelResizable = new DynamicResizableControl(productsPanel, this);
            productsPanelResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.85), SizeMode.Small);
            productsPanelResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.85), SizeMode.Medium);
            productsPanelResizable.AddResizingRule(Dimension.Width, width => (int)(Width * 0.47));
            DynamicResizables.Add(productsPanelResizable);

            FitComponents();

            PerformLayout();
        }

		private void exitButton_Click(object sender, EventArgs e) => this.Close();

        private void MainForm_Resize(object sender, EventArgs e)
        {
            FitComponents();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            partsPanel.AutoSize = true;
            DefineDynamicResizables();
        }

        private void partsListView_Resize(object sender, EventArgs e)
        {
            foreach (ColumnHeader column in partsListView.Columns)
                column.Width = partsListView.Width / partsListView.Columns.Count;
        }
    }
}
