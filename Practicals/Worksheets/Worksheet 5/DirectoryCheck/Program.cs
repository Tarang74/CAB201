using System;
using System.IO;

namespace DirectoryCheck
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void RetrieveDirectoryName(out string directoryName)
        {
            directoryName = Console.ReadLine()!;
        }
        public static bool CheckIfExists(in string directoryName)
        {
            return File.Exists(directoryName);
        }
        public static void Main(string[] args)
        {
            info("Question 2:");

            string directoryName;
            RetrieveDirectoryName(out directoryName);

            if (CheckIfExists(directoryName))
            {
                DirectoryInfo directory = new DirectoryInfo(directoryName);
                Console.WriteLine($"{"Creation time",25}  {"Last written",25}  {"Last accessed",25}");
                Console.WriteLine($"{directory.CreationTime,25}  {directory.LastWriteTime,25}  {directory.LastAccessTime,25}");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
    }
}