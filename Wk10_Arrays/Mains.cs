using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    internal class Mains
    {
        static Random rand = new Random();

        static void PrintCharArray(char[] array)
        {
            foreach (char item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] CreateIntArray(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return newArray;
        }

        static int[] CreateRandomIntArray(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = rand.Next(100, 201);
            }
            return newArray;
        }

        static char[] CreateRandomCharArray(int size)
        {
            char[] newArray = new char[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = (char)rand.Next('A', 'Z' + 1);
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            //Question 1
            Console.WriteLine("Printing letters array:");
            PrintCharArray(letters);

            Array.Reverse(letters);
            Console.WriteLine("Printing reversed letters array:");
            PrintCharArray(letters);

            // Question 3
            Console.WriteLine("\nPrinting poem array:");
            PrintStringArray(poem);

            Array.Sort(poem);
            Console.WriteLine("Printing sorted poem array:");
            PrintStringArray(poem);

            // Question 2
            Console.WriteLine("\nPrinting numbers array:");
            PrintIntArray(numbers);

            int position = Array.BinarySearch(numbers, 3);
            Console.WriteLine("Position of 3 in numbers array: " + position);

            // Question 5
            Array.Sort(numbers);
            Console.WriteLine("\nPrinting sorted numbers array:");
            PrintIntArray(numbers);

            //Question 6
            position = Array.BinarySearch(numbers, 3);
            Console.WriteLine("Position of 3 in sorted numbers array: " + position);

            // Question 7
            Console.Write("\nEnter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] userArray = CreateIntArray(size);
            Console.WriteLine("\nPrinting user-created array:");
            PrintIntArray(userArray);

            // Question 8
            Console.Write("\nEnter the size of the random array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] randomArray = CreateRandomIntArray(size);
            Console.WriteLine("\nPrinting random array:");
            PrintIntArray(randomArray);

            // Question 9
            Console.Write("\nEnter the size of the character array: ");
            size = Convert.ToInt32(Console.ReadLine());
            char[] randomCharArray = CreateRandomCharArray(size);
            Console.WriteLine("\nPrinting random character array:");
            PrintCharArray(randomCharArray);
        }
    }
}
