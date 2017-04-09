using System;
using System.Drawing;
using System.Numerics;

namespace Monostruktura.Paletter
{
    public class MonoPaletteSlow : IPaletteProvider
    {
        private Random Rand { get; set; }
        private Vector3 Momentum { get; set; }
        public Color Background { get { return Color.FromArgb(242, 242, 246); } }
        public Color Foreground { get; private set; }

        public MonoPaletteSlow(Random rand, Color initial)
        {
            Rand = rand;
            Foreground = initial;
            Momentum = new Vector3(rand.Next(0, 3), rand.Next(0, 1), rand.Next(0, 3));
        }

        public Color GetNextForeground()
        {
            Momentum += new Vector3(Rand.Next(-1, 2), 0, Rand.Next(-1, 2));

            int r = Clamp(Foreground.R + Momentum.X);
            int g = Clamp(Foreground.G + Momentum.Y);
            int b = Clamp(Foreground.B + Momentum.Z);
            return Foreground = Color.FromArgb(r, g, b);
        }

        public Color GetMaxForeground()
        {
            Vector3 vectorized = new Vector3(Foreground.R, Foreground.G, Foreground.B);
            Vector3 maximized;

            if (vectorized.Length() > 0)
                maximized = Vector3.Normalize(vectorized) * 255;

            else
                maximized = new Vector3(255, 0, 0);

            return Color.FromArgb((int)maximized.X, (int)maximized.Y, (int)maximized.Z);
        }

        public Color GetSupportForeground()
        {
            return Color.FromArgb(80, 80, 80);
        }

        private int Clamp(float v)
        {
            return (int)Math.Max(0, Math.Min(255, v));
        }

        public IPaletteProvider Clone()
        {
            return new MonoPaletteSlow(Rand, Foreground);
        }
    }
}
