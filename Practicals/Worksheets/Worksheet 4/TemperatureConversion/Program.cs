using System;

namespace TemperatureConversion
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }

        public static void Convert(in double c, out double f, out double k)
        {
            k = c + 273;
            f = c * 9.0 / 5.0 + 32;
        }
        public static void Main(string[] args)
        {
            info("Question 9:");

            double celsius = 25, fahrenheit, kelvin;
            Convert(celsius, out fahrenheit, out kelvin);

            Console.WriteLine($"{celsius} C = {fahrenheit} F = {kelvin} K");
        }
    }
}