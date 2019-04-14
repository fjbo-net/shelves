﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.BusinessLayer.Parts;
using Shelves.BusinessLayer.Parts.Abstract;
using Shelves.GUI.Forms;
using Shelves.GUI.Colors;

namespace Shelves.App.Common.GUI.Forms
{
	public partial class PartForm : ActionForm
	{
		public PartForm()
		{
			InitializeComponent();
			Init();
		}

		private bool _canSwitchPartType = true;
		public bool CanSwitchPartType
		{
			get => _canSwitchPartType;
			set {
				if (value)
				{
					foreach (TabPage page in TabControl.TabPages) page.Enabled = true;
				}
				else {
					foreach (TabPage page in TabControl.TabPages) page.Enabled = false;
					TabControl.TabPages[TabControl.SelectedIndex].Enabled = true;
				}
				_canSwitchPartType = value;
			}
		}

		public enum PartTab
		{
			Inhouse = 0,
			Outsourced = 1
		}

		public Part Part {
			get {
				return (TabControl.SelectedIndex == (int)PartTab.Inhouse) ? (Part)inHousePartDataPanel1.Part : OutsourcedDataPanel.Part;
			}
			set
			{
				if (value is Inhouse)
				{
					inHousePartDataPanel1.Part = (Inhouse)value;
					TabControl.SelectedTab = InHousePage;
				}
				else if (value is Outsourced)
				{
					OutsourcedDataPanel.Part = (Outsourced)value;
					TabControl.SelectedTab = OutsourcedTab;
				}
				else return;
			}
		}


		protected override void Init()
		{
			base.Init();
			if (SaveActionButton != null)
			{
				SaveActionButton.BackColor = Neutral.White;
				SaveActionButton.ForeColor = Neutral.DeepGray;
			}
		}

		public void Reset()
		{
			inHousePartDataPanel1.Reset();
			OutsourcedDataPanel.Reset();
		}


		protected override void CloseButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Reset();
			CanSwitchPartType = true;
			this.Hide();
		}

		private void ResetActionButton_Click(object sender, EventArgs e) => Reset();

		private void SaveActionButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			CanSwitchPartType = true;
			this.Hide();
		}
	}
}
