using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Monostruktura.PartsFactory;

namespace Monostruktura.Parts
{
    public class Repeater : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count : 0; } }

        public int Count { get; private set; }
        public int Space { get; private set; }
        public double Direction { get; private set; }

        public IPart Child { get; private set; }

        public Repeater(IPartFactory factory, IPart parent)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Randomize(factory.Rand);

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
    }
}
