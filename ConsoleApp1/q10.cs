using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a C program that continuously requests a grade.
If the grade is less than 0 or greater than 100, your program should
print an appropriate message informing the user that an invalid
grade has been entered,
else the grade should be added to a total.*/

namespace ConsoleApp1
{
    internal class Q10
    {
        public static void q10() 
        {
            double total = 0;
            int count = 0;

            Console.WriteLine("Enter grades (999 to finish): ");

            // For loop
            for (; ; )
            {
                double grade = Convert.ToDouble(Console.ReadLine());

                if (grade == 999)
                {
                    break;
                }
                else if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
                    continue;
                }

                total += grade;
                count++;
            }

            if (count > 0)
            {
                double average = total / count;
                Console.WriteLine($"Sum of all valid grades: {total}");
                Console.WriteLine($"Number of valid grades: {count}");
                Console.WriteLine($"Average of valid grades: {average:F2}");
            }
            else
            {
                Console.WriteLine("No valid grades were entered.");
            }

            Console.WriteLine("\nEnter grades (999 to finish) using a while loop: ");

            // While loop
            total = 0;
            count = 0;
            double gradeInput;

            while ((gradeInput = Convert.ToDouble(Console.ReadLine())) != 999)
            {
                if (gradeInput < 0 || gradeInput > 100)
                {
                    Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
                    continue;
                }

                total += gradeInput;
                count++;
            }

            if (count > 0)
            {
                double average = total / count;
                Console.WriteLine($"Sum of all valid grades: {total}");
                Console.WriteLine($"Number of valid grades: {count}");
                Console.WriteLine($"Average of valid grades: {average:F2}");
            }
            else
            {
                Console.WriteLine("No valid grades were entered.");
            }
        }
    }
}
