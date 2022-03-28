using System;

namespace International
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

            int[] codes = { 100, 300, 200, 500, 1000, 600 };
            string[] countries = { "UK", "USA", "France", "Chile", "China", "Egypt" };

            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"Code: {codes[i]}\tCountry: {countries[i]}");
            }
        }
    }
}   