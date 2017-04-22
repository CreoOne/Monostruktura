using System;
using Monostruktura.Paletter;
using Monostruktura.Parts;

namespace Monostruktura.PartsFactory
{
    public class RandomizedDepthPartFactory : DepthPartFactory
    {
        public RandomizedDepthPartFactory(int depth, Random rand, IPaletteProvider palette) : base(depth, rand, palette) { }

        public override IPart Create(IPart parent)
        {
            IPart result = base.Create(parent);

            if (result != null)
                result.Randomize(Rand);

            return result;
        }
    }
}
