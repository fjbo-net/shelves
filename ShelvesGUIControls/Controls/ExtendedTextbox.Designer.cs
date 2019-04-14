namespace Shelves.GUI.Controls.Controls
{
	partial class ExtendedTextbox
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
			this._label = new System.Windows.Forms.Label();
			this._textbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _label
			// 
			this._label.Dock = System.Windows.Forms.DockStyle.Left;
			this._label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._label.Location = new System.Drawing.Point(0, 0);
			this._label.MaximumSize = new System.Drawing.Size(150, 20);
			this._label.Name = "_label";
			this._label.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this._label.Size = new System.Drawing.Size(150, 20);
			this._label.TabIndex = 0;
			this._label.Text = "label1";
			this._label.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _textbox
			// 
			this._textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._textbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._textbox.Location = new System.Drawing.Point(150, 0);
			this._textbox.Name = "_textbox";
			this._textbox.Size = new System.Drawing.Size(250, 17);
			this._textbox.TabIndex = 1;
			// 
			// ExtendedTextbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this._textbox);
			this.Controls.Add(this._label);
			this.Name = "ExtendedTextbox";
			this.Size = new System.Drawing.Size(400, 20);
			this.Load += new System.EventHandler(this.ExtendedTextbox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _label;
		private System.Windows.Forms.TextBox _textbox;
	}
}
