using System;
using Monostruktura.Paletter;
using Monostruktura.Parts;

namespace Monostruktura.PartsFactory
{
    public interface IPartFactory
    {
        IPart Create(Random rand, IPart parent, IPaletteProvider palette);
    }
}
