using System;

namespace UserSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following lines intact 
            Console.WriteLine("===========================");

            const int SENTINEL = 999;
            string PROMPT = $"Please enter a value to process, or {SENTINEL} to finish:";
            const string OUT_FORMAT = "The sum is {0}.";

            int runningTotal = 0;

            // Insert your solution here.
            int i = 0;

            do {
                runningTotal += i;
                Console.WriteLine(PROMPT);
                i = Convert.ToInt32(Console.ReadLine()!);
            } while (i != SENTINEL);

            // Keep the following lines intact
            Console.WriteLine(OUT_FORMAT, runningTotal);
            Console.WriteLine("===========================");
        }
    }
}