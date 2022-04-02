using System;

namespace SortMyArray
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }

        public static void MySort(ref int[] array)
        {
            Array.Sort(array);
        } 

        public static void Main(string[] args)
        {
            info("Question 5:");

            int[] array = { 5, 2, 4, 1 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            
            MySort(ref array);

            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        }
    }
}