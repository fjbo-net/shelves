using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.GUI.Controls.Entities;
using Shelves.GUI.Controls.Interfaces;
using Shelves.GUI.Controls.Helpers;

namespace Shelves.GUI.Forms
{
	public partial class ActionFormResponsive : ActionForm, IResponsive
	{
		#region Constructora
		public ActionFormResponsive()
		{
			InitializeComponent();
			Init();
		}
		#endregion

		#region Mathods
		protected static int GetVerticalPadding(Control control)
			=> control.Padding.Left + control.Padding.Right;
		protected static int GetHorizontalPadding(Control control)
			=> control.Padding.Top + control.Padding.Bottom;
		protected static int GetVerticalMargin(Control control)
			=> control.Margin.Left + control.Padding.Right;
		protected static int GetHorizontalMargin(Control control)
			=> control.Margin.Top + control.Padding.Bottom;


		public virtual List<DynamicResizableControl> DynamicResizables { get; set; } = new List<DynamicResizableControl>();

		public virtual void DefineDynamicResizables()
		{
			throw new NotImplementedException();
		}

		public virtual void FitComponents()
		{
			throw new NotImplementedException();
		}

		public virtual void FitComponentsToFull() => Responsive.FitComponentsToFull(this, DynamicResizables);

		public virtual void FitComponentsToMedium() => Responsive.FitComponentsToMedium(this, DynamicResizables);

		public virtual void FitComponentsToSmall() => Responsive.FitComponentsToSmall(this, DynamicResizables);

		#region Event Handlers
		public void ParentControl_Resize(object sender, EventArgs e) => FitComponents();
		#endregion
		#endregion
	}
}
