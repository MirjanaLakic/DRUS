using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace vezbe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double min, max, percentage;
            string numberString, minString, maxString, num;
            do
            {
                Console.Write("Input number of measurements >> ");
                numberString = Console.ReadLine();
            } while (!int.TryParse(numberString, out number));
            do
            {
                Console.Write("Input min value of measurements >> ");
                minString = Console.ReadLine();
            } while (!double.TryParse(minString, out min));
            do
            {
                Console.Write("Input max value of measurements >> ");
                maxString = Console.ReadLine();
            } while (!double.TryParse(maxString, out max));
           
            Recorder rec = new Recorder();
            Thread t = new Thread(() => new Generator(number, min, max, rec));
            t.Start();
            while (t.IsAlive) ;
            t.Abort();
            t.Join();
            rec.Mean();

            Console.WriteLine("");
            do
            {
                Console.Write("Input a number between min and max >> ");
                num = Console.ReadLine();
            } while (!double.TryParse(num, out percentage));
            rec.Percentage(percentage);
            Console.ReadKey();
        }
    }
}
