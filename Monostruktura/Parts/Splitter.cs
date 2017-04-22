using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Monostruktura.PartsFactory;

namespace Monostruktura.Parts
{
    public class Splitter : PartAbstract
    {
        public override double Cost { get { return Childs.Sum(c => c != null ? c.Cost : 0); } }

        private List<IPart> ChildsInternal { get; set; }
        public override IEnumerable<IPart> Childs { get { return ChildsInternal; } }

        public Splitter(IPartFactory factory, IPart parent)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Parent = parent;

            ChildsInternal = Enumerable.Range(0, factory.Rand.Next(2, 8)).Select(c => factory.Create(this)).ToList();
        }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            float offset = (float)Math.PI / ChildsInternal.Count;

            foreach (int index in Enumerable.Range(0, ChildsInternal.Count))
                if(ChildsInternal[index] != null)
                    ChildsInternal[index].Draw(context, position, direction - (float)Math.PI + offset * index);
        }

        public override void Randomize(Random rand)
        {
            // nothing to do
        }
    }
}
