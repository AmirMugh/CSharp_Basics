namespace Wk09_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            int sum, inputCount, sumOfSquares, sumOfCubes;
            double average;

            while (true)
            {
                DisplayMenu();
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '0':
                        Console.WriteLine("Exiting program...");
                        return;
                    case '3':
                        Console.WriteLine("Calculating sum...");
                        sum = CalculateSum(5);
                        Console.WriteLine("Sum: " + sum);
                        break;
                    case '4':
                        Console.WriteLine("Calculating sum of squares...");
                        Console.Write("Enter the number of inputs: ");
                        inputCount = Convert.ToInt32(Console.ReadLine());
                        sumOfSquares = CalculateSumOfSquares(inputCount);
                        Console.WriteLine("Sum of squares: " + sumOfSquares);
                        break;
                    case '5':
                        Console.WriteLine("Calculating sum of cubes...");
                        sumOfCubes = CalculateSumOfCubes();
                        Console.WriteLine("Sum of cubes: " + sumOfCubes);
                        break;
                    case '6':
                        Console.WriteLine("Calculating average...");
                        average = CalculateAverage();
                        Console.WriteLine("Average: " + average);
                        break;
                    case '7':
                        Console.WriteLine("Displaying equation table...");
                        DisplayEquation();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Enter the number that corresponds to your choice: \n");
            Console.WriteLine("-------Calculation Menu-------");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("6) Calculate Average");
            Console.WriteLine("7) Display Equation Table");
            Console.WriteLine("0) To Exit");
        }

        static int CalculateSum(int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            return sum;
        }

        static int CalculateSumOfSquares(int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num * num;
            }
            return sum;
        }

        static int CalculateSumOfCubes()
        {
            Console.Write("Enter the number of inputs: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num * num * num;
            }
            return sum;
        }

        static double CalculateAverage()
        {
            Console.Write("Enter the number of inputs: ");
            int count = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            return sum / count;
        }

        static void DisplayEquation()
        {
            Console.WriteLine("x\t5\t3x\t-2x^2\ty");
            for (double x = 0.0; x <= 2.0; x += 0.25)
            {
                double y = 5 +33 3 * x - 2 * x * x;
                Console.WriteLine($"{x}\t{5}\t{3 * x}\t{-2 * x * x}\t{y}");
            }
        }
    }
}
