using System;

namespace Multiplication
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
            info("Question 10:");

            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine($"The product of {a} and {b} is {a * b}");
        }
    }
}
