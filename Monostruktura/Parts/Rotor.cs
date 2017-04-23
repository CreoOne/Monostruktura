﻿using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Windows.Forms;
using Monostruktura.Panels;

namespace Monostruktura.Parts
{
    public class Rotor : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count : 0; } }

        public int Count { get; set; }

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            float step = (float)Math.PI / (Count * 0.5f);

            foreach (int sign in Enumerable.Range(-Count / 2, Count))
            {
                if (Child != null)
                    Child.Draw(context, position, direction + (sign * step));
            }
        }

        public override void Randomize(Random rand)
        {
            Count = rand.Next(2, 7);
        }

        public override Control CreatePanel()
        {
            return new RotorPanel(this);
        }

        public override void SetChild(IPart child, int slot)
        {
            Child = child;
            Child.Parent = this;
        }
    }
}
