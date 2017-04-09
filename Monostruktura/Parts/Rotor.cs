using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Monostruktura.Paletter;
using Monostruktura.PartsFactory;

namespace Monostruktura.Parts
{
    public class Rotor : PartAbstract
    {
        public override double Cost { get { return Child != null ? Child.Cost * Count : 0; } }

        public int Count { get; private set; }

        public IPart Child { get; private set; }

        public Rotor(IPartFactory factory, Random rand, IPart parent, IPaletteProvider palette)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Count = rand.Next(2, 7);

            Parent = parent;
            Child = factory.Create(rand, this, palette);
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
    }
}
