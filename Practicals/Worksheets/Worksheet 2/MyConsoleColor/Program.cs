using System;

namespace MyConsoleColor
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
            info("Question 5:");

            Console.Write("Enter a background color [1 (red) | 2 (green) | 3 (yellow)]: ");
            string color = Console.ReadLine()!;

            switch (color) {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is red!");
                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("I love green!");
                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It was all yellow");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ResetColor();
        }
    }
}
