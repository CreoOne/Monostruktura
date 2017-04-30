using System.Drawing;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Monostruktura.Parameters;
using System.Linq;

namespace Monostruktura.Parts
{
    public abstract class PartAbstract : IPart
    {
        public IPart Parent { get; set; }
        public abstract IEnumerable<IPart> Childs { get; }
        public abstract void SetChild(IPart child, int slot);

        public int Depth { get { return Parent != null ? Parent.Depth + 1 : 0; } }
        public abstract double Cost { get; }

        public abstract void Draw(Graphics context, Vector2 position, float direction);
        public abstract void Randomize(Random rand);
        public abstract Control CreatePanel();

        protected Control PanelGeneratorHelper(IParameter[] parameters)
        {
            Panel result = new Panel() { Width = 100 };
            int position = 0;

            foreach (int index in Enumerable.Range(0, parameters.Count()))
            {
                Control paramControl = parameters[index].GetControl();
                paramControl.Top = position;
                paramControl.Width = result.Width;
                paramControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                result.Controls.Add(paramControl);
                position += paramControl.Height;
            }

            return result;
        }
    }
}
