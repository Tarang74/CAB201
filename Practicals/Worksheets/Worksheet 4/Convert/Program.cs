using System;

namespace Convert
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }

        public static double ConvertKilometresToMiles(double km)
        {
            return (double) km * 1.60934;
        }

        public static void Main(string[] args)
        {
            info("Question 3:");

            Console.Write("Enter a distance in KM: ");
            double distanceKm = Double.Parse(Console.ReadLine()!);

            double distanceMi = ConvertKilometresToMiles(distanceKm);
            Console.WriteLine($"{distanceKm} km is equal to {distanceMi} mi.");
        }
    }
}