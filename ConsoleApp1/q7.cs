using System;
using System.ComponentModel;

/* Write a program to produce a table 
 * of numbers from 10 to 1, with their
 * squares and cubes. Again,your table
 * must look professional!*/

class Q7
{
    static void q7()
    {
        int number, square, cube;

        Console.WriteLine("Table of Numbers, Squares, and Cubes");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| Number | Square |  Cube  |");
        Console.WriteLine("------------------------------------");

        // Using while loop
        number = 10;
        while (number >= 1)
        {
            square = number * number;
            cube = number * number * number;

            Console.WriteLine($"|   {number,-4} |   {square,-5} |   {cube,-5} |");

            number--;
        }

        Console.WriteLine("------------------------------------");

        // Using for loop
        Console.WriteLine("\nTable of Numbers, Squares, and Cubes (Using for loop)");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| Number | Square |  Cube  |");
        Console.WriteLine("------------------------------------");

        for (number = 10; number >= 1; number--)
        {
            square = number * number;
            cube = number * number * number;

            Console.WriteLine($"|   {number,-4} |   {square,-5} |   {cube,-5} |");
        }

        Console.WriteLine("------------------------------------");
    }
}
