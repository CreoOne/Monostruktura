using System;
using Monostruktura.Parts;

namespace Monostruktura.PartsFactory
{
    public interface IPartFactory
    {
        Random Rand { get; }
        IPart Create(IPart parent);
    }
}
