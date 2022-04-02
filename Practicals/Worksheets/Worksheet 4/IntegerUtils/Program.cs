using System;
using System.Collections.Generic;

namespace IntegerUtils
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }

        public static int FindFirst(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return i;
            }
            return -1;
        }
        public static int FindLast(int[] array, int value)
        {
            for (int i = array.Length - 1; i > -1; i--)
            {
                if (array[i] == value) return i;
            }
            return -1;
        }
        public static int[] FindAll(int[] array, int value)
        {
            List<int> found = new List<int>{};
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) found.Add(i);
            }
            return found.ToArray();
        }
        public static void Main(string[] args)
        {
            info("Question 7:");

            int[] array = { 5, 1, 4, 1, 3, 5, 9, 0, 1, 4, 4 };
            Console.WriteLine($"First index of 1: {FindFirst(array, 1)}");
            Console.WriteLine($"Last index of 1: {FindFirst(array, 1)}");

            int[] allFound = FindAll(array, 1);
            Console.WriteLine("All indices of 1:");
            foreach (int f in allFound) Console.WriteLine(f);
        }
    }
}