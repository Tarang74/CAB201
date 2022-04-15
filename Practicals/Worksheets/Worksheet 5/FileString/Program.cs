using System;
using System.IO;

namespace FileString
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

            string fileName = "output.txt";
            string contents = "In fairytales, witches always wear silly black hats and black coats, and they ride on broomsticks. But this is not a fairy-tale. This is about REAL WITCHES.";

            using StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(contents);
        }
    }
}