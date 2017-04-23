using System;
using System.Windows.Forms;
using Monostruktura.Parts;

namespace Monostruktura.Panels
{
    public partial class PointingLiniePanel : UserControl
    {
        private PointingLine Part;

        public PointingLiniePanel(PointingLine part)
        {
            InitializeComponent();
            Part = part;

            tbDirection.Value = (int)Math.Round(Part.Direction / 0.47f * 20f);
            tbLength.Value = Part.Length;
            tbWidth.Value = Part.Width;
            cbNegative.Checked = Part.Negative;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            Part.Direction = (tbDirection.Value / 20f) * 0.47f;
        }

        private void tbLength_Scroll(object sender, EventArgs e)
        {
            Part.Length = tbLength.Value;
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            Part.Width = tbWidth.Value;
        }

        private void cbNegative_CheckedChanged(object sender, EventArgs e)
        {
            Part.Negative = cbNegative.Checked;
        }
    }
}
