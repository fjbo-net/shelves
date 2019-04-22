namespace Shelves.GUI.Forms
{
    partial class BaseForm
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
			this.headerPanel = new System.Windows.Forms.Panel();
			this.formTitleLabel = new System.Windows.Forms.Label();
			this.AppTitleLabel = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.headerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.formTitleLabel);
			this.headerPanel.Controls.Add(this.AppTitleLabel);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(800, 90);
			this.headerPanel.TabIndex = 0;
			// 
			// formTitleLabel
			// 
			this.formTitleLabel.AutoSize = true;
			this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.formTitleLabel.Location = new System.Drawing.Point(11, 35);
			this.formTitleLabel.Name = "formTitleLabel";
			this.formTitleLabel.Size = new System.Drawing.Size(85, 31);
			this.formTitleLabel.TabIndex = 1;
			this.formTitleLabel.Text = "Label";
			// 
			// AppTitleLabel
			// 
			this.AppTitleLabel.AutoSize = true;
			this.AppTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.AppTitleLabel.Location = new System.Drawing.Point(12, 9);
			this.AppTitleLabel.Name = "AppTitleLabel";
			this.AppTitleLabel.Size = new System.Drawing.Size(454, 26);
			this.AppTitleLabel.TabIndex = 0;
			this.AppTitleLabel.Text = "FJBO Selves: Inventory Management System";
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.mainPanel.Location = new System.Drawing.Point(0, 90);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(800, 451);
			this.mainPanel.TabIndex = 1;
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(800, 541);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.headerPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(580, 580);
			this.Name = "BaseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BaseForm";
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel headerPanel;
        protected System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.Label formTitleLabel;
    }
}