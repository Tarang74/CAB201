using System;

namespace FortuneTeller
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }

        public static void MyFortune()
        {
            Console.WriteLine("I see a tall, dark stranger in your future");
        }

        public static void Main(string[] args)
        {
            info("Question 2:");

            MyFortune();
        }
    }
}