using System;

namespace LocateSymbol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            Console.WriteLine("Please enter a line of text:");
            string input = Console.ReadLine()!;

            int index1 = input.IndexOf('$');
            int index2 = input.LastIndexOf('$');

            Console.WriteLine($"The first and last positions of '$' are {index1} and {index2}, respectively.");

            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}