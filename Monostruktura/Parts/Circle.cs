using System;
using System.Drawing;
using System.Numerics;
using Monostruktura.Paletter;
using Monostruktura.PartsFactory;

namespace Monostruktura.Parts
{
    public class Circle : PartAbstract
    {
        public override double Cost
        {
            get
            {
                double area = (2 * Math.PI * Radius) * Width * ((ClosingAngle - OpeningAngle) / 360);
                double selfCost = area / 10f * (Negative ? -1 : 1);
                return Child != null ? Child.Cost + selfCost : selfCost;
            }
        }

        public Vector2 Offset { get; private set; }
        public int Width { get; private set; }
        public int Radius { get; private set; }
        public bool Negative { get; private set; }
        public Color BaseColor { get; private set; }
        public int OpeningAngle { get; private set; }
        public int ClosingAngle { get; private set; }

        public IPart Child { get; private set; }

        public Circle(IPartFactory factory, Random rand, IPart parent, IPaletteProvider palette)
        {
            Negative = rand.Next(0, 3) == 0;
            Width = rand.Next(1, 4);
            Radius = rand.Next(3, 80);

            if (Radius <= 4 && Width >= 3)
                BaseColor = palette.GetMaxForeground();

            else if (Radius >= 60 && Width == 1)
                BaseColor = palette.GetSupportForeground();

            else
                BaseColor = Negative ? palette.Background : palette.GetNextForeground();

            Offset = new Vector2(rand.Next(-20, 40), rand.Next(-20, 40));

            OpeningAngle = rand.Next(0, 360);
            ClosingAngle = rand.Next(0, 360);

            Parent = parent;
            Child = factory.Create(rand, this, palette);
        }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            Vector2 destination = position + Offset;

            using (Pen pen = new Pen(BaseColor))
            {
                pen.Width = Width;
                context.DrawArc(pen, destination.X, destination.Y, Radius * 2, Radius * 2, OpeningAngle, OpeningAngle + ClosingAngle);
            }

            if (Child != null)
                Child.Draw(context, destination, direction);
        }
    }
}
