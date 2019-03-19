using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using Shelves.GUI.Colors.Entitites;

namespace Shelves.GUI.Colors
{
    public abstract class ColorPalette
    {
        public Color PrimaryColor
        {
            get => AllColors[ColorType.PrimaryColor];
            set => AllColors.Add(ColorType.PrimaryColor, value);
        }

        public Color SecondaryColorLight
        {
            get => AllColors[ColorType.SecondaryColorLight];
            set => AllColors[ColorType.SecondaryColorLight] = value;
        }

        public Color SecondaryColorDark
        {
            get => AllColors[ColorType.SecondaryColorDark];
            set => AllColors[ColorType.SecondaryColorDark] = value;
        }

        public Color PrimaryBackColor
        {
            get => AllColors[ColorType.PrimaryBackColor];
            set => AllColors[ColorType.PrimaryBackColor] = value;
        }

        public Color SecondaryBackColor
        {
            get => AllColors[ColorType.SecondaryBackColor];
            set => AllColors[ColorType.SecondaryBackColor] = value;
        }

        public Color PrimaryTextColor
        {
            get => AllColors[ColorType.PrimaryTextColor];
            set => AllColors[ColorType.PrimaryTextColor] = value;
        }

        public Color SecondaryTextColorDark
        {
            get => AllColors[ColorType.SecondaryTextColorDark];
            set => AllColors[ColorType.SecondaryTextColorDark] = value;
        }

        public Color SecondaryTextColorLight
        {
            get => AllColors[ColorType.SecondaryTextColorLight];
            set => AllColors[ColorType.SecondaryTextColorLight] = value;
        }

        public Color TertiaryTextColorLight
        {
            get => AllColors[ColorType.TertiaryTextColorLight];
            set => AllColors[ColorType.TertiaryTextColorLight] = value;
        }

        public Color TertiaryTextColorDark
        {
            get => AllColors[ColorType.TertiaryTextColorDark];
            set => AllColors[ColorType.TertiaryTextColorDark] = value;
        }

        public Color TertiaryColorLight
        {
            get => AllColors[ColorType.TertiaryColorLight];
            set => AllColors[ColorType.TertiaryColorLight] = value;
        }

        public Color TertiaryColorDark
        {
            get => AllColors[ColorType.TertiaryColorDark];
            set => AllColors[ColorType.TertiaryColorDark] = value;
        }

        public Color HeaderBackColor
        {
            get => AllColors[ColorType.HeaderBackColor];
            set => AllColors[ColorType.HeaderBackColor] = value;
        }

        public Color HeaderAppTitleTextColor
        {
            get => AllColors[ColorType.HeaderAppTitleTextColor];
            set => AllColors[ColorType.HeaderAppTitleTextColor] = value;
        }

        public Color HeaderFormTitleTextColor
        {
            get => AllColors[ColorType.HeaderFormTitleTextColor];
            set => AllColors[ColorType.HeaderFormTitleTextColor] = value;
        }

        public Dictionary<string, Color> AllColors { get; private set; } = new Dictionary<string, Color>();
    }
}
