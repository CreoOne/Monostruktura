using System;
using System.Windows.Forms;

namespace Monostruktura.Parameters
{
    public class BoolParameter : IParameter<bool>
    {
        public string Name { get; private set; }
        public bool Min { get; private set; }
        public bool Max { get; private set; }

        private bool _Value;
        public bool Value
        {
            get { return _Value; }
            set { _Value = value; ValueChanged?.Invoke(this, EventArgs.Empty); }
        }

        public event EventHandler ValueChanged;

        public BoolParameter(string name, bool value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            Name = name.Trim();
            Min = false;
            Max = true;
            Value = value;
        }

        public Control GetControl()
        {
            Panel result = new Panel()
            {
                Width = 100
            };

            CheckBox checkBox = new CheckBox()
            {
                CheckAlign = System.Drawing.ContentAlignment.MiddleRight,
                Checked = Value,
                Text = Name,
                Left = 3,
                Top = 3,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                Width = result.Width - 6,
            };

            checkBox.CheckedChanged += delegate
            {
                Value = checkBox.Checked;
            };

            result.Height = checkBox.Height + 3;
            result.Controls.Add(checkBox);

            return result;
        }
    }
}
