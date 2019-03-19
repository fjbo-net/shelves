using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelves.GUI.Controls
{
    public partial class ActionButton : Button
    {
        public ActionButton()
        {
            InitializeComponent();
        }
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                if (string.IsNullOrEmpty(DefaultText) && !string.IsNullOrEmpty(value)) DefaultText = value;
            }
        }

        #region Properties

        public string DefaultText { get; private set; } = string.Empty;
        #endregion
    }
}
