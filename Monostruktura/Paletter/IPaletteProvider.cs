using System.Drawing;

namespace Monostruktura.Paletter
{
    public interface IPaletteProvider
    {
        Color GetNextForeground();
        Color GetMaxForeground();
        Color GetSupportForeground();
        Color Background { get; }
        IPaletteProvider Clone();
    }
}
