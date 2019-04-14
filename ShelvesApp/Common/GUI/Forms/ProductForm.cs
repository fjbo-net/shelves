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
using Shelves.BusinessLayer.Products;
using Shelves.GUI.Forms;
using Shelves.GUI.Colors;

namespace Shelves.App.Common.GUI.Forms
{
	public partial class ProductForm : ActionForm
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

		protected override void CloseButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			ProductDataPanel.Reset();
			this.Hide();
		}

		private void ResetActionBUtton_Click(object sender, EventArgs e) => ProductDataPanel.Reset();

		private void SaveActionButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Hide();
		}
	}
}
