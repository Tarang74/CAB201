using System;

namespace ArrayApplication
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static int[,] ArrayDetails()
        {
            Console.Write("How many rows: ");
            int rows = Int32.Parse(Console.ReadLine()!);

            Console.Write("How many columns: ");
            int cols = Int32.Parse(Console.ReadLine()!);

            return new int[rows, cols];
        }
        public static void EnterArray(ref int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Update the entry in position ({i + 1}, {j + 1}): ");
                    array[i, j] = Int32.Parse(Console.ReadLine()!);
                }
            }
        }
        public static string DisplayArray(in int[,] array)
        {
            string output = "{";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                output += "\n\t{";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    output += $"{array[i, j]}";
                    if (j != array.GetLength(1) - 1)
                    {
                        output += ", ";
                    }
                }
                output += "}";
            }
            output += "\n}";

            Console.WriteLine(output);
            return output;
        }
        public static void EnterFilename(out string fileName)
        {
            Console.Write("Enter a file name: ");
            fileName = Console.ReadLine()!;
        }
        public static void PrintArray(in string fileName, in string output)
        {
            using StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(output);
        }
        public static void Main(string[] args)
        {
            info("Question 3:");

            int[,] array = ArrayDetails();
            EnterArray(ref array);
            
            string arrayString = DisplayArray(array);

            string fileName;
            EnterFilename(out fileName);

            PrintArray(fileName, arrayString);
        }
    }
}