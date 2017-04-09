using System.Drawing;
using System.Numerics;
using x09_Struktura.Paletter;

namespace x09_Struktura.Parts
{
    public interface IPart
    {
        IPart Parent { get; }
        double Cost { get; }
        int Depth { get; }
        void Draw(Graphics context, Vector2 position, float direction);
    }
}
