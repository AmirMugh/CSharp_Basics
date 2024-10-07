using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write and run a C# program that calculates and displays the amount of money available in a bank
account that initially has $1,000 deposited in it and that earns 8 percent interest a year. Your
program should display the amount available at the end of each year for a period of ten years. Use
the relationship that the money available at the end of each year equals the amount of money in
the account at the start of the year plus .08 times the amount available at the start of the year.*/

namespace ConsoleApp1
{
    internal class Q9
    {
        public static void q9()
        {
            double initialDeposit = 1000;
            double interestRate = 0.08;
            double currentBalance = initialDeposit;
            int totalYears = 10;

            Console.WriteLine("Year\tAmount Available");

            // For loop
            for (int year = 1; year <= totalYears; year++)
            {
                currentBalance += currentBalance * interestRate;
                Console.WriteLine($"{year}\t{currentBalance:C}");
            }

            Console.WriteLine("\nYear\tAmount Available (Using while loop)");

            // While loop
            int currentYear = 1;
            while (currentYear <= totalYears)
            {
                currentBalance += currentBalance * interestRate;
                Console.WriteLine($"{currentYear}\t{currentBalance:C}");

                currentYear++;
            }
        }
    }
}

