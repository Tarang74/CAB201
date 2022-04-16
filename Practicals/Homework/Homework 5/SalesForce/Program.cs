using System;

namespace SalesForce
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void RetrieveFileName(out string fileName)
        {
            Console.Write("Enter a file name: ");
            fileName = Console.ReadLine()!;
        }
        public static bool OutputData(in string fileName)
        {
            if (File.Exists(fileName))
            {
                using StreamReader reader = new StreamReader(fileName);

                Console.WriteLine($"Phil Joe Jenny");
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine()!.Split(", ");
                    Console.WriteLine($"{Int32.Parse(data[0]),4} {Int32.Parse(data[1]),3} {Int32.Parse(data[2]),5}");
                }
                return true;
            }
            else
            {
                return false;
            };
        }
        public static void Main(string[] args)
        {
            info("Question 1:");

            string fileName;
            RetrieveFileName(out fileName);

            OutputData(fileName);
        }
    }
}