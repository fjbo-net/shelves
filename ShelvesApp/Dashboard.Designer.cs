namespace Shelves.App
{
	partial class Dashboard
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.PartsCrudPanel = new Shelves.App.Common.GUI.Controls.PartsCrudPanel();
			this.ProductCrudPanel = new Shelves.App.Common.GUI.Controls.ProductCrudPanel();
			this.ActionsPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.FlowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ActionsPanel
			// 
			this.ActionsPanel.Size = new System.Drawing.Size(1004, 50);
			// 
			// CloseButton
			// 
			this.CloseButton.FlatAppearance.BorderSize = 0;
			this.CloseButton.Location = new System.Drawing.Point(933, 8);
			// 
			// headerPanel
			// 
			this.headerPanel.Size = new System.Drawing.Size(1004, 90);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.FlowLayoutPanel);
			this.mainPanel.Size = new System.Drawing.Size(1004, 451);
			this.mainPanel.Controls.SetChildIndex(this.ActionsPanel, 0);
			this.mainPanel.Controls.SetChildIndex(this.FlowLayoutPanel, 0);
			// 
			// FlowLayoutPanel
			// 
			this.FlowLayoutPanel.AutoScroll = true;
			this.FlowLayoutPanel.Controls.Add(this.PartsCrudPanel);
			this.FlowLayoutPanel.Controls.Add(this.ProductCrudPanel);
			this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.FlowLayoutPanel.Name = "FlowLayoutPanel";
			this.FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(12);
			this.FlowLayoutPanel.Size = new System.Drawing.Size(1004, 401);
			this.FlowLayoutPanel.TabIndex = 1;
			// 
			// PartsCrudPanel
			// 
			this.PartsCrudPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.PartsCrudPanel.DisplaySearchbox = true;
			this.PartsCrudPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.PartsCrudPanel.ItemType = null;
			this.PartsCrudPanel.Location = new System.Drawing.Point(15, 15);
			this.PartsCrudPanel.Name = "PartsCrudPanel";
			this.PartsCrudPanel.Size = new System.Drawing.Size(480, 380);
			this.PartsCrudPanel.TabIndex = 2;
			this.PartsCrudPanel.Text = "Parts";
			// 
			// ProductCrudPanel
			// 
			this.ProductCrudPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.ProductCrudPanel.DisplaySearchbox = true;
			this.ProductCrudPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.ProductCrudPanel.ItemType = null;
			this.ProductCrudPanel.Location = new System.Drawing.Point(501, 15);
			this.ProductCrudPanel.Name = "ProductCrudPanel";
			this.ProductCrudPanel.Size = new System.Drawing.Size(467, 380);
			this.ProductCrudPanel.TabIndex = 1;
			this.ProductCrudPanel.Text = "Products";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 541);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.Resize += new System.EventHandler(this.Dashboard_Resize);
			this.ActionsPanel.ResumeLayout(false);
			this.ActionsPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.FlowLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
		private Common.GUI.Controls.ProductCrudPanel ProductCrudPanel;
		private Common.GUI.Controls.PartsCrudPanel PartsCrudPanel;
	}
}