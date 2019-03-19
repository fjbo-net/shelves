using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelves.GUI.Controls.Entities
{
    public class DynamicResizableControl
    {
        private List<ResizingRule> ResizingRules = new List<ResizingRule>();
        public readonly DefaultDimensionsForDynamicResizable Defaults;
        public Control Control;

        public DynamicResizableControl(Control control, Control reference)
        {
            Control = control;
            Defaults.Width = control.Width;
            Defaults.Height = control.Height;
            Defaults.WidthRatio = (double) control.Width / reference.Width;
            Defaults.HeightRatio = (double) control.Height / reference.Height;
        }


        public void AddResizingRule(Dimension dimension, Func<int, int> rule, SizeMode sizeMode = SizeMode.Full)
        {
            ResizingRule newRule = new ResizingRule(dimension, rule, sizeMode);
            if(ResizingRules.Count(r => r.Dimension == dimension && r.SizeMode == sizeMode) == 0) ResizingRules.Add(newRule);
        }

        public void Reset()
        {
            Control.Width = Defaults.Width;
            Control.Height = Defaults.Height;
        }

        public void Fit(int referenceWidth, int referenceHeight, SizeMode sizeMode = SizeMode.Full)
        {
            FitWidth(referenceWidth, sizeMode);
            FitHeight(referenceHeight, sizeMode);
        }

        public void FitWidth(int referenceWidth, SizeMode sizeMode = SizeMode.Full)
        {
            foreach (ResizingRule currentRule in ResizingRules.Where(rule =>
                rule.SizeMode == sizeMode && rule.Dimension == Dimension.Width))
            {
                Control.Size = new System.Drawing.Size(currentRule.Rule(referenceWidth), Control.Bounds.Height);
            }
        }

        public void FitHeight(int referenceHeight, SizeMode sizeMode = SizeMode.Full)
        {
            foreach (ResizingRule currentRule in ResizingRules.Where(rule => rule.SizeMode == sizeMode && rule.Dimension == Dimension.Height)) Control.Height = currentRule.Rule(referenceHeight);
        }
    }

    public struct DefaultDimensionsForDynamicResizable
    {
        public int Width, Height;
        public double WidthRatio, HeightRatio;
    }

    internal struct ResizingRule
    {
        public SizeMode SizeMode { get; }
        public Dimension Dimension { get; }
        public Func<int, int> Rule { get; }

        public ResizingRule(Dimension dimension, Func<int, int> rule, SizeMode sizeMode = SizeMode.Full)
        {
            Dimension = dimension;
            SizeMode = sizeMode;
            Rule = rule;
        }
    }

    public enum SizeMode { Small, Medium, Full };
    public enum Dimension { Width, Height };
}
