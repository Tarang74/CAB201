using System;
using System.IO;

namespace FileCheck
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
        public static bool CheckIfExists(in string fileName)
        {
            return File.Exists(fileName);
        }
        public static void Main(string[] args)
        {
            info("Question 1:");

            string fileName;
            RetrieveFileName(out fileName);

            if (CheckIfExists(fileName))
            {
                FileInfo file = new FileInfo(fileName);
                Console.WriteLine($"{"Creation time",25}  {"Last written",25}  {"Last accessed",25}");
                Console.WriteLine($"{file.CreationTime,25}  {file.LastWriteTime,25}  {file.LastAccessTime,25}");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}