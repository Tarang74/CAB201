using System;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Keep the following lines intact 
            Console.WriteLine("===========================");

            const string PROMPT = "Please enter the value of limit (between 1 and 27 inclusive):";
            const string OUT_FORMAT = "{0} factorial is {1}.";

            Console.WriteLine(PROMPT);
            string userInput = Console.ReadLine()!;
            decimal limit = decimal.Parse(userInput);

            decimal factorial = 1;

            // Insert your solution here.
            for (decimal i = limit; i > 0; i--)
            {
                factorial *= i;
            }

            // Keep the following lines intact
            Console.WriteLine(OUT_FORMAT, limit, factorial);
            Console.WriteLine("===========================");
        }
    }
}