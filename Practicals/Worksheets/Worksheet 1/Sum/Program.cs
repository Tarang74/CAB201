using System;

namespace Programs
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
            info("Question 9:");

            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.Read());
            Console.Write("Enter another number: ");
            int b = Convert.ToInt32(Console.Read());

            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }
    }
}
