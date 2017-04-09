using System;
using System.Drawing;
using System.Numerics;
using x09_Struktura.Paletter;
using x09_Struktura.PartsFactory;

namespace x09_Struktura.Parts
{
    public class PointingLine : PartAbstract
    {
        public override double Cost
        {
            get
            {
                double area = (Length * Width);
                double selfCost = area / 10f * (Negative ? -1 : 1);
                return Child != null ? Child.Cost + selfCost : selfCost;
            }
        }

        public float Direction { get; private set; }
        public float Length { get; private set; }
        public int Width { get; private set; }
        public bool Negative { get; private set; }
        public Color BaseColor { get; private set; }

        public IPart Child { get; private set; }

        public PointingLine(IPartFactory factory, Random rand, IPart parent, IPaletteProvider palette)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            Direction = (float)(rand.NextDouble() - 0.5f) * 0.47f;
            Length = rand.Next(3, 100);
            Width = rand.Next(1, 4);
            Negative = rand.Next(0, 3) == 0;

            if (Width == 3 && Length <= 4)
                BaseColor = palette.GetMaxForeground();

            else if (Width == 1 && Length > 60)
                BaseColor = palette.GetSupportForeground();

            else
                BaseColor = Negative ? palette.Background : palette.GetNextForeground();

            Parent = parent;
            Child = factory.Create(rand, this, palette);
        }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            float pointing = direction + Direction;
            Vector2 destination = position + new Vector2((float)Math.Cos(pointing) * Length, (float)Math.Sin(pointing) * Length);

            using (Pen pen = new Pen(BaseColor))
            {
                pen.Width = Width;
                context.DrawLine(pen, position.ToPointF(), destination.ToPointF());
            }

            if(Child != null)
                Child.Draw(context, destination, pointing);
        }
    }
}
