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
            pControls.Controls.Clear();

            if (Part == null)
            {
                lName.Text = string.Empty;
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
            pChilds.Controls.Clear();

            if (Part == null)
            {
                pChilds.Height = 0;
                return;
            }

            pChilds.Height = 4 + 26 * Part.Childs.Count();

            foreach (int childIndex in Enumerable.Range(0, Part.Childs.Count()))
            {
                IPart child = Part.Childs.ElementAt(childIndex);

                pChilds.Controls.Add(CreateGoButton(childIndex, child));
                pChilds.Controls.Add(CreateSetButton(childIndex, child));
                pChilds.Controls.Add(CreateRemoveButton(childIndex, child));
            }
        }

        private Button CreateGoButton(int childIndex, IPart child)
        {
            Button btn = new Button();
            btn.Name = "bChildGo" + childIndex;
            btn.Enabled = child != null;

            if (child != null)
                btn.Text = "Child " + childIndex + ": " + child.GetType().Name;

            btn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            btn.Left = 3;
            btn.Top = 3 + 26 * childIndex;
            btn.Width = pChilds.Width - 58;
            btn.Height = 23;

            btn.Click += (sender, eventArgs) =>
            {
                SetPart(child);
            };
            
            return btn;
        }

        private Button CreateSetButton(int childIndex, IPart child)
        {
            Button btn = new Button();
            btn.Name = "bChildSet" + childIndex;
            btn.Text = "+";

            btn.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btn.Left = pChilds.Width - 52;
            btn.Top = 3 + 26 * childIndex;
            btn.Width = 23;
            btn.Height = 23;

            btn.Click += (sender, eventArgs) =>
            {
                using (PartCreator creator = new PartCreator())
                    if (creator.ShowDialog() == DialogResult.OK && creator.Chosen != null)
                        Part.SetChild(creator.Chosen, childIndex);

                UpdateChildsControls();
            };

            return btn;
        }

        private Button CreateRemoveButton(int childIndex, IPart child)
        {
            Button btn = new Button();
            btn.Name = "bChildRemove" + childIndex;
            btn.Text = "-";

            btn.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btn.Left = pChilds.Width - 26;
            btn.Top = 3 + 26 * childIndex;
            btn.Width = 23;
            btn.Height = 23;

            btn.Click += (sender, eventArgs) =>
            {
                Part.SetChild(null, childIndex);
                UpdateChildsControls();
            };

            return btn;
        }
    }
}
