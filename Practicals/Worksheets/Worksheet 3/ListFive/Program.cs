using System;
using System.Collections.Generic;

namespace ListFive
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
            info("Question 10:");

            List<int> list = new List<int>{ 0, 1, 2, 3, 4 };

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}