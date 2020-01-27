using System;

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

        public void Randomize(Random rand)
        {
            Value = rand.Next(0, 2) == 0;
        }
    }
}
