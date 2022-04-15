using System;
using System.IO;

namespace FileWrite
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
        public static void WriteToFile(in string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName);

            string input;
            while (true)
            {
                Console.Write("Enter some text: ");
                input = Console.ReadLine()!;
                if (input != "999")
                {
                    writer.WriteLine(input);
                }
                else
                {
                    break;
                }
            }
        }
        public static void Main(string[] args)
        {
            info("Question 5:");

            string fileName;

            RetrieveFileName(out fileName);
            WriteToFile(fileName);
        }
    }
}