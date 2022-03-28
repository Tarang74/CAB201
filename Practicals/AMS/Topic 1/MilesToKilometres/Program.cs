using System;

namespace MilesToKilometres
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            //  Display prompt
            Console.WriteLine("Please supply the distance in miles:");

            //  Read number of miles
            double distanceInMi = Convert.ToDouble(Console.ReadLine()!);

            //  Compute equivalent number of kilometres
            const double factor = 1.609344D;
            double distanceInKM = distanceInMi * factor;

            //  Display message involving miles and kilometres
            Console.WriteLine($"{distanceInMi:F3} miles is the same as {distanceInKM:F3} kilometres.");

            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}