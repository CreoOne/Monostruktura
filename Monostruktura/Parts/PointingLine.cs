﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Threading;
using Monostruktura.Parameters;

namespace Monostruktura.Parts
{
    public class PointingLine : PartAbstract
    {
        public override double Cost
        {
            get
            {
                double area = (Length.Value * Width.Value);
                double selfCost = area / 10f;
                return Child != null ? Child.Cost + selfCost : selfCost;
            }
        }

        public readonly FloatParameter Direction = new FloatParameter("Direction", -(float)Math.PI, (float)Math.PI);
        public readonly IntParameter Length = new IntParameter("Length", 3, 100);
        public readonly IntParameter Width = new IntParameter("Width", 1, 4);
        public readonly BoolParameter Negative = new BoolParameter("Negative", false);

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { yield return Child; } }

        public override void Draw(Graphics context, Vector2 position, float direction, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            float pointing = direction + Direction.Value;
            Vector2 destination = position + new Vector2((float)Math.Cos(pointing) * Length.Value, (float)Math.Sin(pointing) * Length.Value);

            Color color;

            if (Width.Value == 1 && Length.Value > 60)
                color = Palette.ForegroundHelper;

            else
                color = Negative.Value ? Palette.Background : Palette.ForegroundMain;

            using (Pen pen = new Pen(color))
            {
                pen.Width = Width.Value;
                context.DrawLine(pen, position.ToPointF(), destination.ToPointF());
            }

            if(Child != null)
                Child.Draw(context, destination, pointing, cancellationToken);
        }

        public override void Randomize(Random rand)
        {
            Direction.Randomize(rand);
            Length.Randomize(rand);
            Width.Randomize(rand);

            Negative.Value = rand.Next(0, 3) == 0;
        }

        public override void SetChild(IPart child, int slot)
        {
            Child = child;

            if(Child != null)
                Child.Parent = this;
        }
    }
}
