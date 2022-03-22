using System;

namespace AllDigits
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

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}