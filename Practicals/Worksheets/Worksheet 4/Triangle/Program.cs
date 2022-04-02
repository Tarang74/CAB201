using System;

namespace Triangle
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void GetTriangleDetails(in double sideLength, out double perimeter, out double area)
        {
            perimeter = 3 * sideLength;
            area = sideLength * sideLength * Math.Sqrt(3) / 4.0;
        }
        public static void Main(string[] args)
        {
            info("Question 10:");

            double sideLength = 10.0;
            double perimeter, area;
            GetTriangleDetails(sideLength, out perimeter, out area);

            Console.WriteLine($"A triangle of side length {sideLength} has a perimeter {perimeter} and area {area}.");
        }
    }
}