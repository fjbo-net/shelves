using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.GUI.Controls;
using Shelves.App.Common.GUI.Forms;

namespace Shelves.App.Common.GUI.Controls
{
	public partial class PartsCrudPanel : CrudPanelWithSearchBox, IList<Part>
	{
		protected PartForm AddPartForm = new PartForm();

		public PartsCrudPanel()
		{
			AddActionButton.Enabled = false;
			AddActionButton.Click += new EventHandler(DisplayAddPartDialog);
			EditActionButton.Click += new EventHandler(DisplayEditPartDialog);
			InitializeComponent();
		}

		protected IList<Part> DataSource { get; set; }

		public int Count => DataSource.Count;

		public bool IsReadOnly => false;

		public Part this[int index]
		{
			get => DataSource[index];
			set
			{
				DataSource[index] = value;
				SyncListView();
			}
		}

		public int IndexOf(Part item) => DataSource.IndexOf(item);

		public void Insert(int index, Part item)
		{
			DataSource.Insert(index, item);
			SyncListView();
		}

		public void RemoveAt(int index)
		{
			DataSource.RemoveAt(index);
			SyncListView();
		}

		public void Add(Part item)
		{
			DataSource.Add(item);
			SyncListView();
		}


		public void Clear()
		{
			DataSource.Clear();
			SyncListView();
		}

		public bool Contains(Part item) => DataSource.Contains(item);

		public void CopyTo(Part[] array, int arrayIndex) => DataSource.CopyTo(array, arrayIndex);

		public bool Remove(Part item) => DataSource.Remove(item);

		public IEnumerator<Part> GetEnumerator() => DataSource.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => DataSource.GetEnumerator();


		public void BindTo(ref IList<Part> Parts)
		{
			DataSource = Parts;

			if(DataSource == null) return;

			SyncListView();
			AddActionButton.Enabled = true;
		}

		protected override void Delete()
		{
			foreach (int index in ListView.SelectedIndices) RemoveAt(index);
			UpdateGUI();
		}

		private void SyncListView(IList<Part> dataSource = null)
		{
			ListView.Items.Clear();
			foreach (var part in dataSource ?? DataSource)
			{
				ListViewItem item = part.ToListViewItem();
				ListView.Items.Add(item);
				if (ListView.Items.Count % 2 == 0) item.BackColor = EvenRow;
			}
			UpdateGUI();
		}

		private void UpdateGUI()
		{
			EditActionButton.Enabled = (ListView.SelectedItems.Count == 1);
			DeleteActionButton.Enabled = (ListView.SelectedItems.Count > 0);
		}

		private void ListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateGUI();
		}


		private void DisplayAddPartDialog(object sender, EventArgs e)
		{
			AddPartForm.Text = "Add Part";
			AddPartForm.ShowDialog();
			if(AddPartForm.DialogResult == DialogResult.OK)
			{
				Add(AddPartForm.Part);
				AddPartForm.Reset();
			}
		}

		private void DisplayEditPartDialog(object sender, EventArgs e)
		{
			AddPartForm.Text = "Edit Part";
			AddPartForm.Part = this[ListView.SelectedIndices[0]];
			AddPartForm.CanSwitchPartType = false;
			AddPartForm.ShowDialog();

			if(AddPartForm.DialogResult == DialogResult.OK)
			{
				this[ListView.SelectedIndices[0]] = AddPartForm.Part;
				AddPartForm.Reset();
				AddPartForm.CanSwitchPartType = true;
			}
		}
	}
}
