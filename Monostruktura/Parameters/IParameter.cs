using System;
using System.Windows.Forms;

namespace Monostruktura.Parameters
{
    public interface IParameter
    {
        string Name { get; }
        Control GetControl();
    }

    public interface IParameter<T> : IParameter
    {
        T Min { get; }
        T Max { get; }
        T Value { get; set; }
        event EventHandler ValueChanged;
    }
}
