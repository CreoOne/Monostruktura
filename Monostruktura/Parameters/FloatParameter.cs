using System;

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
    }
}
