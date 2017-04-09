using System;
using x09_Struktura.Paletter;
using x09_Struktura.Parts;

namespace x09_Struktura.PartsFactory
{
    public interface IPartFactory
    {
        IPart Create(Random rand, IPart parent, IPaletteProvider palette);
    }
}
