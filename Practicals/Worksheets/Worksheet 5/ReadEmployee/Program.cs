using System;
using System.IO;
using System.Collections.Generic;

namespace ReadEmployee
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void RetrieveFileName(out string fileName)
        {
            Console.Write("Enter a file name: ");
            fileName = Console.ReadLine()!;
        }
        public static void FetchData(in string fileName, out int minimum, out int maximum, out double average)
        {
            using StreamReader reader = new StreamReader(fileName);

            List<int> salaries = new List<int>();

            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine()!.Split(",");
                salaries.Add(Int32.Parse(data[2]));
            }

            minimum = salaries.Min();
            maximum = salaries.Max();
            average = salaries.Average();
        }
        public static void PrintData(in int minimum, in int maximum, in double average)
        {
            Console.WriteLine($"The minimum salary is {minimum:C}");
            Console.WriteLine($"The maximum salary is {maximum:C}");
            Console.WriteLine($"The average salary is {average:C}");
        }
        public static void Main(string[] args)
        {
            info("Question 6:");
            
            string fileName;
            RetrieveFileName(out fileName);

            int minimum, maximum;
            double average;

            FetchData(fileName, out minimum, out maximum, out average);
            PrintData(minimum, maximum, average);
        }
    }
}