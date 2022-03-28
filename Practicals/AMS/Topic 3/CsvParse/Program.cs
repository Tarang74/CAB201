using System;
using System.Linq;

namespace CsvParse
{
    public class Program
    {
        static void Main()
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            Console.WriteLine("Please enter a several comma-separated integer values:");
            string input = Console.ReadLine()!;
            Console.WriteLine("---------------------------");
            
            if (input.Length == 0) 
            {
                Console.WriteLine("The supplied list is empty.");
            } 
            else
            {
                string[] csv = input.Split(",").Where(x => !string.IsNullOrEmpty(x)).ToArray();
                for (int i = 0; i < csv.Length; i++)
                {
                    int val = Int32.Parse(csv[i]);
                    Console.WriteLine($"{val} squared is {Math.Pow(val, 2)}.");
                }
            }

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}