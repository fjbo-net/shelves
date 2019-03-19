namespace Shelves.App.Common.GUI.Controls
{
	partial class PartsCrudPanel
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
            this.PartIDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartInventoryLevelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartIDColumnHeader,
            this.PartNameColumnHeader,
            this.PartInventoryLevelColumnHeader,
            this.PartPriceColumnHeader});
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            // 
            // PartIDColumnHeader
            // 
            this.PartIDColumnHeader.Text = "Part ID";
            this.PartIDColumnHeader.Width = 85;
            // 
            // PartNameColumnHeader
            // 
            this.PartNameColumnHeader.Text = "Part Name";
            this.PartNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartNameColumnHeader.Width = 149;
            // 
            // PartInventoryLevelColumnHeader
            // 
            this.PartInventoryLevelColumnHeader.Text = "Inventory Level";
            this.PartInventoryLevelColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartInventoryLevelColumnHeader.Width = 133;
            // 
            // PartPriceColumnHeader
            // 
            this.PartPriceColumnHeader.Text = "Price per Unit";
            this.PartPriceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartPriceColumnHeader.Width = 105;
            // 
            // PartsCrudPanel
            // 
            this.Name = "PartsCrudPanel";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader PartIDColumnHeader;
		private System.Windows.Forms.ColumnHeader PartNameColumnHeader;
		private System.Windows.Forms.ColumnHeader PartInventoryLevelColumnHeader;
		private System.Windows.Forms.ColumnHeader PartPriceColumnHeader;
	}
}
