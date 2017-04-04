using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vezbe2
{
    class Recorder
    {
        private Dictionary<int, Measurement> Measurements { get; set; }

        public Recorder()
        {
            this.Measurements = new Dictionary<int, Measurement>();
        }

        public void Record(Measurement measurement)
        {
            var key = measurement.id;
            this.Measurements[key] = measurement;
            Console.WriteLine("Measurement[{0}] = {1}", key, measurement);
        }

        public void Display()
        {
            foreach (var item in this.Measurements)
            {
                Console.WriteLine("Measurement[{0}] = {1}", item.Key, item.Value);
            }
        }

        public void Mean()
        {
            double sum = 0;
            int count = 0;
            foreach (var item in this.Measurements)
            {
                sum += item.Value.value;
                count++;
            }
            Console.WriteLine("Average value of measurements is: {0}", sum/count);
        }

        public void Percentage(double number)
        {
            int countAll = 0;
            int countBelow = 0;
            int countAbove = 0;
            foreach (var item in this.Measurements)
            {
                countAll++;
                if (item.Value.value < number)
                {
                    countBelow++;
                }
                if (item.Value.value > number)
                {
                    countAbove++;
                }
            }
            int procBelow = 100 * countBelow / countAll;
            int procAbove = 100 * countAbove / countAll;
            Console.WriteLine("Percentage of measurments below {0} is: {1}%", number, procBelow);
            Console.WriteLine("Percentage of measurments above {0} is: {1}%", number, procAbove);
        }
    }
}
