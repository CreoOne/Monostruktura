using Monostruktura.Parts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Monostruktura
{
    public partial class PartCreator : Form
    {
        public IPart Chosen;

        public PartCreator()
        {
            InitializeComponent();

            chosen.DataSource = new List<IPart>
            {
                new Circle(),
                new PointingLine(),
                new Repeater(),
                new Rotor(),
                new Parts.Splitter(),
            };

            chosen.SelectedIndex = 0;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Chosen = (IPart)chosen.SelectedValue;
            Chosen.Randomize(new Random());
            Close();
        }
    }
}
