namespace Shelves.GUI.Controls
{
	partial class SearchBox
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
			this.TextBox = new System.Windows.Forms.TextBox();
			this.SearchActionButton = new Shelves.GUI.Controls.ActionButton();
			this.SuspendLayout();
			// 
			// TextBox
			// 
			this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox.Location = new System.Drawing.Point(6, 0);
			this.TextBox.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(203, 24);
			this.TextBox.TabIndex = 1;
			// 
			// SearchActionButton
			// 
			this.SearchActionButton.AutoSize = true;
			this.SearchActionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SearchActionButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.SearchActionButton.FlatAppearance.BorderSize = 0;
			this.SearchActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SearchActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchActionButton.Location = new System.Drawing.Point(209, 0);
			this.SearchActionButton.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
			this.SearchActionButton.Name = "SearchActionButton";
			this.SearchActionButton.Size = new System.Drawing.Size(65, 28);
			this.SearchActionButton.TabIndex = 0;
			this.SearchActionButton.Text = "Search";
			this.SearchActionButton.UseVisualStyleBackColor = true;
			// 
			// SearchBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.SearchActionButton);
			this.Name = "SearchBox";
			this.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Size = new System.Drawing.Size(280, 28);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public ActionButton SearchActionButton;
		public System.Windows.Forms.TextBox TextBox;
	}
}
