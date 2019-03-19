using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelves.GUI.Controls
{
    public partial class HeadingLabel : Label
    {
        public HeadingLabel()
        {
            InitializeComponent();
            if(Parent != null) ForeColor = Parent.ForeColor;
        }
    }
}
