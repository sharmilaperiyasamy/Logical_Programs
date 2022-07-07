using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logical_Programs
{
    internal class StopWatch
    {
        public void Stop_Watch()
        {
            Console.WriteLine("Enter 1 to start timer.");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 0 to stop timer.");
            int stop = Convert.ToInt32(Console.ReadLine());

            Stopwatch sw = new Stopwatch();

            if (start == 1)
            {
                sw.Start();
            }
            if (stop == 0)
            {
                sw.Stop();
            }
            TimeSpan te = sw.Elapsed;

            Console.WriteLine("Time Elapsed: " + te.TotalSeconds);
        }
    }
}
