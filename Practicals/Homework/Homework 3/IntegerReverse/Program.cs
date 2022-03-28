using System;

namespace IntegerReverse
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

            Console.Write("How many integers: ");
            int amount = Int32.Parse(Console.ReadLine()!);

            int[] values = new int[amount];

            for (int i = 0; i < values.Length; i++) 
            {
                Console.Write($"Enter value {i}: ");
                values[i] = Int32.Parse(Console.ReadLine()!);
            }

            Array.Reverse<int>(values);

            Console.WriteLine("Reversed values: ");
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}