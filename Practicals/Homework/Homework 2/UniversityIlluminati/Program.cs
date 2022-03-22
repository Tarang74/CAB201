using System;

namespace UniversityIlluminati
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void Main(string[] args)
        {
            info("Question 3:");

            Console.Write("Enter your test score: ");
            int testScore = Int32.Parse(Console.ReadLine()!);

            Console.Write("Enter your GPA: ");
            double gpa = Double.Parse(Console.ReadLine()!);

            if (testScore >= 85 && gpa >= 6.0) 
            {
                Console.WriteLine("Guaranteed membership");
            } else if (testScore >= 70 && gpa >= 6.0) 
            {
                Console.WriteLine("Almost guaranteed membership");
            } else if (testScore >= 70 && gpa >= 5.0) 
            {
                Console.WriteLine("A good change of membership");
            } else if (testScore >= 50 && gpa >= 4.0) 
            {
                Console.WriteLine("Cross your fingers");
            } else 
            {
                Console.WriteLine("Unlikely");
            }
        }
    }
}
