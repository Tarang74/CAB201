using System;

namespace MicroBlog
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

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()!);

            if (age >= 65)
            {
                Console.WriteLine("Enjoy your retirement");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Fancy an alcoholic beverage");
            }
            else if (age >= 16)
            {
                Console.WriteLine("You're old enough to drive");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink or retire");
            }
        }
    }
}