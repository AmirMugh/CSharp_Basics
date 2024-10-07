using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Print the decimal, octal, and hexadecimal values of all characters between the start and stop
characters entered by a user. For example, if the user enters an a and a z, the program should
print all the characters between a and z and their respective numerical values. Make sure that the
second character entered by the user occurs later in the alphabet than the first character. If it does
not, write a loop that repeatedly asks the user for a valid second character until one is entered.
Your output should be formatted as shown below*/

namespace ConsoleApp1
{
    internal class Q11
    {
        public static void q11()
        {
            Console.Write("Enter the start character: ");
            char startChar = Console.ReadLine()[0];

            char stopChar;

            // Do-While loop
            do
            {
                Console.Write("Enter the stop character: ");
                stopChar = Console.ReadLine()[0];

                if (stopChar <= startChar)
                {
                    Console.WriteLine("The stop character must come after the start character in the alphabet. Please enter again.");
                }
            } while (stopChar <= startChar);

            Console.WriteLine("Letter Decimal Octal Hex");

            // For loop
            for (char ch = startChar; ch <= stopChar; ch++)
            {
                int decimalValue = (int)ch;
                string octalValue = Convert.ToString(decimalValue, 8);
                string hexValue = Convert.ToString(decimalValue, 16);

                Console.WriteLine($"{ch}      {decimalValue}     {octalValue}    {hexValue}");
            }
        }
    }
}
