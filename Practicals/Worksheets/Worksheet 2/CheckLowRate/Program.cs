using System;

namespace CheckLowRate
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
            info("Question 2:");

            Console.Write("Enter an hourly rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine()!);

            if (hourlyRate >= 19.84)
            {
                Console.WriteLine("Rate is above the minimum");
            }
        }
    }
}