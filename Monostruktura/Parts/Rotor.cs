using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Monostruktura.PartsFactory;

namespace Monostruktura.Parts
{
    public class Rotor : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count : 0; } }

        public int Count { get; private set; }

        public IPart Child { get; private set; }

        public Rotor(IPartFactory factory, IPart parent)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Randomize(factory.Rand);

            Parent = parent;
            Child = factory.Create(this);
        }

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
    }
}
