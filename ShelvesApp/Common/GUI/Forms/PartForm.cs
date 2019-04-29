using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.BusinessLayer.Entities;
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
				if(CanSwitchPartType)
				{
					return GetPartByTabPage(TabControl.SelectedTab);
				} else
				{
					foreach(TabPage page in TabControl.TabPages)
					{
						if (page.Enabled) return GetPartByTabPage(page);
					}
					return inHousePartDataPanel1.Part;
				}
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

		private Part GetPartByTabPage(TabPage page)
		{
			switch(TabControl.TabPages.IndexOf(page))
			{
				case (int)PartTab.Outsourced:
					return OutsourcedDataPanel.Part;
				case (int)PartTab.Inhouse:
					return inHousePartDataPanel1.Part;
				default:
					return new Inhouse();
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

		public void ResetGui()
		{
			inHousePartDataPanel1.ResetGui();
			OutsourcedDataPanel.ResetGui();
		}
		
		public new ValidationResult Validate() {
			int partTab = -1;

			if (CanSwitchPartType)
			{
				partTab = TabControl.SelectedIndex;
			}
			else
			{
				foreach (TabPage page in TabControl.TabPages)
				{
					if (page.Enabled) partTab = TabControl.TabPages.IndexOf(page);
				}
			}

			switch (partTab)
			{
				case (int)PartTab.Outsourced:
					return OutsourcedDataPanel.Validate();
				case (int)PartTab.Inhouse:
					return inHousePartDataPanel1.Validate();
				default:
					return new ValidationResult(false, new List<string> { "Unkown DataPanel to validate." });
			}
		}


		protected override void CloseButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Are you sure that you want to close this window? Any changes will be lost.\nPress 'Yes' to close or 'No' to cancel.",
				$"{Title} is about to close...",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Exclamation);

			if (result == DialogResult.No)
			{
				DialogResult = DialogResult.None;
				return;
			}

			DialogResult = DialogResult.Cancel;
			Reset();
			CanSwitchPartType = true;
			this.Hide();
		}

		private void ResetActionButton_Click(object sender, EventArgs e) => ResetGui();

		private void SaveActionButton_Click(object sender, EventArgs e)
		{
			ValidationResult result = Validate();

			if (result.IsValid)
			{
				DialogResult = DialogResult.OK;
				this.Hide();
			} else
			{
				MessageBox.Show(result.ErrorMessagesAsString(),
					$"{this.Title}: Invalid data",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void PartForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.None) e.Cancel = true;
		}
	}
}
