using System;
using System.Linq;

namespace Average
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static double AverageArray(double[] array)
        {
            return array.Sum() / array.Length;
        }
        public static void Main(string[] args)
        {
            info("Question 4:");

            double[] array = { 1, 2, 3, 4 };
            Console.WriteLine($"The average is: {AverageArray(array)}");
        }
    }
}