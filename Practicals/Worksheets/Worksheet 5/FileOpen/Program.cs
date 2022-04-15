using System;
using System.IO;

namespace FileOpen
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

                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
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
            info("Question 3:");

            string fileName;
            RetrieveFileName(out fileName);

            OutputData(fileName);
        }
    }
}