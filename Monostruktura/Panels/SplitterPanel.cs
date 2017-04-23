using System;
using System.Windows.Forms;

namespace Monostruktura.Panels
{
    public partial class SplitterPanel : UserControl
    {
        private Parts.Splitter Part;

        public SplitterPanel(Parts.Splitter part)
        {
            InitializeComponent();
            Part = part;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Part.AddSlot();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            Part.RemoveSlot();
        }
    }
}
