using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vezbe2
{
    class Measurement
    {
        public int id { get; private set; }
        public double value { get; private set; }
        public DateTime timestamp { get; private set; }

        public Measurement(int id, double value, DateTime timestamp)
        {
            this.id = id;
            this.value = value;
            this.timestamp = timestamp;
        }

        public override string ToString()
        {
            return String.Format("Measurement {0}, Val: {1}, at {2}", this.id, this.value, this.timestamp);
        }
    }
}
