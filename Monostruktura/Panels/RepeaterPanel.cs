using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monostruktura.Parts;

namespace Monostruktura.Panels
{
    public partial class RepeaterPanel : UserControl
    {
        private Repeater Part;

        public RepeaterPanel(Repeater part)
        {
            InitializeComponent();
            Part = part;

            tbCount.Value = Part.Count;
            tbSpace.Value = Part.Space;
            tbDirection.Value = (int)Math.Round(Part.Direction / 0.5f * 20f);
        }

        private void tbCount_Scroll(object sender, EventArgs e)
        {
            Part.Count = tbCount.Value;
        }

        private void tbSpace_Scroll(object sender, EventArgs e)
        {
            Part.Space = tbSpace.Value;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            Part.Direction = tbDirection.Value / 20f * 0.5f;
        }
    }
}
