namespace Shelves.App.Common.GUI.Forms
{
	partial class ProductForm
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
			this.ResetActionButton = new Shelves.GUI.Controls.ActionButton();
			this.SaveActionButton = new Shelves.GUI.Controls.ActionButton();
			this.ProductDataPanel = new Shelves.App.Common.GUI.Controls.ProductDataPanel();
			this.CrudPanelsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.InventoryPartsCrudPanel = new Shelves.App.Common.GUI.Controls.PartsCrudPanel();
			this.AssociatedPartsCrudPanel = new Shelves.App.Common.GUI.Controls.PartsCrudPanel();
			this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ActionsPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.CrudPanelsFlowLayoutPanel.SuspendLayout();
			this.FlowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ActionsPanel
			// 
			this.ActionsPanel.Controls.Add(this.SaveActionButton);
			this.ActionsPanel.Controls.Add(this.ResetActionButton);
			this.ActionsPanel.Size = new System.Drawing.Size(1184, 50);
			this.ActionsPanel.Controls.SetChildIndex(this.CloseButton, 0);
			this.ActionsPanel.Controls.SetChildIndex(this.ResetActionButton, 0);
			this.ActionsPanel.Controls.SetChildIndex(this.SaveActionButton, 0);
			// 
			// CloseButton
			// 
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.FlatAppearance.BorderSize = 0;
			this.CloseButton.Location = new System.Drawing.Point(1113, 8);
			// 
			// headerPanel
			// 
			this.headerPanel.Size = new System.Drawing.Size(1184, 90);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.FlowLayoutPanel);
			this.mainPanel.Size = new System.Drawing.Size(1184, 451);
			this.mainPanel.Controls.SetChildIndex(this.ActionsPanel, 0);
			this.mainPanel.Controls.SetChildIndex(this.FlowLayoutPanel, 0);
			// 
			// ResetActionButton
			// 
			this.ResetActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ResetActionButton.AutoSize = true;
			this.ResetActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ResetActionButton.FlatAppearance.BorderSize = 0;
			this.ResetActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResetActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResetActionButton.Location = new System.Drawing.Point(12, 8);
			this.ResetActionButton.Name = "ResetActionButton";
			this.ResetActionButton.Size = new System.Drawing.Size(62, 30);
			this.ResetActionButton.TabIndex = 3;
			this.ResetActionButton.Text = "Reset";
			this.ResetActionButton.UseVisualStyleBackColor = true;
			this.ResetActionButton.Click += new System.EventHandler(this.ResetActionBUtton_Click);
			// 
			// SaveActionButton
			// 
			this.SaveActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveActionButton.AutoSize = true;
			this.SaveActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SaveActionButton.FlatAppearance.BorderSize = 0;
			this.SaveActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveActionButton.Location = new System.Drawing.Point(1052, 8);
			this.SaveActionButton.Name = "SaveActionButton";
			this.SaveActionButton.Size = new System.Drawing.Size(55, 30);
			this.SaveActionButton.TabIndex = 4;
			this.SaveActionButton.Text = "Save";
			this.SaveActionButton.UseVisualStyleBackColor = true;
			this.SaveActionButton.Click += new System.EventHandler(this.SaveActionButton_Click);
			// 
			// ProductDataPanel
			// 
			this.ProductDataPanel.BackColor = System.Drawing.Color.Transparent;
			this.ProductDataPanel.Location = new System.Drawing.Point(9, 8);
			this.ProductDataPanel.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
			this.ProductDataPanel.Name = "ProductDataPanel";
			this.ProductDataPanel.Size = new System.Drawing.Size(350, 262);
			this.ProductDataPanel.TabIndex = 1;
			// 
			// CrudPanelsFlowLayoutPanel
			// 
			this.CrudPanelsFlowLayoutPanel.AutoScroll = true;
			this.CrudPanelsFlowLayoutPanel.Controls.Add(this.InventoryPartsCrudPanel);
			this.CrudPanelsFlowLayoutPanel.Controls.Add(this.AssociatedPartsCrudPanel);
			this.CrudPanelsFlowLayoutPanel.Location = new System.Drawing.Point(3, 281);
			this.CrudPanelsFlowLayoutPanel.Name = "CrudPanelsFlowLayoutPanel";
			this.CrudPanelsFlowLayoutPanel.Size = new System.Drawing.Size(801, 392);
			this.CrudPanelsFlowLayoutPanel.TabIndex = 2;
			// 
			// InventoryPartsCrudPanel
			// 
			this.InventoryPartsCrudPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.InventoryPartsCrudPanel.DisplaySearchbox = true;
			this.InventoryPartsCrudPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.InventoryPartsCrudPanel.ItemType = null;
			this.InventoryPartsCrudPanel.Location = new System.Drawing.Point(4, 4);
			this.InventoryPartsCrudPanel.Margin = new System.Windows.Forms.Padding(4);
			this.InventoryPartsCrudPanel.Name = "InventoryPartsCrudPanel";
			this.InventoryPartsCrudPanel.Size = new System.Drawing.Size(383, 380);
			this.InventoryPartsCrudPanel.TabIndex = 0;
			this.InventoryPartsCrudPanel.Text = "All Parts";
			// 
			// AssociatedPartsCrudPanel
			// 
			this.AssociatedPartsCrudPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.AssociatedPartsCrudPanel.DisplaySearchbox = false;
			this.AssociatedPartsCrudPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.AssociatedPartsCrudPanel.ItemType = null;
			this.AssociatedPartsCrudPanel.Location = new System.Drawing.Point(395, 4);
			this.AssociatedPartsCrudPanel.Margin = new System.Windows.Forms.Padding(4);
			this.AssociatedPartsCrudPanel.Name = "AssociatedPartsCrudPanel";
			this.AssociatedPartsCrudPanel.Size = new System.Drawing.Size(383, 380);
			this.AssociatedPartsCrudPanel.TabIndex = 1;
			this.AssociatedPartsCrudPanel.Text = "Associated Parts";
			// 
			// FlowLayoutPanel
			// 
			this.FlowLayoutPanel.AutoScroll = true;
			this.FlowLayoutPanel.Controls.Add(this.ProductDataPanel);
			this.FlowLayoutPanel.Controls.Add(this.CrudPanelsFlowLayoutPanel);
			this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.FlowLayoutPanel.Name = "FlowLayoutPanel";
			this.FlowLayoutPanel.Size = new System.Drawing.Size(1184, 401);
			this.FlowLayoutPanel.TabIndex = 3;
			// 
			// ProductForm
			// 
			this.AcceptButton = this.SaveActionButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(1184, 541);
			this.Name = "ProductForm";
			this.Text = "ProductForm";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			this.Resize += new System.EventHandler(this.ProductForm_Resize);
			this.ActionsPanel.ResumeLayout(false);
			this.ActionsPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.CrudPanelsFlowLayoutPanel.ResumeLayout(false);
			this.FlowLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ProductDataPanel ProductDataPanel;
		private Shelves.GUI.Controls.ActionButton ResetActionButton;
		private Shelves.GUI.Controls.ActionButton SaveActionButton;
		private System.Windows.Forms.FlowLayoutPanel CrudPanelsFlowLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
		private Controls.PartsCrudPanel InventoryPartsCrudPanel;
		private Controls.PartsCrudPanel AssociatedPartsCrudPanel;
	}
}