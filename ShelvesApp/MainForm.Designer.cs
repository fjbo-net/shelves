namespace Shelves.App
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.titleLabel = new System.Windows.Forms.Label();
			this.containerPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.partsPanel = new System.Windows.Forms.Panel();
			this.partsListView = new System.Windows.Forms.ListView();
			this.partsPartIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.partsPartNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.partsInStockColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.partsPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.partsButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.deletePartButton = new System.Windows.Forms.Button();
			this.modifyPartButton = new System.Windows.Forms.Button();
			this.addPartButton = new System.Windows.Forms.Button();
			this.partsLabel = new System.Windows.Forms.Label();
			this.productsPanel = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.deleteProductButton = new System.Windows.Forms.Button();
			this.modifyProductButton = new System.Windows.Forms.Button();
			this.addProductButton = new System.Windows.Forms.Button();
			this.productsDataGridView = new System.Windows.Forms.DataGridView();
			this.productsLabel = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			this.headerBar = new System.Windows.Forms.Panel();
			this.subtitleLabel = new System.Windows.Forms.Label();
			this.windowActionsPanel = new System.Windows.Forms.Panel();
			this.containerPanel.SuspendLayout();
			this.partsPanel.SuspendLayout();
			this.partsButtonFlowLayoutPanel.SuspendLayout();
			this.productsPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
			this.headerBar.SuspendLayout();
			this.windowActionsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.titleLabel.Location = new System.Drawing.Point(12, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(454, 26);
			this.titleLabel.TabIndex = 1;
			this.titleLabel.Text = "FJBO Selves: Inventory Management System";
			// 
			// containerPanel
			// 
			this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.containerPanel.AutoScroll = true;
			this.containerPanel.Controls.Add(this.partsPanel);
			this.containerPanel.Controls.Add(this.productsPanel);
			this.containerPanel.Location = new System.Drawing.Point(17, 96);
			this.containerPanel.Name = "containerPanel";
			this.containerPanel.Size = new System.Drawing.Size(975, 368);
			this.containerPanel.TabIndex = 2;
			// 
			// partsPanel
			// 
			this.partsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.partsPanel.Controls.Add(this.partsListView);
			this.partsPanel.Controls.Add(this.partsButtonFlowLayoutPanel);
			this.partsPanel.Controls.Add(this.partsLabel);
			this.partsPanel.Location = new System.Drawing.Point(3, 3);
			this.partsPanel.Name = "partsPanel";
			this.partsPanel.Size = new System.Drawing.Size(480, 356);
			this.partsPanel.TabIndex = 0;
			// 
			// partsListView
			// 
			this.partsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.partsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.partsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partsPartIdColumnHeader,
            this.partsPartNameColumnHeader,
            this.partsInStockColumnHeader,
            this.partsPriceColumnHeader});
			this.partsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partsListView.FullRowSelect = true;
			this.partsListView.GridLines = true;
			this.partsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.partsListView.HideSelection = false;
			this.partsListView.Location = new System.Drawing.Point(7, 28);
			this.partsListView.MultiSelect = false;
			this.partsListView.Name = "partsListView";
			this.partsListView.Size = new System.Drawing.Size(470, 283);
			this.partsListView.TabIndex = 3;
			this.partsListView.UseCompatibleStateImageBehavior = false;
			this.partsListView.View = System.Windows.Forms.View.Details;
			this.partsListView.Resize += new System.EventHandler(this.partsListView_Resize);
			// 
			// partsPartIdColumnHeader
			// 
			this.partsPartIdColumnHeader.Text = "Part ID";
			// 
			// partsPartNameColumnHeader
			// 
			this.partsPartNameColumnHeader.Text = "Part Name";
			// 
			// partsInStockColumnHeader
			// 
			this.partsInStockColumnHeader.Text = "Inventory Level";
			// 
			// partsPriceColumnHeader
			// 
			this.partsPriceColumnHeader.Text = "Price/Cost per Unit";
			// 
			// partsButtonFlowLayoutPanel
			// 
			this.partsButtonFlowLayoutPanel.Controls.Add(this.deletePartButton);
			this.partsButtonFlowLayoutPanel.Controls.Add(this.modifyPartButton);
			this.partsButtonFlowLayoutPanel.Controls.Add(this.addPartButton);
			this.partsButtonFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.partsButtonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.partsButtonFlowLayoutPanel.Location = new System.Drawing.Point(0, 317);
			this.partsButtonFlowLayoutPanel.Name = "partsButtonFlowLayoutPanel";
			this.partsButtonFlowLayoutPanel.Size = new System.Drawing.Size(480, 39);
			this.partsButtonFlowLayoutPanel.TabIndex = 2;
			// 
			// deletePartButton
			// 
			this.deletePartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.deletePartButton.FlatAppearance.BorderSize = 0;
			this.deletePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deletePartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.deletePartButton.Location = new System.Drawing.Point(377, 3);
			this.deletePartButton.Name = "deletePartButton";
			this.deletePartButton.Size = new System.Drawing.Size(100, 32);
			this.deletePartButton.TabIndex = 2;
			this.deletePartButton.Text = "Delete";
			this.deletePartButton.UseVisualStyleBackColor = false;
			// 
			// modifyPartButton
			// 
			this.modifyPartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.modifyPartButton.FlatAppearance.BorderSize = 0;
			this.modifyPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modifyPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifyPartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.modifyPartButton.Location = new System.Drawing.Point(251, 3);
			this.modifyPartButton.Name = "modifyPartButton";
			this.modifyPartButton.Size = new System.Drawing.Size(120, 32);
			this.modifyPartButton.TabIndex = 1;
			this.modifyPartButton.Text = "Modify Part";
			this.modifyPartButton.UseVisualStyleBackColor = false;
			// 
			// addPartButton
			// 
			this.addPartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.addPartButton.FlatAppearance.BorderSize = 0;
			this.addPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addPartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.addPartButton.Location = new System.Drawing.Point(125, 3);
			this.addPartButton.Name = "addPartButton";
			this.addPartButton.Size = new System.Drawing.Size(120, 32);
			this.addPartButton.TabIndex = 0;
			this.addPartButton.Text = "Add New Part";
			this.addPartButton.UseVisualStyleBackColor = false;
			// 
			// partsLabel
			// 
			this.partsLabel.AutoSize = true;
			this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.partsLabel.Location = new System.Drawing.Point(3, 0);
			this.partsLabel.Name = "partsLabel";
			this.partsLabel.Size = new System.Drawing.Size(56, 24);
			this.partsLabel.TabIndex = 0;
			this.partsLabel.Text = "Parts";
			// 
			// productsPanel
			// 
			this.productsPanel.Controls.Add(this.flowLayoutPanel1);
			this.productsPanel.Controls.Add(this.productsDataGridView);
			this.productsPanel.Controls.Add(this.productsLabel);
			this.productsPanel.Location = new System.Drawing.Point(489, 3);
			this.productsPanel.Name = "productsPanel";
			this.productsPanel.Size = new System.Drawing.Size(480, 356);
			this.productsPanel.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.deleteProductButton);
			this.flowLayoutPanel1.Controls.Add(this.modifyProductButton);
			this.flowLayoutPanel1.Controls.Add(this.addProductButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 317);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 39);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// deleteProductButton
			// 
			this.deleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.deleteProductButton.FlatAppearance.BorderSize = 0;
			this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.deleteProductButton.Location = new System.Drawing.Point(377, 3);
			this.deleteProductButton.Name = "deleteProductButton";
			this.deleteProductButton.Size = new System.Drawing.Size(100, 32);
			this.deleteProductButton.TabIndex = 2;
			this.deleteProductButton.Text = "Delete";
			this.deleteProductButton.UseVisualStyleBackColor = false;
			// 
			// modifyProductButton
			// 
			this.modifyProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.modifyProductButton.FlatAppearance.BorderSize = 0;
			this.modifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modifyProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifyProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.modifyProductButton.Location = new System.Drawing.Point(221, 3);
			this.modifyProductButton.Name = "modifyProductButton";
			this.modifyProductButton.Size = new System.Drawing.Size(150, 32);
			this.modifyProductButton.TabIndex = 1;
			this.modifyProductButton.Text = "Modify Product";
			this.modifyProductButton.UseVisualStyleBackColor = false;
			// 
			// addProductButton
			// 
			this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.addProductButton.FlatAppearance.BorderSize = 0;
			this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.addProductButton.Location = new System.Drawing.Point(65, 3);
			this.addProductButton.Name = "addProductButton";
			this.addProductButton.Size = new System.Drawing.Size(150, 32);
			this.addProductButton.TabIndex = 0;
			this.addProductButton.Text = "Add New Product";
			this.addProductButton.UseVisualStyleBackColor = false;
			// 
			// productsDataGridView
			// 
			this.productsDataGridView.AllowUserToAddRows = false;
			this.productsDataGridView.AllowUserToDeleteRows = false;
			this.productsDataGridView.AllowUserToResizeColumns = false;
			this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.productsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.productsDataGridView.Location = new System.Drawing.Point(7, 28);
			this.productsDataGridView.Name = "productsDataGridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.productsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.productsDataGridView.Size = new System.Drawing.Size(470, 283);
			this.productsDataGridView.TabIndex = 1;
			// 
			// productsLabel
			// 
			this.productsLabel.AutoSize = true;
			this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.productsLabel.Location = new System.Drawing.Point(3, 0);
			this.productsLabel.Name = "productsLabel";
			this.productsLabel.Size = new System.Drawing.Size(92, 24);
			this.productsLabel.TabIndex = 0;
			this.productsLabel.Text = "Products";
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.exitButton.Location = new System.Drawing.Point(902, 9);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(90, 32);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// headerBar
			// 
			this.headerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(178)))));
			this.headerBar.Controls.Add(this.subtitleLabel);
			this.headerBar.Controls.Add(this.titleLabel);
			this.headerBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerBar.Location = new System.Drawing.Point(0, 0);
			this.headerBar.Name = "headerBar";
			this.headerBar.Size = new System.Drawing.Size(1004, 90);
			this.headerBar.TabIndex = 4;
			// 
			// subtitleLabel
			// 
			this.subtitleLabel.AutoSize = true;
			this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.subtitleLabel.ForeColor = System.Drawing.Color.White;
			this.subtitleLabel.Location = new System.Drawing.Point(11, 35);
			this.subtitleLabel.Name = "subtitleLabel";
			this.subtitleLabel.Size = new System.Drawing.Size(156, 31);
			this.subtitleLabel.TabIndex = 2;
			this.subtitleLabel.Text = "Dashboard";
			// 
			// windowActionsPanel
			// 
			this.windowActionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.windowActionsPanel.Controls.Add(this.exitButton);
			this.windowActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowActionsPanel.Location = new System.Drawing.Point(0, 492);
			this.windowActionsPanel.Name = "windowActionsPanel";
			this.windowActionsPanel.Size = new System.Drawing.Size(1004, 49);
			this.windowActionsPanel.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(1004, 541);
			this.Controls.Add(this.windowActionsPanel);
			this.Controls.Add(this.headerBar);
			this.Controls.Add(this.containerPanel);
			this.MinimumSize = new System.Drawing.Size(580, 580);
			this.Name = "MainForm";
			this.Opacity = 0.98D;
			this.Text = "Dashboard - FJBO Shelves";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.containerPanel.ResumeLayout(false);
			this.partsPanel.ResumeLayout(false);
			this.partsPanel.PerformLayout();
			this.partsButtonFlowLayoutPanel.ResumeLayout(false);
			this.productsPanel.ResumeLayout(false);
			this.productsPanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
			this.headerBar.ResumeLayout(false);
			this.headerBar.PerformLayout();
			this.windowActionsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.FlowLayoutPanel containerPanel;
		private System.Windows.Forms.Panel partsPanel;
		private System.Windows.Forms.Label partsLabel;
		private System.Windows.Forms.Panel productsPanel;
		private System.Windows.Forms.Label productsLabel;
		private System.Windows.Forms.DataGridView productsDataGridView;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.FlowLayoutPanel partsButtonFlowLayoutPanel;
		private System.Windows.Forms.Button modifyPartButton;
		private System.Windows.Forms.Button addPartButton;
		private System.Windows.Forms.Button deletePartButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button deleteProductButton;
		private System.Windows.Forms.Button modifyProductButton;
		private System.Windows.Forms.Button addProductButton;
		private System.Windows.Forms.ListView partsListView;
		private System.Windows.Forms.Panel headerBar;
		private System.Windows.Forms.Label subtitleLabel;
		private System.Windows.Forms.Panel windowActionsPanel;
		private System.Windows.Forms.ColumnHeader partsPartIdColumnHeader;
		private System.Windows.Forms.ColumnHeader partsPartNameColumnHeader;
		private System.Windows.Forms.ColumnHeader partsInStockColumnHeader;
		private System.Windows.Forms.ColumnHeader partsPriceColumnHeader;
	}
}

