using System;

namespace CountDown
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
            info("Question 8:");

            int i = 1000;

            do
            {
                Console.Write($"Enter a number to subtract from {i}: ");
                i -= Int32.Parse(Console.ReadLine()!);
            } while (i >= 0);
        }
    }
}
