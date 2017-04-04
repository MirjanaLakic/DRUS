using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vezbe2
{
    class Generator
    {
        public Generator(int brMerenja, double Min, double Max, Recorder rec)
        {
            Random rnd = new Random();
            for (int i = 0; i < brMerenja; i++)
            {
                Measurement m = new Measurement(i, Math.Round(rnd.NextDouble() * (Max - Min) + Min, 2), DateTime.Now);
                rec.Record(m);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
