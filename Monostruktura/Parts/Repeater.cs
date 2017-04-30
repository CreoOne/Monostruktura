using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Windows.Forms;
using Monostruktura.Parameters;

namespace Monostruktura.Parts
{
    public class Repeater : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count.Value : 0; } }

        public readonly FloatParameter Direction = new FloatParameter("Direction", -0.5f, 0.5f);
        public readonly IntParameter Count = new IntParameter("Count", 2, 16);
        public readonly IntParameter Space = new IntParameter("Space", 10, 80);

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            double phi = Direction.Value + direction + Math.PI * 0.5f;
            Vector2 offset = new Vector2((float)Math.Cos(phi), (float)Math.Sin(phi));

            foreach (int sign in Enumerable.Range(-Count.Value / 2, Count.Value))
            {
                if (Child != null)
                    Child.Draw(context, position + sign * offset * Space.Value, direction);
            }
        }

        public override void Randomize(Random rand)
        {
            Direction.Randomize(rand);
            Count.Randomize(rand);
            Space.Randomize(rand);
        }

        public override Control CreatePanel()
        { 
            return PanelGeneratorHelper(new IParameter[] { Direction, Count, Space });
        }

        public override void SetChild(IPart child, int slot)
        {
            Child = child;
            Child.Parent = this;
        }
    }
}
