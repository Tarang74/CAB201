using System;

namespace PhoneRates
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

            double[,] areaRates = {{ 100, 0.70 },
                                   { 200, 0.10 },
                                   { 300, 0.05 },
                                   { 400, 0.16 },
                                   { 500, 0.24 },
                                   { 600, 0.30 }};

            for (int i = 0; i < areaRates.GetLength(0); i++)
            {
                Console.WriteLine($"Area Code: {areaRates[i, 0]}\tRate: {areaRates[i, 1]}");
            }
        }
    }
}