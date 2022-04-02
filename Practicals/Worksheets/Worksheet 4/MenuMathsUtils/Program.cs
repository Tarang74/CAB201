using System;

namespace MenuMathsUtils
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static int MenuItems(string[] operators)
        {
            Console.WriteLine("Choose an operation:");
            foreach (string s in operators) Console.WriteLine(s);

            int input = Int32.Parse(Console.ReadLine()!);

            if (input > 0 && input < 5) return input;
            return 5;
        }
        public static void EnterNumbers(out double a, out double b)
        {
            Console.Write("Enter a value for a: ");
            a = Double.Parse(Console.ReadLine()!);

            Console.Write("Enter a value for b: ");
            b = Double.Parse(Console.ReadLine()!);

        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return (double) a / b;
        }
        public static void Output(double value)
        {
            Console.WriteLine($"The output is {value}");
        }
        public static void Main(string[] args)
        {
            info("Question 12:");

            string[] operators = { "1. Sum", "2. Minus", "3. Multiply", "4. Divide", "5. Quit" };
            int item = MenuItems(operators);
            
            double a, b;
            EnterNumbers(out a, out b);

            double output;

            if (item < 5)
            {
                switch (item)
                {
                    case 1:
                        output = Sum(a, b);
                        break;
                    case 2:
                        output = Minus(a, b);
                        break;
                    case 3:
                        output = Multiply(a, b);
                        break;
                    default:
                        output = Divide(a, b);
                        break;
                }
                Output(output);
            }
        }
    }
}