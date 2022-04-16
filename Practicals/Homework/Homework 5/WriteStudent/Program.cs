using System;

namespace WriteStudent
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

            string studentNumber, name, gpa, year;
            Console.WriteLine("Type 'STOP' anytime to stop.");

            while (true)
            {
                Console.Write("Enter a student number: ");
                studentNumber = Console.ReadLine()!;
                if (studentNumber == "STOP") break;
             
                Console.Write("Enter a name: ");
                name = Console.ReadLine()!;
                if (name == "STOP") break;
                
                Console.Write("Enter a gpa: ");
                gpa = Console.ReadLine()!;
                if (gpa == "STOP") break;
                
                Console.Write("Enter a year: ");
                year = Console.ReadLine()!;
                if (year == "STOP") break;

                writer.WriteLine($"{studentNumber},{name},{gpa},{year}");
            }
        }
        public static void Main(string[] args)
        {
            info("Question 2:");

            string fileName;
            RetrieveFileName(out fileName);
            WriteToFile(fileName);
        }
    }
}