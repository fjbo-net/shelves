using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.App.Common.GUI.Forms;
using Shelves.BusinessLayer.Inventory;
using Shelves.BusinessLayer.Products;
using Shelves.GUI.Controls;
using System.Collections;

namespace Shelves.App.Common.GUI.Controls
{
	public partial class ProductCrudPanel : CrudPanelWithSearchBox, IList<Product>
	{
		public ProductCrudPanel()
		{
			AddActionButton.Enabled = false;
			AddActionButton.Click += (object sender, EventArgs e) => DisplayAddDialog();
			EditActionButton.Click += (object sender, EventArgs e) => DisplayEditDialog();
			InitializeComponent();
			SearchBox.SearchActionButton.Click += (object sender, EventArgs e) => SyncListView();
			SearchBox.TextBox.KeyPress += (object sender, KeyPressEventArgs e) =>
			{
				if (e.KeyChar == (char)Keys.Escape) SearchBox.Text = "";
				SyncListView();
				if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
			};

			ListView.DoubleClick += (object sender, EventArgs e) =>
			{
				UpdateGUI();
				if (ListView.SelectedIndices.Count == 1) DisplayEditDialog();
			};
		}

		private ProductForm ProductForm = new ProductForm();

		private IList<Product> DataSource { get; set; }

		public bool HasLookupTerm {
			get => !string.IsNullOrEmpty(SearchBox.Text) &&
				!string.IsNullOrWhiteSpace(SearchBox.Text);
		}

		public int Count => DataSource.Count;

		public bool IsReadOnly => false;

		public Product this[int index] {
			get => DataSource[index];
			set
			{
				DataSource[index] = value;
				SyncListView();
			}
		}

		public int IndexOf(Product item) => DataSource.IndexOf(item);

		public void Insert(int index, Product item) {
			Insert(index, item);
			SyncListView();
		}

		public void RemoveAt(int index) {
			DataSource.RemoveAt(index);
			SyncListView();
		}

		public void Add(Product item) {
			if(!DataSource.Contains(item)) DataSource.Add(item);
			SyncListView();
		}


		public void Clear()
		{
			DataSource.Clear();
			SyncListView();
		}

		public bool Contains(Product item) => DataSource.Contains(item);

		public void CopyTo(Product[] array, int arrayIndex) => DataSource.CopyTo(array, arrayIndex);

		public bool Remove(Product item) => DataSource.Remove(item);

		public IEnumerator<Product> GetEnumerator() => DataSource.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => DataSource.GetEnumerator();


		public void BindTo(ref IList<Product> products)
		{
			DataSource = products;

			if (DataSource == null)
			{
				AddActionButton.Enabled = false;
				return;
			} else
			{
				SyncListView();
				AddActionButton.Enabled = true;
			}
			
		}

		protected override void Delete()
		{
			foreach (int index in ListView.SelectedIndices) RemoveAt(index);
			UpdateGUI();
		}

		private void SyncListView()
		{
			var source = HasLookupTerm ? Inventory.lookupProducts(DataSource, SearchBox.Text) : DataSource;

			ListView.Items.Clear();
			foreach(var product in source)
			{
				ListViewItem item = product.ToListViewItem();
				ListView.Items.Add(item);
				if (ListView.Items.Count % 2 == 0) item.BackColor = Color.FromArgb(240,240,240);
			}
			UpdateGUI();
		}

		public Dictionary<string, Action> UpdateGuiMethods = new Dictionary<string, Action>();
		private void UpdateGUI()
		{
			string searchResultsMessage = " (search results)";

			EditActionButton.Enabled = (ListView.SelectedItems.Count > 0);

			bool hasAssociatedParts = false;

			foreach(int index in ListView.SelectedIndices)
			{
				if (this[index].getAssociatedParts().Count > 0) hasAssociatedParts = true;
			}

			DeleteActionButton.Enabled = (ListView.SelectedItems.Count > 0) && !hasAssociatedParts;

			if(	HasLookupTerm &&
				!HeadingLabel.Text.Contains(searchResultsMessage))
			{
				HeadingLabel.Text += searchResultsMessage;
			} else if(	!HasLookupTerm &&
						HeadingLabel.Text.Contains(searchResultsMessage))
			{
				HeadingLabel.Text = HeadingLabel.Text.Replace(searchResultsMessage, string.Empty);
			}

			foreach (var method in UpdateGuiMethods) method.Value();
		}

		private void ListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateGUI();
		}


		private void DisplayAddDialog()
		{
			ProductForm.Text = "Add Product";
			ProductForm.ShowDialog();
			if(ProductForm.DialogResult == DialogResult.OK)
			{
				Add(ProductForm.Product);
				ProductForm.Reset();
			}
		}

		private void DisplayEditDialog()
		{
			ProductForm.Text = "Edit Product";
			ProductForm.Product = this[ListView.SelectedIndices[0]];
			ProductForm.ShowDialog();

			if(ProductForm.DialogResult == DialogResult.OK)
			{
				this[ListView.SelectedIndices[0]] = ProductForm.Product;
				ProductForm.Reset();
			}
		}
	}
}
