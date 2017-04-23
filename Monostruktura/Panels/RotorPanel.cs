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
    public partial class RotorPanel : UserControl
    {
        private Rotor Part;

        public RotorPanel(Rotor part)
        {
            InitializeComponent();
            Part = part;

            tbCount.Value = Part.Count;
        }

        private void tbCount_Scroll(object sender, EventArgs e)
        {
            Part.Count = tbCount.Value;
        }
    }
}
