using System;

namespace CheckPostcodes
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
            info("Question 3:");

            string[] postcodes = { "1243", "5612", "4182", "5163", "1222", "1092", "1546", "7845", "6387", "2548" };

            Console.Write("Guess a four digit postcode: ");
            
            if (postcodes.Contains(Console.ReadLine()!)) Console.WriteLine("Success"); else Console.WriteLine("Error");
        }
    }
}