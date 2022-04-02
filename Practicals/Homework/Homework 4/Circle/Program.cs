using System;

namespace Circle
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void GetCircleDetails(in double radius, out double diameter, out double circumference, out double area)
        {
            diameter = 2 * radius;
            circumference = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
        }
        public static void Main(string[] args)
        {
            info("Question 4:");

            double radius = 10.0;
            double diameter, circumference, area;
            GetCircleDetails(radius, out diameter, out circumference, out area);

            Console.WriteLine($"A circle of with radius {radius} has a diameter {diameter}, circumference {circumference}, and area {area}.");
        }
    }
}