using System;

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
    }
}
