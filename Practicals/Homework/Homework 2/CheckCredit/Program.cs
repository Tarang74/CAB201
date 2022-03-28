using System;

namespace CheckCredit
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
            info("Question 1:");

            const int creditLimit = 8000;

            Console.Write("Enter a purchase price: ");
            double purchasePrice = Double.Parse(Console.ReadLine()!);

            if (purchasePrice > creditLimit) 
            {
                Console.WriteLine("Error - Purchase price is greater than credit");
            } else if (purchasePrice > 0)
            {
                Console.WriteLine("Approved");
            }
        }
    }
}