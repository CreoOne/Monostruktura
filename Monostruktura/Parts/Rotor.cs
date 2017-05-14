﻿using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Windows.Forms;
using Monostruktura.Parameters;

namespace Monostruktura.Parts
{
    public class Rotor : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count.Value : 0; } }

        public readonly IntParameter Count = new IntParameter("Count", 2, 7);

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            float step = (float)Math.PI / (Count.Value * 0.5f);

            foreach (int sign in Enumerable.Range(-Count.Value / 2, Count.Value))
            {
                if (Child != null)
                    Child.Draw(context, position, direction + (sign * step));
            }
        }

        public override void Randomize(Random rand)
        {
            Count.Randomize(rand);
        }

        public override Control CreatePanel()
        {
            return PanelGeneratorHelper(new IParameter[] { Count });
        }

        public override void SetChild(IPart child, int slot)
        {
            Child = child;

            if(Child != null)
                Child.Parent = this;
        }
    }
}
