using System;

namespace DailyDownloads
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
            info("Question 4:");

            Console.Write("Enter the number of downloads: ");
            int downloads = int.Parse(Console.ReadLine()!);

            if (downloads < 100)
            {
                Console.WriteLine("Daily downloads: < 100");
            }
            else if (downloads <= 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000");
            }
            else if (downloads <= 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000");
            }
            else if (downloads <= 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+");
            }
        }
    }
}
