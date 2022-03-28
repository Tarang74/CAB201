using System;
using System.Linq;

namespace ArrayInteger
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void Main(string[] args)
        {
            info("Question 1:");

            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine($"The total is: {array.Sum()}");
        }
    }
}