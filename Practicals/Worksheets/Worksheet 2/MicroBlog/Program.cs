using System;

namespace MicroBlog
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

            Console.Write("Enter some text: ");
            string input = Console.ReadLine()!;
            int inputLen = input.Length;

            if (inputLen < 140)
            {
                Console.WriteLine("Success");
            }
        }
    }
}