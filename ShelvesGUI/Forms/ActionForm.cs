﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.GUI.Colors;

namespace Shelves.GUI.Forms
{
    public partial class ActionForm : BaseForm
    {
        public ActionForm() => ActionFormInit();

        public override void ApplyColorPalette(ColorPalette palette)
        {
            base.ApplyColorPalette(palette);
            //Prevents errors on parent class initialization
            if (CloseButton != null)
            {
                CloseButton.BackColor = Colors.Actions.RED;
                CloseButton.ForeColor = Colors.Neutral.PaperWhite;
            }

            if (ActionsPanel != null)
            {
                ActionsPanel.BackColor = palette.SecondaryBackColor;
            }
        }

        private void ActionFormInit()
        {
            InitializeComponent();
            Init();
            ApplyColorPalette();
        }

		protected virtual void CloseButton_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show(
				"Are you sure that you want to close this window? Any changes will be lost.\nPress 'Yes' to close or 'No' to cancel.",
				$"{Title} is about to close",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Exclamation);
			if(result == DialogResult.Yes) Close();
		}
    }
}
