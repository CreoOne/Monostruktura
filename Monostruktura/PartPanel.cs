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

namespace Monostruktura
{
    public partial class PartPanel : UserControl
    {
        private IPart Part { get; set; }
        private IPart Core { get; set; }

        public PartPanel()
        {
            InitializeComponent();
        }

        public PartPanel(IPart part) : this()
        {
            Part = part;

            if (Part == null)
                return;

            bParent.Enabled = Part.Parent != null;
        }

        public PartPanel(IPart part, IPart core) : this(part)
        {
            Core = core;

            bCore.Enabled = Core != null;
        }

        private void bParent_Click(object sender, EventArgs e)
        {
            if (Part == null)
                return;
        }

        private void bCore_Click(object sender, EventArgs e)
        {
            if (Core == null)
                return;
        }
    }
}
