using System;
using System.Collections.Generic;

namespace RemoveList
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
            info("Question 12:");

            Console.Write("How many numbers do you want to enter: ");
            int amount = Int32.Parse(Console.ReadLine()!);

            List<int> values = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Enter integer {i}: ");
                values.Add(Int32.Parse(Console.ReadLine()!));
            }

            while (values.Count > 0)
            {
                Console.WriteLine("Currently the array contains the following values: ");
                foreach (int value in values)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();

                Console.Write("Enter a value you would like to remove: ");
                values.Remove(Int32.Parse(Console.ReadLine()!));
            }
        }
    }
}