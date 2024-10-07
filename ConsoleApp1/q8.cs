using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that displays a conversion table from Fahrenheit to Celsius. The program must
request the starting Fahrenheit value, the ending Fahrenheit value, and the increment. Thus,
instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit
value. Your table must look professional!*/

namespace ConsoleApp1
{
    class Q8
    {
        public static void q8()
        {
            int startFahrenheit, endFahrenheit, increment;
            double celsius;

            Console.WriteLine("Enter the starting Fahrenheit value: ");
            startFahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending Fahrenheit value: ");
            endFahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the increment value: ");
            increment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFahrenheit to Celsius Conversion");
            Console.WriteLine("Fahrenheit    Celsius");
            
            //For loop
            for (int fahrenheit = startFahrenheit; fahrenheit <= endFahrenheit; fahrenheit += increment)
            {
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit,-14} {celsius,10:0.00}");
            }

            Console.WriteLine("\nFahrenheit to Celsius Conversion (Using while loop)");
            Console.WriteLine("Fahrenheit    Celsius");

            // While loop
            int currentFahrenheit = startFahrenheit;
            while (currentFahrenheit <= endFahrenheit)
            {
                celsius = (currentFahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{currentFahrenheit,-14} {celsius,10:0.00}");

                currentFahrenheit += increment;
            }
        }
    }
}
