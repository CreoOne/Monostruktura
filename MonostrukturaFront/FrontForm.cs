using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monostruktura;

namespace MonostrukturaFront
{
    public partial class FrontForm : Form
    {
        public FrontForm()
        {
            InitializeComponent();
        }

        private void bMonostrukturaMainForm_Click(object sender, EventArgs e)
        {
            using (StrukturaMainForm strukturaMainForm = new StrukturaMainForm())
                strukturaMainForm.ShowDialog();
        }
    }
}
