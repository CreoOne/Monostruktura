using System;
using Monostruktura.Parts;

namespace Monostruktura.PartsFactory
{
    public class RandomizedDepthPartFactory : DepthPartFactory
    {
        public RandomizedDepthPartFactory(int depth, Random rand) : base(depth, rand) { }

        public override IPart Create(IPart parent)
        {
            IPart result = base.Create(parent);

            if (result != null)
                result.Randomize(Rand);

            return result;
        }
    }
}
