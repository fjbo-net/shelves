using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shelves.GUI;
using Shelves.GUI.Controls;
using Shelves.GUI.Controls.Interfaces;
using Color = System.Drawing.Color;

namespace Shelves.GUI.Forms
{
    public partial class BaseForm : Form, IColorable
    {
        #region Properties

        public string AppTitle => AppTitleLabel.Text;

        protected string Title
        {
            get => formTitleLabel.Text;
            set => formTitleLabel.Text = value;
        }

		protected Colors.ColorPalette ColorPalette { get; private set; }
        #endregion

        #region Constructors

        public BaseForm() => BaseInit();

        public BaseForm(string title) : this() => Title = title;
		#endregion

		#region Methods

		public virtual void ApplyColorPalette(Colors.ColorPalette palette)
        {
            if (palette == null) return;
            BackColor = palette.PrimaryBackColor;
            ForeColor = palette.PrimaryTextColor;

            mainPanel.BackColor = BackColor;
            mainPanel.ForeColor = palette.PrimaryTextColor;

            headerPanel.BackColor = palette.PrimaryColor;
            headerPanel.ForeColor = palette.SecondaryBackColor;

            formTitleLabel.ForeColor = palette.HeaderFormTitleTextColor;
            AppTitleLabel.ForeColor = palette.HeaderAppTitleTextColor;

            ColorPalette = palette;
        }

        public virtual void ApplyColorPalette() => ApplyColorPalette(ColorPalette);

        private void BaseInit()
        {
            InitializeComponent();
            ApplyColorPalette(new Colors.PaletteCollection.BaseDark());
            Init();
        }

        protected virtual void Init() => Title = Text;

        #endregion
    }
}
