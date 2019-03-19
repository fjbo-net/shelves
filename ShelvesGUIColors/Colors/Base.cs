using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shelves.GUI.Colors;

namespace Shelves.GUI.Colors.PaletteCollection
{
    public class Base : ColorPalette
    {
        public Base()
        {
            PrimaryColor = Color.FromArgb(129, 45, 178);
            HeaderFormTitleTextColor = Neutral.White;
            HeaderAppTitleTextColor = Neutral.LightGray;
            PrimaryBackColor = Neutral.PaperWhite;
            SecondaryBackColor = Neutral.DullWhite;
            PrimaryTextColor = Neutral.EasyGray;
            SecondaryTextColorLight = Neutral.White;
            SecondaryColorDark = Neutral.DeepGray;
        }
    }
}
