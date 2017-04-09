using System;
using x09_Struktura.Paletter;
using x09_Struktura.Parts;

namespace x09_Struktura.PartsFactory
{
    public class DepthPartFactory : IPartFactory
    {
        public int Depth { get; private set; }

        public DepthPartFactory(int depth)
        {
            if (depth < 0)
                throw new ArgumentOutOfRangeException("depth");

            Depth = depth;
        }

        public IPart Create(Random rand, IPart parent, IPaletteProvider palette)
        {
            if (parent != null && parent.Depth > Depth)
            {
                if (parent.GetType() != typeof(PointingLine))
                    return new PointingLine(this, rand, parent, palette);

                else
                    return null;
            }

            IPart result = null;

            do
            {
                int rnd = rand.Next(0, 5);

                switch (rnd)
                {
                    default:
                    case 0: result = new PointingLine(this, rand, parent, palette); break;
                    case 1: result = new Rotor(this, rand, parent, palette); break;
                    case 2: result = new Repeater(this, rand, parent, palette); break;
                    case 3: result = new Splitter(this, rand, parent, palette); break;
                    case 4: result = new Circle(this, rand, parent, palette); break;
                }
            }

            while (parent != null && result.GetType() == parent.GetType());

            return result;
        }
    }
}
