using System;

namespace DisplayRightAngleTriangle
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
            info("Question 6:");

            Console.Write("Enter the number of rows for your triangle: ");
            uint rows = UInt32.Parse(Console.ReadLine()!);

            uint i = 1;
            while (i <= rows)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                i++;
            }
        }
    }
}