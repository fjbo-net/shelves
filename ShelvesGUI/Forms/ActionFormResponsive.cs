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
