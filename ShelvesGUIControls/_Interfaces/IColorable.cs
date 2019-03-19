using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shelves.GUI.Colors;

namespace Shelves.GUI.Controls.Interfaces
{
    public interface IColorable
    {
        void ApplyColorPalette(Colors.ColorPalette palette);
        void ApplyColorPalette();
    }
}
