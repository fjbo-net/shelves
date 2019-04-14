namespace Shelves.App.Common.GUI.Controls
{
	partial class ProductDataPanel
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
			this.MinInventoryExtendedTextbox = new Shelves.GUI.Controls.Controls.ExtendedTextbox();
			this.MaxInventoryExtendedTextbox = new Shelves.GUI.Controls.Controls.ExtendedTextbox();
			this.PriceExtendedTextbox = new Shelves.GUI.Controls.Controls.ExtendedTextbox();
			this.InStockExtendedTextbox = new Shelves.GUI.Controls.Controls.ExtendedTextbox();
			this.NameExtendedTextbox = new Shelves.GUI.Controls.Controls.ExtendedTextbox();
			this.IdExtendedTextbox = new Shelves.GUI.Controls.Controls.ExtendedTextbox();
			this.SuspendLayout();
			// 
			// MinInventoryExtendedTextbox
			// 
			this.MinInventoryExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.MinInventoryExtendedTextbox.Label = "Min. Inventory";
			this.MinInventoryExtendedTextbox.Location = new System.Drawing.Point(3, 147);
			this.MinInventoryExtendedTextbox.Name = "MinInventoryExtendedTextbox";
			this.MinInventoryExtendedTextbox.Size = new System.Drawing.Size(300, 20);
			this.MinInventoryExtendedTextbox.TabIndex = 5;
			this.MinInventoryExtendedTextbox.Type = Shelves.GUI.Controls.Controls.ExtendedTextboxType.Int;
			// 
			// MaxInventoryExtendedTextbox
			// 
			this.MaxInventoryExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.MaxInventoryExtendedTextbox.Label = "Max. Inventory";
			this.MaxInventoryExtendedTextbox.Location = new System.Drawing.Point(3, 121);
			this.MaxInventoryExtendedTextbox.Name = "MaxInventoryExtendedTextbox";
			this.MaxInventoryExtendedTextbox.Size = new System.Drawing.Size(300, 20);
			this.MaxInventoryExtendedTextbox.TabIndex = 4;
			this.MaxInventoryExtendedTextbox.Type = Shelves.GUI.Controls.Controls.ExtendedTextboxType.Int;
			// 
			// PriceExtendedTextbox
			// 
			this.PriceExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.PriceExtendedTextbox.Label = "Price/Cost";
			this.PriceExtendedTextbox.Location = new System.Drawing.Point(3, 95);
			this.PriceExtendedTextbox.Name = "PriceExtendedTextbox";
			this.PriceExtendedTextbox.Size = new System.Drawing.Size(300, 20);
			this.PriceExtendedTextbox.TabIndex = 3;
			this.PriceExtendedTextbox.Type = Shelves.GUI.Controls.Controls.ExtendedTextboxType.Double;
			// 
			// InStockExtendedTextbox
			// 
			this.InStockExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.InStockExtendedTextbox.Label = "Inventory Level";
			this.InStockExtendedTextbox.Location = new System.Drawing.Point(3, 69);
			this.InStockExtendedTextbox.Name = "InStockExtendedTextbox";
			this.InStockExtendedTextbox.Size = new System.Drawing.Size(300, 20);
			this.InStockExtendedTextbox.TabIndex = 2;
			this.InStockExtendedTextbox.Type = Shelves.GUI.Controls.Controls.ExtendedTextboxType.Int;
			// 
			// NameExtendedTextbox
			// 
			this.NameExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.NameExtendedTextbox.Label = "Name";
			this.NameExtendedTextbox.Location = new System.Drawing.Point(3, 43);
			this.NameExtendedTextbox.Name = "NameExtendedTextbox";
			this.NameExtendedTextbox.Size = new System.Drawing.Size(300, 20);
			this.NameExtendedTextbox.TabIndex = 1;
			this.NameExtendedTextbox.Type = Shelves.GUI.Controls.Controls.ExtendedTextboxType.Text;
			// 
			// IdExtendedTextbox
			// 
			this.IdExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.IdExtendedTextbox.Label = "ID";
			this.IdExtendedTextbox.Location = new System.Drawing.Point(3, 17);
			this.IdExtendedTextbox.Name = "IdExtendedTextbox";
			this.IdExtendedTextbox.Size = new System.Drawing.Size(300, 20);
			this.IdExtendedTextbox.TabIndex = 0;
			this.IdExtendedTextbox.Type = Shelves.GUI.Controls.Controls.ExtendedTextboxType.Int;
			// 
			// ProductDataPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.MinInventoryExtendedTextbox);
			this.Controls.Add(this.MaxInventoryExtendedTextbox);
			this.Controls.Add(this.PriceExtendedTextbox);
			this.Controls.Add(this.InStockExtendedTextbox);
			this.Controls.Add(this.NameExtendedTextbox);
			this.Controls.Add(this.IdExtendedTextbox);
			this.Name = "ProductDataPanel";
			this.Size = new System.Drawing.Size(314, 203);
			this.ResumeLayout(false);

		}

		#endregion

		private Shelves.GUI.Controls.Controls.ExtendedTextbox IdExtendedTextbox;
		private Shelves.GUI.Controls.Controls.ExtendedTextbox NameExtendedTextbox;
		private Shelves.GUI.Controls.Controls.ExtendedTextbox InStockExtendedTextbox;
		private Shelves.GUI.Controls.Controls.ExtendedTextbox PriceExtendedTextbox;
		private Shelves.GUI.Controls.Controls.ExtendedTextbox MaxInventoryExtendedTextbox;
		private Shelves.GUI.Controls.Controls.ExtendedTextbox MinInventoryExtendedTextbox;
	}
}
