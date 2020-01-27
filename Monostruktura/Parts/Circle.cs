using System;
using System.Drawing;
using System.Numerics;
using System.Collections.Generic;
using Monostruktura.Parameters;
using System.Threading;

namespace Monostruktura.Parts
{
    public class Circle : PartAbstract
    {
        public override double Cost
        {
            get
            {
                double largeArea = Math.PI * Math.Pow(Radius.Value + Width.Value / 2d, 2);
                double smallArea = Math.PI * Math.Pow(Radius.Value - Width.Value / 2d, 2);
                double area = (largeArea - smallArea) * (Math.Min(360, ClosingAngle.Value - OpeningAngle.Value) / 360);
                double selfCost = area / 10f;
                return Child != null ? Child.Cost + selfCost : selfCost;
            }
        }

        public readonly IntParameter Width = new IntParameter("Width", 1, 4);
        public readonly IntParameter Radius = new IntParameter("Radius", 3, 100);
        public readonly IntParameter OffsetHorizontal = new IntParameter("Horizontal Offset", -100, 100);
        public readonly IntParameter OffsetVertical = new IntParameter("Vertical Offset", -100, 100);
        public readonly IntParameter OpeningAngle = new IntParameter("OpeningAngle", 0, 360);
        public readonly IntParameter ClosingAngle = new IntParameter("ClosingAngle", 0, 360);
        public readonly BoolParameter Negative = new BoolParameter("Negative", false);

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public override void Draw(Graphics context, Vector2 position, float direction, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            Vector2 destination = position + new Vector2(OffsetHorizontal.Value, OffsetVertical.Value);

            Color color;

            if (Radius.Value >= 60 && Width.Value == 1)
                color = Palette.ForegroundHelper;

            else
                color = Negative.Value ? Palette.Background : Palette.ForegroundMain;

            using (Pen pen = new Pen(color))
            {
                pen.Width = Width.Value;
                int diameter = Radius.Value * 2;
                context.DrawArc(pen, destination.X - Radius.Value, destination.Y - Radius.Value, diameter, diameter, OpeningAngle.Value, OpeningAngle.Value + ClosingAngle.Value);
            }

            if (Child != null)
                Child.Draw(context, position, direction, cancellationToken);
        }

        public override void Randomize(Random rand)
        {
            Width.Randomize(rand);
            Radius.Randomize(rand);

            OffsetHorizontal.Randomize(rand);
            OffsetVertical.Randomize(rand);

            OpeningAngle.Randomize(rand);
            ClosingAngle.Randomize(rand);

            Negative.Value = rand.Next(0, 4) == 0;
        }

        public override void SetChild(IPart child, int slot)
        {
            Child = child;

            if(Child != null)
                Child.Parent = this;
        }
    }
}
