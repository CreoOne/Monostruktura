using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Monostruktura.Parts
{
    public class Splitter : PartAbstract
    {
        public override double Cost { get { return Childs.Sum(c => c != null ? c.Cost : 0); } }

        private List<IPart> ChildsInternal = new List<IPart> { null };
        public override IEnumerable<IPart> Childs { get { return ChildsInternal; } }

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

        public override Control CreatePanel()
        {
            return null;
        }

        public override void SetChild(IPart child, int slot)
        {
            if (slot < 0 && slot >= ChildsInternal.Count)
                throw new ArgumentOutOfRangeException("slot");

            ChildsInternal[slot] = child;
            ChildsInternal[slot].Parent = this;
        }
    }
}
