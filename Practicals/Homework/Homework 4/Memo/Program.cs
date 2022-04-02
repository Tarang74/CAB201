using System;

namespace Memo
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void MemoHeader()
        {
            Console.WriteLine("C# Software Developer");
        }
        public static void Main(string[] args)
        {
            info("Question 1:");

            MemoHeader();
        }
    }
}