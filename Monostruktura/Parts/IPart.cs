using System.Drawing;
using System.Numerics;
using System;

namespace Monostruktura.Parts
{
    public interface IPart
    {
        IPart Parent { get; }
        double Cost { get; }
        int Depth { get; }
        void Draw(Graphics context, Vector2 position, float direction);
        void Randomize(Random rand);
    }
}
