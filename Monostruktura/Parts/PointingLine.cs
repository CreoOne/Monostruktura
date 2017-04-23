using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using Monostruktura.PartsFactory;
using Monostruktura.Panels;

namespace Monostruktura.Parts
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

        public float Direction { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public bool Negative { get; set; }
        public Color BaseColor { get; private set; }

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public PointingLine(IPartFactory factory, IPart parent)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            if (Width == 3 && Length <= 4)
                BaseColor = factory.Palette.GetMaxForeground();

            else if (Width == 1 && Length > 60)
                BaseColor = factory.Palette.GetSupportForeground();

            else
                BaseColor = Negative ? factory.Palette.Background : factory.Palette.GetNextForeground();

            Parent = parent;
            Child = factory.Create(this);
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

        public override void Randomize(Random rand)
        {
            Direction = (float)(rand.NextDouble() - 0.5f) * 0.47f;
            Length = rand.Next(3, 100);
            Width = rand.Next(1, 4);
            Negative = rand.Next(0, 3) == 0;
        }

        public override Control CreatePanel()
        {
            return new PointingLiniePanel(this);
        }
    }
}
