using System;

namespace SwitchStatement
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
            Question6();
            Question7();
        }
        public static void Question6()
        {
            info("Question 6:");

            Console.Write("Enter a day number (starting at 0): ");
            int dayNumber = Int32.Parse(Console.ReadLine()!);

            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        public static void Question7()
        {
            info("Question 7:");

            Console.Write("Enter a month number (starting at 1): ");
            int monthNumber = Int32.Parse(Console.ReadLine()!);

            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Summer");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Autumn");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Winter");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Spring");
                    break;
                default:
                    Console.WriteLine("The data is out of range");
                    break;
            }
        }
    }
}
