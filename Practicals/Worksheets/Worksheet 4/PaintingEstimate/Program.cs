using System;

namespace PaintingEstimate
{
    class Program
    {
        const int costPerM2 = 10;
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void GetInputs(out double width, out double length, out double height)
        {
            Console.Write("Enter the rooms width: ");
            width = Double.Parse(Console.ReadLine()!);

            Console.Write("Enter the rooms length: ");
            length = Double.Parse(Console.ReadLine()!);

            Console.Write("Enter the rooms height: ");
            height = Double.Parse(Console.ReadLine()!);
        }
        public static double PaintRoom(in double width, in double length, in double height)
        {
            return 2 * height * (width + length) * costPerM2;
        }
        public static void OutputPainting(double cost)
        {
            Console.WriteLine($"The cost of the paint is {cost:C}");
        }
        public static void Main(string[] args)
        {
            info("Question 11:");

            double width, length, height;
            GetInputs(out width, out length, out height);
            
            double cost = PaintRoom(width, length, height);

            OutputPainting(cost);
        }
    }
}