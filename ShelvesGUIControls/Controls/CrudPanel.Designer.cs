namespace Shelves.GUI.Controls
{
    partial class CrudPanel
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
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.ContentPanel = new System.Windows.Forms.Panel();
			this.ListView = new System.Windows.Forms.ListView();
			this.ActionsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.DeleteActionButton = new Shelves.GUI.Controls.ActionButton();
			this.EditActionButton = new Shelves.GUI.Controls.ActionButton();
			this.AddActionButton = new Shelves.GUI.Controls.ActionButton();
			this.HeadingLabel = new Shelves.GUI.Controls.HeadingLabel();
			this.HeaderPanel.SuspendLayout();
			this.ContentPanel.SuspendLayout();
			this.ActionsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HeaderPanel.Controls.Add(this.HeadingLabel);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(480, 32);
			this.HeaderPanel.TabIndex = 0;
			// 
			// ContentPanel
			// 
			this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ContentPanel.Controls.Add(this.ListView);
			this.ContentPanel.Controls.Add(this.ActionsPanel);
			this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentPanel.Location = new System.Drawing.Point(0, 32);
			this.ContentPanel.Name = "ContentPanel";
			this.ContentPanel.Size = new System.Drawing.Size(480, 368);
			this.ContentPanel.TabIndex = 1;
			// 
			// ListView
			// 
			this.ListView.AutoArrange = false;
			this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListView.FullRowSelect = true;
			this.ListView.GridLines = true;
			this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView.HideSelection = false;
			this.ListView.Location = new System.Drawing.Point(0, 0);
			this.ListView.MultiSelect = false;
			this.ListView.Name = "ListView";
			this.ListView.Size = new System.Drawing.Size(480, 318);
			this.ListView.TabIndex = 1;
			this.ListView.UseCompatibleStateImageBehavior = false;
			this.ListView.View = System.Windows.Forms.View.Details;
			// 
			// ActionsPanel
			// 
			this.ActionsPanel.Controls.Add(this.DeleteActionButton);
			this.ActionsPanel.Controls.Add(this.EditActionButton);
			this.ActionsPanel.Controls.Add(this.AddActionButton);
			this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ActionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.ActionsPanel.Location = new System.Drawing.Point(0, 318);
			this.ActionsPanel.Name = "ActionsPanel";
			this.ActionsPanel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
			this.ActionsPanel.Size = new System.Drawing.Size(480, 50);
			this.ActionsPanel.TabIndex = 0;
			// 
			// DeleteActionButton
			// 
			this.DeleteActionButton.AutoSize = true;
			this.DeleteActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DeleteActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.DeleteActionButton.Enabled = false;
			this.DeleteActionButton.FlatAppearance.BorderSize = 0;
			this.DeleteActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteActionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.DeleteActionButton.Location = new System.Drawing.Point(411, 9);
			this.DeleteActionButton.Name = "DeleteActionButton";
			this.DeleteActionButton.Size = new System.Drawing.Size(66, 28);
			this.DeleteActionButton.TabIndex = 2;
			this.DeleteActionButton.Text = "Delete";
			this.DeleteActionButton.UseVisualStyleBackColor = false;
			this.DeleteActionButton.Click += new System.EventHandler(this.DeleteActionButton_Click);
			// 
			// EditActionButton
			// 
			this.EditActionButton.AutoSize = true;
			this.EditActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.EditActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.EditActionButton.Enabled = false;
			this.EditActionButton.FlatAppearance.BorderSize = 0;
			this.EditActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditActionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.EditActionButton.Location = new System.Drawing.Point(358, 9);
			this.EditActionButton.Name = "EditActionButton";
			this.EditActionButton.Size = new System.Drawing.Size(47, 28);
			this.EditActionButton.TabIndex = 1;
			this.EditActionButton.Text = "Edit";
			this.EditActionButton.UseVisualStyleBackColor = false;
			this.EditActionButton.Click += new System.EventHandler(this.EditActionButton_Click);
			// 
			// AddActionButton
			// 
			this.AddActionButton.AutoSize = true;
			this.AddActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.AddActionButton.Enabled = false;
			this.AddActionButton.FlatAppearance.BorderSize = 0;
			this.AddActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddActionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.AddActionButton.Location = new System.Drawing.Point(306, 9);
			this.AddActionButton.Name = "AddActionButton";
			this.AddActionButton.Size = new System.Drawing.Size(46, 28);
			this.AddActionButton.TabIndex = 0;
			this.AddActionButton.Text = "Add";
			this.AddActionButton.UseVisualStyleBackColor = false;
			this.AddActionButton.Click += new System.EventHandler(this.AddActionButton_Click);
			// 
			// HeadingLabel
			// 
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.HeadingLabel.Location = new System.Drawing.Point(-5, 0);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new System.Drawing.Size(133, 25);
			this.HeadingLabel.TabIndex = 0;
			this.HeadingLabel.Text = "CRUD Panel";
			// 
			// CrudPanel
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.ContentPanel);
			this.Controls.Add(this.HeaderPanel);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.Name = "CrudPanel";
			this.Size = new System.Drawing.Size(480, 400);
			this.Resize += new System.EventHandler(this.CrudPanel_Resize);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ContentPanel.ResumeLayout(false);
			this.ActionsPanel.ResumeLayout(false);
			this.ActionsPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel HeaderPanel;
        protected System.Windows.Forms.Panel ContentPanel;
        protected System.Windows.Forms.FlowLayoutPanel ActionsPanel;
        protected HeadingLabel HeadingLabel;
        protected ActionButton AddActionButton;
        protected ActionButton EditActionButton;
        protected ActionButton DeleteActionButton;
		protected System.Windows.Forms.ListView ListView;
	}
}
