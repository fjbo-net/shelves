using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.GUI.Controls.Entities;

namespace Shelves.GUI.Controls.Helpers
{
	public static class Responsive
	{
		public static void FitComponentsToFull(Form control, List<DynamicResizableControl> dynamicResizables)
		{
			foreach (DynamicResizableControl resizable in dynamicResizables) resizable.Fit(control.Width, control.Height);
		}

		public static void FitComponentsToMedium(Form control, List<DynamicResizableControl> dynamicResizables)
		{
			foreach (DynamicResizableControl resizable in dynamicResizables) resizable.Fit(control.Width, control.Height, SizeMode.Medium);
		}

		public static void FitComponentsToSmall(Form control, List<DynamicResizableControl> dynamicResizables)
		{
			foreach (DynamicResizableControl resizable in dynamicResizables) resizable.Fit(control.Width, control.Height, SizeMode.Small);
		}
	}
}
