using System;

namespace SumFiveInts
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
            info("Question 5:");

            int total = 0;

            for (int i = 0; i < 5; i++) 
            {
                if (i == 0)
                {
                    Console.Write("Enter the first integer: ");
                } else if (i == 4)
                {
                    Console.Write("Enter the final integer: ");
                } else 
                {
                    Console.Write("Enter another integer: ");
                }
                total += Int32.Parse(Console.ReadLine()!);
            }

            Console.WriteLine($"The total is {total}.");
        }
    }
}