using System;

namespace ArrayDoubleSort
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
            info("Question 4:");

            Console.WriteLine("Enter 10 values: ");
            
            double[] values = new double[10];
            for (int i = 0; i < values.Length; i++) 
            {
                Console.Write($"Enter value {i}: ");
                values[i] = Double.Parse(Console.ReadLine()!);
            }

            Array.Sort<double>(values);

            Console.WriteLine("Sorted values: ");
            foreach (double value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}