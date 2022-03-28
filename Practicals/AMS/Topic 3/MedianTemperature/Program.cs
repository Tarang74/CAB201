using System;
using System.Collections.Generic;

namespace MedianTemperature
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            List<double> values = new List<double>();

            double temperature = 0;

            while (temperature != 99999999)
            {
                Console.WriteLine("Please enter the next temperature value, or 99999999 to finish:");
                temperature = Double.Parse(Console.ReadLine()!);
                if (temperature != 99999999)
                {
                    values.Add(temperature);
                }
            }

            int n = values.Count;

            if (n == 0)
            {
                Console.WriteLine("Median is not defined if the list is empty.");
            }
            else
            {
                values.Sort();

                double median = 0;

                if (n % 2 == 0)
                {
                    // Even    
                    median = (values[n / 2] + values[n / 2 - 1]) / 2;
                }
                else
                {
                    // Odd
                    median = values[n / 2];
                }

                Console.WriteLine($"The median is {median:F2} degrees.");
            }

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}