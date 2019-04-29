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

using Shelves.BusinessLayer.Inventory;
using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.GUI.Controls;
using Shelves.App.Common.GUI.Forms;

namespace Shelves.App.Common.GUI.Controls
{
	public partial class PartsCrudPanel : CrudPanelWithSearchBox, IList<Part>
	{
		protected PartForm AddPartForm = new PartForm();

		private static List<PartsCrudPanel> Instances = new List<PartsCrudPanel>();

		public static void RefreshAll() {
			foreach (var instance in Instances) instance.SyncListView();
		}

		public PartsCrudPanel()
		{
			AddActionButton.Enabled = false;
			AddActionButton.Click += (object sender, EventArgs e) => DisplayAddPartDialog();
			EditActionButton.Click += (object sender, EventArgs e) => DisplayEditPartDialog();
			InitializeComponent();
			SearchBox.SearchActionButton.Click += (object sender, EventArgs e) => SyncListView();
			SearchBox.TextBox.KeyPress += (object sender, KeyPressEventArgs e) =>
			{
				if (e.KeyChar == (char)Keys.Escape)
				{
					SearchBox.Text = "";
				}
				SyncListView();
				if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
			};

			ListView.DoubleClick += (object sender, EventArgs e) =>
			{
				UpdateGUI();
				if (ListView.SelectedIndices.Count == 1) DisplayEditPartDialog();
			};

			Instances.Add(this);
		}

		protected IList<Part> DataSource { get; set; }
		
		public bool HasLookupTerm
		{
			get => !string.IsNullOrEmpty(SearchBox.Text)
					&& !string.IsNullOrWhiteSpace(SearchBox.Text);
		}

		public int Count => DataSource.Count;

		public bool IsReadOnly => false;

		public Part this[int index]
		{
			get => DataSource[index];
			set
			{
				DataSource[index] = value;
				RefreshAll();
			}
		}

		public int IndexOf(Part item) => DataSource.IndexOf(item);

		public void Insert(int index, Part item)
		{
			DataSource.Insert(index, item);
			RefreshAll();
		}

		public void RemoveAt(int index)
		{
			DataSource.RemoveAt(index);
			RefreshAll();
		}

		public void Add(Part item)
		{
			if (!DataSource.Contains(item)) DataSource.Add(item);
			RefreshAll();
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

		public ListView.SelectedIndexCollection SelectedIndices { get => ListView.SelectedIndices; }


		public void BindTo(ref IList<Part> Parts)
		{
			DataSource = Parts;

			if (DataSource == null)
			{
				AddActionButton.Enabled = false;
			} else
			{
				AddActionButton.Enabled = true;
			}

			RefreshAll();
		}

		protected override void Delete()
		{
			foreach (int index in ListView.SelectedIndices) RemoveAt(index);
			UpdateGUI();
		}

		private void SyncListView()
		{
			var source = HasLookupTerm ? Inventory.lookupParts(DataSource, SearchBox.Text) : DataSource;

			if (source == null) return;

			ListView.Items.Clear();
			foreach (var part in source)
			{
				ListViewItem item = part.ToListViewItem();
				ListView.Items.Add(item);
				if (ListView.Items.Count % 2 == 0) item.BackColor = Color.FromArgb(240,240,240);
			}
			UpdateGUI();
		}

		public Dictionary<string,Action> UpdateGuiMethods = new Dictionary<string,Action>();
		private void UpdateGUI()
		{
			string searchResultsMessage = " (search results)";

			EditActionButton.Enabled = (ListView.SelectedItems.Count == 1);
			DeleteActionButton.Enabled = (ListView.SelectedItems.Count > 0);

			if (HasLookupTerm
				&& !HeadingLabel.Text.Contains(searchResultsMessage))
			{
				HeadingLabel.Text += searchResultsMessage;
			} else if(!HasLookupTerm
						&& HeadingLabel.Text.Contains(searchResultsMessage))
			{
				HeadingLabel.Text = HeadingLabel.Text.Replace(searchResultsMessage, string.Empty);
			}

			foreach (var method in UpdateGuiMethods) method.Value();
		}

		private void ListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateGUI();
		}


		private void DisplayAddPartDialog()
		{
			AddPartForm.Text = "Add Part";
			AddPartForm.ShowDialog();
			if(AddPartForm.DialogResult == DialogResult.OK)
			{
				Add(AddPartForm.Part);
				AddPartForm.Reset();
			}
		}

		private void DisplayEditPartDialog()
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
