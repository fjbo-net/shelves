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
			this.ActionsPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ActionsPanel
			// 
			this.ActionsPanel.Controls.Add(this.SaveActionButton);
			this.ActionsPanel.Controls.Add(this.ResetActionButton);
			this.ActionsPanel.Controls.SetChildIndex(this.CloseButton, 0);
			this.ActionsPanel.Controls.SetChildIndex(this.ResetActionButton, 0);
			this.ActionsPanel.Controls.SetChildIndex(this.SaveActionButton, 0);
			// 
			// CloseButton
			// 
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.FlatAppearance.BorderSize = 0;
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.ProductDataPanel);
			this.mainPanel.Controls.SetChildIndex(this.ActionsPanel, 0);
			this.mainPanel.Controls.SetChildIndex(this.ProductDataPanel, 0);
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
			this.SaveActionButton.Location = new System.Drawing.Point(668, 8);
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
			this.ProductDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProductDataPanel.Location = new System.Drawing.Point(0, 0);
			this.ProductDataPanel.Margin = new System.Windows.Forms.Padding(6);
			this.ProductDataPanel.Name = "ProductDataPanel";
			this.ProductDataPanel.Size = new System.Drawing.Size(800, 401);
			this.ProductDataPanel.TabIndex = 1;
			// 
			// ProductForm
			// 
			this.AcceptButton = this.SaveActionButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(800, 541);
			this.Name = "ProductForm";
			this.Text = "ProductForm";
			this.ActionsPanel.ResumeLayout(false);
			this.ActionsPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ProductDataPanel ProductDataPanel;
		private Shelves.GUI.Controls.ActionButton ResetActionButton;
		private Shelves.GUI.Controls.ActionButton SaveActionButton;
	}
}