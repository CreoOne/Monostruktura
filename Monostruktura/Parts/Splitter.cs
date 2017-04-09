using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Monostruktura.Paletter;
using Monostruktura.PartsFactory;

namespace Monostruktura.Parts
{
    public class Splitter : PartAbstract
    {
        public override double Cost { get { return Childs.Sum(c => c != null ? c.Cost : 0); } }

        public int Divider { get; private set; }

        public List<IPart> Childs { get; private set; }

        public Splitter(IPartFactory factory, Random rand, IPart parent, IPaletteProvider palette)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Parent = parent;

            Childs = Enumerable.Range(0, rand.Next(2, 8)).Select(c => factory.Create(rand, this, palette.Clone())).ToList();
        }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            float offset = (float)Math.PI / Childs.Count;

            foreach (int index in Enumerable.Range(0, Childs.Count))
                if(Childs[index] != null)
                    Childs[index].Draw(context, position, direction - (float)Math.PI + offset * index);
        }
    }
}
