﻿using System;
using System.Drawing;
using System.Numerics;
using Monostruktura.PartsFactory;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public int OpeningAngle { get; private set; }
        public int ClosingAngle { get; private set; }

        private IPart Child { get; set; }
        public override IEnumerable<IPart> Childs { get { if(Child != null) yield return Child; } }

        public Circle(IPartFactory factory, IPart parent)
        {
            Parent = parent;
            Child = factory.Create(this);
        }

        public override void Draw(Graphics context, Vector2 position, float direction)
        {
            Vector2 destination = position + Offset;

            Color color;

            if (Radius >= 60 && Width == 1)
                color = Palette.ForegroundHelper;

            else
                color = Negative ? Palette.Background : Palette.ForegroundMain;

            using (Pen pen = new Pen(color))
            {
                pen.Width = Width;
                context.DrawArc(pen, destination.X, destination.Y, Radius * 2, Radius * 2, OpeningAngle, OpeningAngle + ClosingAngle);
            }

            if (Child != null)
                Child.Draw(context, destination, direction);
        }

        public override void Randomize(Random rand)
        {
            Negative = rand.Next(0, 3) == 0;
            Width = rand.Next(1, 4);
            Radius = rand.Next(3, 80);

            Offset = new Vector2(rand.Next(-20, 40), rand.Next(-20, 40));

            OpeningAngle = rand.Next(0, 360);
            ClosingAngle = rand.Next(0, 360);
        }

        public override Control CreatePanel()
        {
            return null;
        }
    }
}
