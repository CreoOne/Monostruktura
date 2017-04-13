using System;
using System.Drawing;
using System.Numerics;

namespace Monostruktura.Paletter
{
    public class MonoPaletteSlow : IPaletteProvider
    {
        private Random Rand { get; set; }
        public Color Background { get { return Color.FromArgb(242, 242, 246); } }
        public Color Foreground { get; private set; }

        public MonoPaletteSlow(Random rand, Color initial)
        {
            Rand = rand;
            Foreground = initial;
        }

        public Color GetNextForeground()
        {
            return Foreground;
        }

        public Color GetMaxForeground()
        {
            Vector3 vectorized = new Vector3(Rand.Next(1, 10), Rand.Next(1, 10), Rand.Next(1, 10));
            Vector3 maximized = Vector3.Normalize(vectorized) * 255;

            return Color.FromArgb((int)maximized.X, (int)maximized.Y, (int)maximized.Z);
        }

        public Color GetSupportForeground()
        {
            return Color.FromArgb(80, 80, 80);
        }
    }
}
