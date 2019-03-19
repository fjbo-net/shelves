using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelves.GUI.Colors.PaletteCollection
{
    public class BaseDark: ColorPalette
    {
        public BaseDark()
        {
            PrimaryColor = Color.FromArgb(129, 45, 178);
            HeaderFormTitleTextColor = Neutral.White;
            HeaderAppTitleTextColor = Neutral.LightGray;
            PrimaryBackColor = Color.FromArgb(65, 65, 65);
            SecondaryBackColor = Color.FromArgb(40, 40, 40);
            PrimaryTextColor = Color.FromArgb(220, 220, 220);
            SecondaryTextColorLight = Color.FromArgb(255, 255, 255);
            SecondaryColorDark = Color.FromArgb(40, 40, 40);
        }
    }
}
