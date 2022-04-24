using System;

namespace Question9
{
    class Circle
    {
        public double Area { get; private set; }
        public double Diameter { get; private set; }
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                Area = Math.PI * radius * radius;
                Diameter = 2 * radius;
            }
        }
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public void TestCircle()
        {
            Console.WriteLine($"Radius: {Radius} Area: {Area:F2} Diameter: {Diameter:F2}");
        }
    }
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
            info("Question 9:");

            Circle a = new Circle(1);
            a.TestCircle();

            a.Radius = 2;
            a.TestCircle();
        }
    }
}