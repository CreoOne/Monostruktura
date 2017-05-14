using System;
using System.Drawing;
using System.Numerics;
using System.Collections.Generic;
using System.Windows.Forms;
using Monostruktura.Parameters;

namespace Monostruktura.Parts
{
    public class Circle : PartAbstract
    {
        public override double Cost
        {
            get
            {
                double area = (2 * Math.PI * Radius.Value) * Width.Value * ((ClosingAngle.Value - OpeningAngle.Value) / 360);
                double selfCost = area / 10f /* (Negative.Value ? -1 : 1)*/;
                return Child != null ? Child.Cost + selfCost : selfCost;
            }
        }

        public readonly IntParameter Width = new IntParameter("Width", 1, 3);
        public readonly IntParameter Radius = new IntParameter("Radius", 3, 80);
        public readonly IntParameter OffsetHorizontal = new IntParameter("Horizontal Offset", -50, 50);
        public readonly IntParameter OffsetVertical = new IntParameter("Vertical Offset", -50, 50);
        public readonly IntParameter OpeningAngle = new IntParameter("OpeningAngle", 0, 360);
        public readonly IntParameter ClosingAngle = new IntParameter("ClosingAngle", 0, 360);
        public readonly BoolParameter Negative = new BoolParameter("Negative", false);

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
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
                Child.Draw(context, position, direction);
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

        public override Control CreatePanel()
        {
            return PanelGeneratorHelper(new IParameter[] { Width, Radius, OffsetHorizontal, OffsetVertical, OpeningAngle, ClosingAngle, Negative });
        }

        public override void SetChild(IPart child, int slot)
        {
            Child = child;
            Child.Parent = this;
        }
    }
}
