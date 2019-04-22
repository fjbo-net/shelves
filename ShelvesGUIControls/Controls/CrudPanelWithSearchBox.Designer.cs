namespace Shelves.GUI.Controls
{
	partial class CrudPanelWithSearchBox
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
			this.SearchBox = new Shelves.GUI.Controls.SearchBox();
			this.HeaderPanel.SuspendLayout();
			this.ContentPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.SearchBox);
			this.HeaderPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
			this.HeaderPanel.Size = new System.Drawing.Size(480, 68);
			this.HeaderPanel.Controls.SetChildIndex(this.HeadingLabel, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.SearchBox, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.Location = new System.Drawing.Point(0, 68);
			this.ContentPanel.Size = new System.Drawing.Size(480, 332);
			// 
			// HeadingLabel
			// 
			this.HeadingLabel.Size = new System.Drawing.Size(288, 25);
			this.HeadingLabel.Text = "CRUD Panel with SearchBox";
			// 
			// ListView
			// 
			this.ListView.Size = new System.Drawing.Size(480, 282);
			// 
			// SearchBox
			// 
			this.SearchBox.BackColor = System.Drawing.Color.Transparent;
			this.SearchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SearchBox.Label = "Search";
			this.SearchBox.Location = new System.Drawing.Point(0, 34);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.SearchBox.Size = new System.Drawing.Size(480, 28);
			this.SearchBox.TabIndex = 1;
			// 
			// CrudPanelWithSearchBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "CrudPanelWithSearchBox";
			this.Text = "CRUD Panel with SearchBox";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.CrudPanelWithSearchBox_Paint);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ContentPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public SearchBox SearchBox;
	}
}
