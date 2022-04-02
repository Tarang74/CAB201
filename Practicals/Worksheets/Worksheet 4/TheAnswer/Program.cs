using System;

namespace TheAnswer
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }

        public static void TheQuestion()
        {
            Console.WriteLine(42);
        }

        public static void Main(string[] args)
        {
            info("Question 1:");

            TheQuestion();
        }
    }
}