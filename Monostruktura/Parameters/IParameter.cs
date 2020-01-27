using System;

namespace Monostruktura.Parameters
{
    public interface IParameter
    {
        string Name { get; }
        void Randomize(Random rand);
    }

    public interface IParameter<T> : IParameter
    {
        T Min { get; }
        T Max { get; }
        T Value { get; set; }
        event EventHandler ValueChanged;
    }
}
