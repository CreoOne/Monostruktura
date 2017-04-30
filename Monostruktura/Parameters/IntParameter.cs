using System;
using System.Windows.Forms;

namespace Monostruktura.Parameters
{
    public class IntParameter : IParameter<int>
    {
        public string Name { get; private set; }
        public int Min { get; private set; }
        public int Max { get; private set; }

        private int _Value;
        public int Value
        {
            get { return _Value; }
            set { _Value = Math.Max(Min, Math.Min(Max, value)); ValueChanged?.Invoke(this, EventArgs.Empty); }
        }

        public event EventHandler ValueChanged;

        public IntParameter(string name, int min, int max) : this(name, min, max, min) { }

        public IntParameter(string name, int min, int max, int value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            Name = name.Trim();
            Min = min;
            Max = max;
            Value = value;
        }

        public void Randomize(Random rand)
        {
            Value = rand.Next(Min, Max + 1);
        }

        public Control GetControl()
        {
            Panel result = new Panel()
            {
                Width = 100
            };

            Label label = new Label()
            {
                Left = 3,
                Top = 3,
                Text = Name
            };

            TrackBar trackBar = new TrackBar()
            {
                Minimum = Min,
                Maximum = Max,
                Value = Value,
                Left = 3,
                Top = label.Height + 3,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                Width = result.Width - 6,
            };

            trackBar.ValueChanged += delegate
            {
                Value = trackBar.Value;
            };

            result.Height = label.Height + trackBar.Height;
            result.Controls.Add(label);
            result.Controls.Add(trackBar);

            return result;
        }
    }
}
