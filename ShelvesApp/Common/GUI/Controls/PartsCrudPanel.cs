﻿using System;
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

namespace Shelves.App.Common.GUI.Controls
{
	public partial class PartsCrudPanel : CrudPanel, IList<Part>
	{
		public PartsCrudPanel()
		{
			AddActionButton.Enabled = true;
			InitializeComponent();
		}

		private IList<Part> DataSource { get; set; }

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
			Insert(index, item);
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
			foreach (var part in DataSource)
			{
				ListViewItem item = part.ToListViewItem();
				ListView.Items.Add(item);
				if (ListView.Items.Count % 2 == 0) item.BackColor = EvenRow;
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