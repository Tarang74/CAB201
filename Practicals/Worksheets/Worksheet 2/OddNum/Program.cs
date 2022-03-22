using System;

namespace OddNum
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
            info("Question 11:");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(2 * i + 1);
            }
        }
    }
}