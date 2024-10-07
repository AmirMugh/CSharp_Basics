using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalRevision
{
    internal class Mains
    {
        //Part I
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Name: Amir\nSchool: Centennial College\nProgram and Favorite: COMP100");
        }

        static void CalculateTuition()
        {
            Console.Write("Enter the number of courses you are currently taking: ");
            int numberOfCourses = Convert.ToInt32(Console.ReadLine());

            double tuitionCost = numberOfCourses * 569.99;

            Console.WriteLine($"Tuition cost for {numberOfCourses} courses: ${tuitionCost}");
        }

        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Area of the circle with radius {radius}: {area}");
        }

        static void CalculateAreaOfTriangle()
        {
            Console.Write("Enter the base of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseLength * height;

            Console.WriteLine($"Area of the triangle with base {baseLength} and height {height}: {area}");
        }

        static void CalculateSaleCommission()
        {
            const double comission = 0.25;

            Console.Write("Enter your sales figure: ");
            double salesFigure = Convert.ToDouble(Console.ReadLine());

            if (salesFigure >= 1000) 
            {
                double total = salesFigure * comission;

                Console.WriteLine($"Comission taken, a total of {total} was taken.");
            } else
            {
                double total = salesFigure;
                Console.WriteLine($"No comission, total: {total}");
            }

        }

        static void DisplaySineTable(double startValue, double stepSize, int numberOfRows)
        {
            Console.WriteLine("Angle   |  Sine Value");
            Console.WriteLine("----------------------");
            for (int i = 0; i < numberOfRows; i++)
            {
                double angle = startValue + i * stepSize;
                double sineValue = Math.Sin(angle);
                Console.WriteLine($"{angle,6:F2}  |  {sineValue,8:F4}");
            }
        }

        static void DisplayMenu() 
        {
            Console.WriteLine("=============Narendra's Computer Systems==================");
            Console.WriteLine("|         1. Display Personal Information                |");
            Console.WriteLine("|         2. Calculate Tuition                           |");
            Console.WriteLine("|         3. Calculate Area Of A Circle                  |");
            Console.WriteLine("|         4. Calculate The Area Of A Triangle            |");
            Console.WriteLine("|         5. Calculate Sales Commission                  |");
            Console.WriteLine("|         6. Display Sine Table                          |");
            Console.WriteLine("|         0. End program                                 |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Enter the number of your choice ->");
        }

        static void ShowMenu()
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayPersonalInfo();
                        break;
                    case 2:
                        CalculateTuition();
                        break;
                    case 3:
                        CalculateAreaOfCircle();
                        break;
                    case 4:
                        CalculateAreaOfTriangle();
                        break;
                    case 5:
                        CalculateSaleCommission();
                        break;
                    case 6:
                        //DisplaySineTable();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        //Part II
        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
        }

        static void CalculateSphereVolume(double radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Volume of sphere with radius {radius}: {volume:F4}");
        }

        static void CalculateSellingPrice(double costPrice, string provinceCode)
        {
            double sellingPrice;
            switch (provinceCode.ToUpper())
            {
                case "ON":
                    sellingPrice = costPrice * 1.13;
                    break;
                case "QC":
                    sellingPrice = costPrice * 1.17;
                    break;
                default:
                    sellingPrice = costPrice;
                    break;
            }
            Console.WriteLine($"Selling price in {provinceCode}: {sellingPrice:C}");
        }

        static void DisplayConversionTable(double startCelsius)
        {
            Console.WriteLine("Celsius   |   Fahrenheit");
            Console.WriteLine("------------------------");
            for (int i = 0; i < 10; i++)
            {
                double celsius = startCelsius + i;
                double fahrenheit = (9.0 / 5.0) * celsius + 32;
                Console.WriteLine($"{celsius,-9:F1} |   {fahrenheit:F1}");
            }
        }

        static void DisplayKmToMilesTable(double startKm, double increment, int numberOfLines)
        {
            Console.WriteLine("Kilometers   |   Miles");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < numberOfLines; i++)
            {
                double km = startKm + i * increment;
                double miles = km * 0.621371;
                Console.WriteLine($"{km,-12:F2} |   {miles:F2}");
            }
        }

        static void ConvertHeight(int centimeters)
        {
            int meters = centimeters / 100;
            int remainingCentimeters = centimeters % 100;
            Console.WriteLine($"{centimeters}cm   {meters}m {remainingCentimeters}cm");
        }


        public static void Main(string[] args) 
        {
            //ShowMenu();

            //Question 1: DisplayHorizontalStars
            Console.WriteLine("Task 1:");
            DisplayHorizontalStars(0);
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
            Console.WriteLine();

            //Question 2: DisplayVerticalStars
            Console.WriteLine("Task 2:");
            DisplayVerticalStars(0);
            DisplayVerticalStars(5);
            DisplayVerticalStars(10);
            Console.WriteLine();

            //Question 3: CalculateSphereVolume
            Console.WriteLine("Task 3:");
            CalculateSphereVolume(1);
            CalculateSphereVolume(2);
            CalculateSphereVolume(10);
            Console.WriteLine();

            //Question 4: CalculateSellingPrice
            Console.WriteLine("Task 4:");
            CalculateSellingPrice(100, "ON");
            CalculateSellingPrice(100, "QC");
            CalculateSellingPrice(100, "AB");
            Console.WriteLine();

            //Question 5: DisplayConversionTable
            Console.WriteLine("Task 5:");
            DisplayConversionTable(0);
            Console.WriteLine();
            DisplayConversionTable(20);
            Console.WriteLine();

            //Question 6: DisplayKmToMilesTable
            Console.WriteLine("Task 6:");
            DisplayKmToMilesTable(0, 10, 5);
            Console.WriteLine();
            DisplayKmToMilesTable(50, 5, 4);
            Console.WriteLine();
            DisplayKmToMilesTable(100, 20, 3);
            Console.WriteLine();

            //Question 7: Modified DisplaySineTable
            Console.WriteLine("Task 7:");
            DisplaySineTable(0, 0.1, 10);
            Console.WriteLine();
            DisplaySineTable(1, 0.2, 8);
            Console.WriteLine();

            //Question 8: ConvertHeight
            Console.WriteLine("Task 8:");
            ConvertHeight(90);
            ConvertHeight(120);
            ConvertHeight(275);
        }
    }
}
