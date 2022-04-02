using System;

namespace University
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static string Administration(double GPA)
        {
            if (GPA >= 69.5)
            {
                return "Accepted";
            }
            return "Rejected";
        }
        public static void Main(string[] args)
        {
            info("Question 2:");

            Console.Write("Enter your GPA (out of 100): ");
            double GPA = Double.Parse(Console.ReadLine()!);

            Console.WriteLine(Administration(GPA));
        }
    }
}