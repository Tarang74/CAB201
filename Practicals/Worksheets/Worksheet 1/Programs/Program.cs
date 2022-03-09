using System;

namespace Programs
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
            Question8();
            Question9();
            Question10();
        }

        public static void Question8()
        {
            info("Question 8:");

            Console.WriteLine("Hello World! CAB201 Rules");
        }
        public static void Question9()
        {
            info("Question 9:");

            int a = 5;
            int b = 10;
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }
        public static void Question10()
        {
            info("Question 10:");

            int a = 5;
            int b = 10;
            Console.WriteLine($"The product of {a} and {b} is {a * b}");
        }
    }
}
