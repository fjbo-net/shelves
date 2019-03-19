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
using Shelves.GUI.Controls;
using System.Collections;

namespace Shelves.App.Common.GUI.Controls
{
	public partial class ProductCrudPanel : CrudPanel, IList<Product>
	{
		public ProductCrudPanel()
		{
			AddActionButton.Enabled = true;
			InitializeComponent();
		}

		private IList<Product> DataSource { get; set; }

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
			DataSource.Add(item);
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
			SyncListView();
		}

		protected override void Delete()
		{
			foreach (int index in ListView.SelectedIndices) RemoveAt(index);
			UpdateGUI();
		}

		private void SyncListView()
		{
			ListView.Items.Clear();
			foreach(var product in DataSource)
			{
				ListViewItem item = product.ToListViewItem();
				ListView.Items.Add(item);
				if (ListView.Items.Count % 2 == 0) item.BackColor = Color.FromArgb(240,240,240);
			}
			UpdateGUI();
		}

		private void UpdateGUI()
		{
			EditActionButton.Enabled = (ListView.SelectedItems.Count > 0);
			DeleteActionButton.Enabled = (ListView.SelectedItems.Count > 0);
		}

		private void ListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateGUI();
		}
	}
}
