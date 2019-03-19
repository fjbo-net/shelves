using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shelves.GUI.Controls.Entities;

namespace Shelves.GUI.Controls.Interfaces
{
	public interface IResponsive
	{
		List<DynamicResizableControl> DynamicResizables { get; set; }
		void DefineDynamicResizables();
		void FitComponents();
		void FitComponentsToFull();
		void FitComponentsToMedium();
		void FitComponentsToSmall();
		void ParentControl_Resize(object sender, EventArgs e);
	}
}
