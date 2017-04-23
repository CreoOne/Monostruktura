using System.Drawing;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Monostruktura.Parts
{
    public interface IPart
    {
        IPart Parent { get; }
        IEnumerable<IPart> Childs { get; }
        double Cost { get; }
        int Depth { get; }
        void Draw(Graphics context, Vector2 position, float direction);
        void Randomize(Random rand);
        Control CreatePanel();
    }
}
