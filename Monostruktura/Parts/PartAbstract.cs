using System.Drawing;
using System.Numerics;
using System;
using System.Collections.Generic;

namespace Monostruktura.Parts
{
    public abstract class PartAbstract : IPart
    {
        public IPart Parent { get; protected set; }
        public abstract IEnumerable<IPart> Childs { get; }
        public int Depth { get { return Parent != null ? Parent.Depth + 1 : 0; } }

        public abstract double Cost { get; }
        public abstract void Draw(Graphics context, Vector2 position, float direction);
        public abstract void Randomize(Random rand);
    }
}
