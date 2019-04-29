namespace Shelves.App.Common.GUI.Forms
{
	partial class PartForm
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
			this.SaveActionButton = new Shelves.GUI.Controls.ActionButton();
			this.ResetActionButton = new Shelves.GUI.Controls.ActionButton();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.InHousePage = new System.Windows.Forms.TabPage();
			this.inHousePartDataPanel1 = new Shelves.App.Common.GUI.Controls.InHousePartDataPanel();
			this.OutsourcedTab = new System.Windows.Forms.TabPage();
			this.OutsourcedDataPanel = new Shelves.App.Common.GUI.Controls.OutsourcedDataPanel();
			this.ActionsPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.InHousePage.SuspendLayout();
			this.OutsourcedTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// ActionsPanel
			// 
			this.ActionsPanel.Controls.Add(this.ResetActionButton);
			this.ActionsPanel.Controls.Add(this.SaveActionButton);
			this.ActionsPanel.Controls.SetChildIndex(this.CloseButton, 0);
			this.ActionsPanel.Controls.SetChildIndex(this.SaveActionButton, 0);
			this.ActionsPanel.Controls.SetChildIndex(this.ResetActionButton, 0);
			// 
			// CloseButton
			// 
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.FlatAppearance.BorderSize = 0;
			this.CloseButton.Location = new System.Drawing.Point(720, 8);
			this.CloseButton.Size = new System.Drawing.Size(68, 30);
			this.CloseButton.Text = "Cancel";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.TabControl);
			this.mainPanel.Controls.SetChildIndex(this.ActionsPanel, 0);
			this.mainPanel.Controls.SetChildIndex(this.TabControl, 0);
			// 
			// SaveActionButton
			// 
			this.SaveActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveActionButton.AutoSize = true;
			this.SaveActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SaveActionButton.FlatAppearance.BorderSize = 0;
			this.SaveActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveActionButton.Location = new System.Drawing.Point(659, 8);
			this.SaveActionButton.Name = "SaveActionButton";
			this.SaveActionButton.Size = new System.Drawing.Size(55, 30);
			this.SaveActionButton.TabIndex = 1;
			this.SaveActionButton.Text = "Save";
			this.SaveActionButton.UseVisualStyleBackColor = true;
			this.SaveActionButton.Click += new System.EventHandler(this.SaveActionButton_Click);
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
			this.ResetActionButton.TabIndex = 2;
			this.ResetActionButton.Text = "Reset";
			this.ResetActionButton.UseVisualStyleBackColor = true;
			this.ResetActionButton.Click += new System.EventHandler(this.ResetActionButton_Click);
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.InHousePage);
			this.TabControl.Controls.Add(this.OutsourcedTab);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(800, 401);
			this.TabControl.TabIndex = 2;
			// 
			// InHousePage
			// 
			this.InHousePage.Controls.Add(this.inHousePartDataPanel1);
			this.InHousePage.Location = new System.Drawing.Point(4, 27);
			this.InHousePage.Name = "InHousePage";
			this.InHousePage.Padding = new System.Windows.Forms.Padding(3);
			this.InHousePage.Size = new System.Drawing.Size(792, 370);
			this.InHousePage.TabIndex = 0;
			this.InHousePage.Text = "In-House";
			this.InHousePage.UseVisualStyleBackColor = true;
			// 
			// inHousePartDataPanel1
			// 
			this.inHousePartDataPanel1.BackColor = System.Drawing.Color.Transparent;
			this.inHousePartDataPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inHousePartDataPanel1.Location = new System.Drawing.Point(3, 3);
			this.inHousePartDataPanel1.Margin = new System.Windows.Forms.Padding(21, 15, 21, 15);
			this.inHousePartDataPanel1.Name = "inHousePartDataPanel1";
			this.inHousePartDataPanel1.Size = new System.Drawing.Size(786, 364);
			this.inHousePartDataPanel1.TabIndex = 1;
			// 
			// OutsourcedTab
			// 
			this.OutsourcedTab.Controls.Add(this.OutsourcedDataPanel);
			this.OutsourcedTab.Location = new System.Drawing.Point(4, 27);
			this.OutsourcedTab.Name = "OutsourcedTab";
			this.OutsourcedTab.Padding = new System.Windows.Forms.Padding(3);
			this.OutsourcedTab.Size = new System.Drawing.Size(792, 370);
			this.OutsourcedTab.TabIndex = 1;
			this.OutsourcedTab.Text = "Outsourced";
			this.OutsourcedTab.UseVisualStyleBackColor = true;
			// 
			// OutsourcedDataPanel
			// 
			this.OutsourcedDataPanel.BackColor = System.Drawing.Color.Transparent;
			this.OutsourcedDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutsourcedDataPanel.Location = new System.Drawing.Point(3, 3);
			this.OutsourcedDataPanel.Margin = new System.Windows.Forms.Padding(4);
			this.OutsourcedDataPanel.Name = "OutsourcedDataPanel";
			this.OutsourcedDataPanel.Size = new System.Drawing.Size(786, 364);
			this.OutsourcedDataPanel.TabIndex = 0;
			// 
			// PartForm
			// 
			this.AcceptButton = this.SaveActionButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(800, 541);
			this.Name = "PartForm";
			this.Text = "PartForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartForm_FormClosing);
			this.ActionsPanel.ResumeLayout(false);
			this.ActionsPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.TabControl.ResumeLayout(false);
			this.InHousePage.ResumeLayout(false);
			this.OutsourcedTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Shelves.App.Common.GUI.Controls.InHousePartDataPanel inHousePartDataPanel1;
		private Shelves.GUI.Controls.ActionButton SaveActionButton;
		private Shelves.GUI.Controls.ActionButton ResetActionButton;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage InHousePage;
		private System.Windows.Forms.TabPage OutsourcedTab;
		private Controls.OutsourcedDataPanel OutsourcedDataPanel;
	}
}