using System;

namespace EnterUppercaseLetters
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
            info("Question 9:");

            char c = (char)0;

            while (true)
            {
                Console.Write("Enter a single lowercase or uppercase letter (! to exit): ");
                c = Char.Parse(Console.ReadLine()!);
                if (c == '!')
                {
                    break;
                }
                else if (65 <= c & c <= 90)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}