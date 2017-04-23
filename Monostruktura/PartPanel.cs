using System;
using System.Linq;
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

            if (Part == null)
            {
                lName.Text = string.Empty;
                pControls.Controls.Clear();
                return;
            }

            lName.Text = Part.GetType().Name;
            Control control = Part.CreatePanel();

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                pControls.Controls.Add(control);
            }

            else
                pControls.Controls.Clear();

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

                if (child == null)
                    continue;

                Button btn = new Button();
                btn.Name = "bChild" + childIndex;
                btn.Text = "Child " + childIndex + ": " + child.GetType().Name;
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
