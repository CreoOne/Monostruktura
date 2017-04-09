using System.Drawing;
using System.Numerics;

namespace Monostruktura
{
    public static class Vector2ToPointF
    {
        public static PointF ToPointF(this Vector2 self)
        {
            return new PointF(self.X, self.Y);
        }
    }
}
