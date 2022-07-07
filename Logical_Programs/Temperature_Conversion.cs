using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Temperature_Conversion
    {
        public static void Fahrenheit_to_Celsius()
        {
            Console.WriteLine("Enter the Temperature in Fahrenheit : ");
            double Fah = Convert.ToDouble(Console.ReadLine());
            double Cel = (Fah - 32) * 5 / 9;
            Console.WriteLine("Temperature => " + Fah + " deg in Fahrenheit is equal to " + Cel + " deg in Celsius");
        }
        public static void Celsius_to_Fahrenheit()
        {
            Console.WriteLine("Enter the Temperature in Celsius : ");
            double cel = Convert.ToDouble(Console.ReadLine());
            double fah = (cel * 9 / 5) + 32;
            Console.WriteLine("Temperature => " + cel + " deg in Celsius is equal to " + fah + " deg in Fahrenheit");
        }
    }
}
