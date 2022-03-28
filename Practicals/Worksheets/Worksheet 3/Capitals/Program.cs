using System;

namespace Capitals
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

            string[,] capitals = {{ "NSW", "Sydney" },
                                  { "ACT", "Canberra" },
                                  { "VIC", "Melbourne" },
                                  { "QLD", "Brisbane" },
                                  { "SA", "Adelaide" },
                                  { "WA", "Perth" },
                                  { "TAS", "Hobart" },
                                  { "NT", "Darwin" }};

            for (int i = 0; i < capitals.GetLength(0); i++)
            {
                Console.WriteLine($"State: {capitals[i, 0]}\tCity: {capitals[i, 1]}");
            }
        }
    }
}