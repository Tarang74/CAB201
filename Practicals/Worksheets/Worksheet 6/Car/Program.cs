using System;

namespace Question4
{
    class Car
    {
        public string model;
        public double litrePerKm;

        public Car(string _model, double _litrePerKm)
        {
            model = _model;
            litrePerKm = _litrePerKm;
        }
        public Car(string _model) : this(_model, 50) { }
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
            info("Question 4:");

            Car a = new Car("A", 84);
            Console.WriteLine(a.model);
            Console.WriteLine(a.litrePerKm);

            Car b = new Car("B");
            Console.WriteLine(b.model);
            Console.WriteLine(b.litrePerKm);
        }
    }
}