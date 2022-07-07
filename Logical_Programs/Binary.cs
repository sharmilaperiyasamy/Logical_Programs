using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Binary
    {
        public static void toBinary()
        {
            Console.WriteLine("Enter the Decimal number to convert to the Equivalent binary number : ");
            int dec = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int[] binary = new int[10];
            while (dec > 0)
            {
                binary[i] = dec % 2;
                dec = dec / 2;
                i++;
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
