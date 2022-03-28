using System;

namespace WorkshopAttendance
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

            Console.Write("How many workshops are there: ");
            int workshops = Int32.Parse(Console.ReadLine()!);

            int[] attending = new int[workshops];
            int[] capacity = new int[workshops];

            for (int i = 0; i < workshops; i++)
            {
                Console.WriteLine($"Workshop {i}:");

                Console.Write("How many people are attending the workshop: ");
                attending[i] = Int32.Parse(Console.ReadLine()!);

                Console.Write("What is the maximum capacity of the workshop: ");
                capacity[i] = Int32.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("=========================");
            Console.WriteLine("| Attendance | Capacity |");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < workshops; i++)
            {
                Console.Write($"| {attending[i],10} | {capacity[i],8} |");
                if (attending[i] > capacity[i])
                {
                    Console.Write(" Exceeds capacity\n");
                }
                else
                {
                    Console.Write("\n");
                }
                Console.WriteLine("-------------------------");
            }
        }
    }
}