using System;
using System.Linq;

namespace Workday
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
            info("Question 3:");

            Console.Write("How many activities did you complete today: ");
            int activities = Int32.Parse(Console.ReadLine()!);

            string[] names = new string[activities];
            int[] hours = new int[activities];

            for (int i = 0; i < activities; i++)
            {
                Console.WriteLine($"Activity {i}:");

                Console.Write("What was the activities name: ");
                names[i] = Console.ReadLine()!;

                Console.Write("How long did you work on the activity: ");
                hours[i] = Int32.Parse(Console.ReadLine()!);
            }

            int total = hours.Sum();
            int missing = 24 - total;

            if (missing < 0)
            {
                Console.WriteLine("Total number of hours exceed 24.");
            }
            else
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("|      Task      | Hours |   Percentage   |");
                Console.WriteLine("-------------------------------------------");

                for (int i = 0; i < activities; i++)
                {
                    Console.WriteLine($"| {names[i],14} |  {hours[i],2}   | {hours[i] / 24.0:F12} |");
                    Console.WriteLine("-------------------------------------------");
                }

                if (missing > 0)
                {
                    Console.WriteLine($"| {"Missing",14} |  {missing,2}   | {missing / 24.0:F12} |");
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }
    }
}