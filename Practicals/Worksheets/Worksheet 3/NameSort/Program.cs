using System;

namespace NameSort
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
            info("Question 5:");

            Console.Write("How many names: ");
            int nameLength = Int32.Parse(Console.ReadLine()!);

            string[] names = new string[nameLength];

            for (int i = 0; i < nameLength; i++)
            {
                Console.Write($"Enter name {i}: ");
                names[i] = Console.ReadLine()!;
            }

            Array.Sort<string>(names);

            Console.WriteLine("Sorted names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}