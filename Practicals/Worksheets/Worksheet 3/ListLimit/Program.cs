using System;

namespace ListLimit
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
            info("Question 11:");

            Console.Write("How many numbers do you want to enter: ");
            int amount = Int32.Parse(Console.ReadLine()!);

            List<int> values = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Enter integer {i}: ");
                values.Add(Int32.Parse(Console.ReadLine()!));
            }

            Console.WriteLine("You entered the following values: ");
            foreach (int value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            int total = values.Sum();
            Console.WriteLine($"The total was {total}.");

            Console.WriteLine($"The average was {((double) total) / amount}.");
        }
    }
}