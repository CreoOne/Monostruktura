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
            UpdateControlsEnable();
        }

        public void SetPart(IPart part)
        {
            Part = part;
            UpdateControlsEnable();
            UpdateChildsControls();
        }

        public void SetCore(IPart core)
        {
            Core = core;
            UpdateControlsEnable();
        }

        private void bParent_Click(object sender, EventArgs e)
        {
            SetPart(Part.Parent);
        }

        private void bCore_Click(object sender, EventArgs e)
        {
            SetPart(Core);
        }

        private void UpdateControlsEnable()
        {
            bParent.Enabled = Part != null && Part.Parent != null;
            bCore.Enabled = Core != null;
        }

        private void UpdateChildsControls()
        {
            if (Part == null)
            {
                pChilds.Controls.Clear();
                pChilds.Height = 0;
                return;
            }

            pChilds.Height = 4 + 26 * Part.Childs.Count();

            foreach(int childIndex in Enumerable.Range(0, Part.Childs.Count()))
            {
                IPart child = Part.Childs.ElementAt(childIndex);

                Button btn = new Button();
                btn.Name = "bChild" + childIndex;
                btn.Text = "Child " + childIndex;
                btn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                btn.Left = 3;
                btn.Top = 3 + 26 * childIndex;
                btn.Width = pChilds.Width - 6;
                btn.Height = 23;

                btn.Click += (sender, eventArgs) =>
                {
                    SetPart(Part.Childs.ElementAt(childIndex));
                };

                pChilds.Controls.Add(btn);
            }
        }
    }
}
