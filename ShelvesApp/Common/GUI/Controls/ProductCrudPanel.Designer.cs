namespace Shelves.App.Common.GUI.Controls
{
	partial class ProductCrudPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ProductIDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.InventoryLevelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderPanel.SuspendLayout();
			this.ContentPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(480, 382);
			// 
			// HeadingLabel
			// 
			this.HeadingLabel.Size = new System.Drawing.Size(213, 25);
			this.HeadingLabel.Text = "Product CRUD Panel";
			// 
			// ListView
			// 
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductIDColumnHeader,
            this.ProductNameColumnHeader,
            this.InventoryLevelColumnHeader,
            this.PriceColumnHeader});
			this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
			this.ListView.Size = new System.Drawing.Size(480, 332);
			this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
			// 
			// ProductIDColumnHeader
			// 
			this.ProductIDColumnHeader.Text = "Product ID";
			this.ProductIDColumnHeader.Width = 120;
			// 
			// ProductNameColumnHeader
			// 
			this.ProductNameColumnHeader.Text = "Product Name";
			this.ProductNameColumnHeader.Width = 120;
			// 
			// InventoryLevelColumnHeader
			// 
			this.InventoryLevelColumnHeader.Text = "Inventory Level";
			this.InventoryLevelColumnHeader.Width = 120;
			// 
			// PriceColumnHeader
			// 
			this.PriceColumnHeader.Text = "Price per Unit";
			this.PriceColumnHeader.Width = 120;
			// 
			// ProductCrudPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "ProductCrudPanel";
			this.Size = new System.Drawing.Size(480, 450);
			this.Text = "Product CRUD Panel";
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ContentPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader ProductIDColumnHeader;
		private System.Windows.Forms.ColumnHeader ProductNameColumnHeader;
		private System.Windows.Forms.ColumnHeader InventoryLevelColumnHeader;
		private System.Windows.Forms.ColumnHeader PriceColumnHeader;
	}
}
