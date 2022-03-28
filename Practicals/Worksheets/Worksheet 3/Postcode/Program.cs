using System;

namespace Postcode
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
            info("Question 7:");

            string[] cities = { "Sydney", "Canberra", "Melbourne", "Brisbane", "Adelaide", "Perth", "Hobart", "Darwin" };
            string[] codes = { "2000", "2600", "3000", "4000", "5000", "6000", "7000", "0800" };

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"City: {cities[i]}\tCode: {codes[i]}");
            }
        }
    }
}