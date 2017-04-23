using System.Drawing;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Monostruktura.Parts
{
    public abstract class PartAbstract : IPart
    {
        public IPart Parent { get; set; }
        public abstract IEnumerable<IPart> Childs { get; }
        public abstract void SetChild(IPart child, int slot);

        public int Depth { get { return Parent != null ? Parent.Depth + 1 : 0; } }
        public abstract double Cost { get; }

        public abstract void Draw(Graphics context, Vector2 position, float direction);
        public abstract void Randomize(Random rand);
        public abstract Control CreatePanel();
    }
}
