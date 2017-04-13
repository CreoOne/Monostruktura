using System;
using Monostruktura.Paletter;
using Monostruktura.Parts;

namespace Monostruktura.PartsFactory
{
    public interface IPartFactory
    {
        Random Rand { get; }
        IPaletteProvider Palette { get; }
        IPart Create(IPart parent);
    }
}
