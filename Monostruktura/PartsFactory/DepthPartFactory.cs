using System;
using Monostruktura.Parts;

namespace Monostruktura.PartsFactory
{
    public class DepthPartFactory : IPartFactory
    {
        public int Depth { get; private set; }
        public Random Rand { get; private set; }

        public DepthPartFactory(int depth, Random rand)
        {
            if (depth < 0)
                throw new ArgumentOutOfRangeException("depth");

            if (rand == null)
                throw new ArgumentNullException("rand");

            Depth = depth;
            Rand = rand;
        }

        public virtual IPart Create(IPart parent)
        {
            if (parent != null && parent.Depth > Depth)
            {
                if (parent.GetType() != typeof(PointingLine))
                    return new PointingLine(this, parent);

                else
                    return null;
            }

            IPart result = null;

            do
            {
                int rnd = Rand.Next(0, 5);

                switch (rnd)
                {
                    default:
                    case 0: result = new PointingLine(this, parent); break;
                    case 1: result = new Rotor(this, parent); break;
                    case 2: result = new Repeater(this, parent); break;
                    case 3: result = new Splitter(this, parent); break;
                    case 4: result = new Circle(this, parent); break;
                }
            }

            while (parent != null && result.GetType().Equals(parent.GetType()));

            return result;
        }
    }
}
