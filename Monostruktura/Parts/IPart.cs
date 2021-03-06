﻿using System.Drawing;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Monostruktura.Parts
{
    public interface IPart
    {
        IPart Parent { get; set; }
        IEnumerable<IPart> Childs { get; }
        void SetChild(IPart child, int slot);

        double Cost { get; }
        int Depth { get; }
        int Endpoints { get; }

        void Draw(Graphics context, Vector2 position, float direction, CancellationToken cancellationToken);
        void Randomize(Random rand);
    }
}
