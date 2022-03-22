using System;

namespace CheckScore
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
            info("Question 2:");

            Console.Write("Enter a score from 0-100: ");
            int score = Int32.Parse(Console.ReadLine()!);

            // Note this solution is intentionally using nested if statements,
            // a better approach would be cascading if statements.
            if (score <= 100)
            {
                if (score <= 75)
                {
                    if (score <= 50)
                    {
                        if (score > 0)
                        {
                            Console.WriteLine("C");
                        }
                    } else 
                    {
                        Console.WriteLine("B");
                    }
                } else 
                {   
                    Console.WriteLine("A");
                }
            }
        }
    }
}