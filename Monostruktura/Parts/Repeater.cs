using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Monostruktura.PartsFactory;
using System.Collections.Generic;
using System.Windows.Forms;
using Monostruktura.Panels;

namespace Monostruktura.Parts
{
    public class Repeater : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count : 0; } }

        public int Count { get; set; }
        public int Space { get; set; }
        public double Direction { get; set; }

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public Repeater(IPartFactory factory, IPart parent)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Parent = parent;
            Child = factory.Create(this);
        }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            double phi = Direction + direction + Math.PI * 0.5f;
            Vector2 offset = new Vector2((float)Math.Cos(phi), (float)Math.Sin(phi));

            foreach (int sign in Enumerable.Range(-Count / 2, Count))
            {
                if (Child != null)
                    Child.Draw(context, position + sign * offset * Space, direction);
            }
        }

        public override void Randomize(Random rand)
        {
            Count = rand.Next(2, 16);
            Space = rand.Next(10, 80);
            Direction = (rand.NextDouble() - 0.5f) * 0.5f;
        }

        public override Control CreatePanel()
        {
            return new RepeaterPanel(this);
        }
    }
}
