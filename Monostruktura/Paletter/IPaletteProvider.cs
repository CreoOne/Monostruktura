using System.Drawing;

namespace x09_Struktura.Paletter
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
