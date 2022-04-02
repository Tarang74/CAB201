using System;

namespace Library
{
    class Program
    {
        const int fiveDayFine = 5;
        const int tenDayFine = 10;
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static double LibraryFine(int[] daysLate)
        {
            int fine = 0;

            foreach (int day in daysLate)
            {
                if (day > 10)
                {
                    fine += tenDayFine;
                }
                else
                {
                    fine += fiveDayFine;
                }
            }

            return fine;
        }
        public static void Main(string[] args)
        {
            info("Question 3:");

            int[] daysLate = { 3, 5, 16, 6, 8, 9 };

            double totalFine = LibraryFine(daysLate);
            Console.WriteLine($"You owe the library {totalFine:C}.");
        }
    }
}