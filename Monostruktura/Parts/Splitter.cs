﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace Monostruktura.Parts
{
    public class Splitter : PartAbstract
    {
        public override double Cost { get { return Childs.Sum(c => c != null ? c.Cost : 0); } }

        private List<IPart> ChildsInternal = new List<IPart> { null };
        public override IEnumerable<IPart> Childs { get { return ChildsInternal; } }

        public override void Draw(Graphics context, Vector2 position, float direction, CancellationToken cancellationToken)
        {
            float offset = (float)Math.PI / ChildsInternal.Count;

            foreach (int index in Enumerable.Range(0, ChildsInternal.Count))
                if(ChildsInternal[index] != null)
                    ChildsInternal[index].Draw(context, position, direction - (float)Math.PI + offset * index, cancellationToken);
        }

        public override void Randomize(Random rand)
        {
            ChildsInternal = Enumerable.Range(0, rand.Next(1, 5)).Select(e => (IPart)null).ToList();
        }

        public override void SetChild(IPart child, int slot)
        {
            if (slot < 0 && slot >= ChildsInternal.Count - 1)
                throw new ArgumentOutOfRangeException("slot");

            ChildsInternal[slot] = child;

            if(child != null)
                child.Parent = this;

            ChildsInternal = ChildsInternal.OrderByDescending(c => c == null ? 0 : c.Endpoints).ToList();
        }

        public void AddSlot()
        {
            ChildsInternal.Add(null);
        }

        public void RemoveSlot()
        {
            if(ChildsInternal.Count > 1)
                ChildsInternal = ChildsInternal.Take(ChildsInternal.Count - 1).ToList();
        }
    }
}
