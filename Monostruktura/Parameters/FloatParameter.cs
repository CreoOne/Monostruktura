using System;
using System.Windows.Forms;

namespace Monostruktura.Parameters
{
    public class FloatParameter : IParameter<float>
    {
        public string Name { get; private set; }
        public float Min { get; private set; }
        public float Max { get; private set; }

        private float _Value;
        public float Value
        {
            get { return _Value; }
            set { _Value = Math.Max(Min, Math.Min(Max, value)); ValueChanged?.Invoke(this, EventArgs.Empty); }
        }

        public event EventHandler ValueChanged;

        public FloatParameter(string name, float min, float max) : this(name, min, max, min) { }

        public FloatParameter(string name, float min, float max, float value)
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
            Value = Min + ((float)rand.NextDouble() * (Max - Min));
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
                Minimum = (int)(Min * 1000),
                Maximum = (int)(Max * 1000),
                Value = (int)(Value * 1000),
                Left = 3,
                Top = label.Height + 3,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                Width = result.Width - 6,
            };

            trackBar.ValueChanged += delegate
            {
                Value = trackBar.Value / 1000f;
            };

            result.Height = label.Height + trackBar.Height;
            result.Controls.Add(label);
            result.Controls.Add(trackBar);

            return result;
        }
    }
}
