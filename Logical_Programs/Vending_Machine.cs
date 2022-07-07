using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Vending_Machine
    {
        public static void Vending()
        {
            Console.WriteLine("Enter the Amount to get the change : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = new int[] { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int i = 0, total = 0;

            Console.WriteLine("Notes Given as change are : ");

            while (amount != 0)
            {
                int change = amount / notes[i];
                int rem = amount % notes[i];
                amount = rem;
                total += change;

                if (change != 0)
                {
                    Console.WriteLine(change + " Notes of " + notes[i]);
                    i++;
                }
            }
            Console.WriteLine("Total Number of Notes needed : " + total);
        }
    }
}
