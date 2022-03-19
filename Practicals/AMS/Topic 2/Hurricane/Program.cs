using System;

namespace Hurricane
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following lines intact 
            Console.WriteLine("===========================");

            const string PROMPT = "Please enter the wind speed (km/h):";
            const string OUT_FORMAT = "If the wind speed is {0} then {1}.";

            Console.WriteLine(PROMPT);
            string userInput = Console.ReadLine()!;
            int windSpeed = int.Parse(userInput);

            string message = "";

            // Insert your solution here.
            if (0 <= windSpeed && windSpeed <= 118)
            {
                message = "the damage from winds is minimal";
            }
            else if (119 <= windSpeed && windSpeed <= 153)
            {
                message = "very dangerous winds will produce some damage";
            }
            else if (154 <= windSpeed && windSpeed <= 177)
            {
                message = "extremely dangerous winds cause extensive damage";
            }
            else if (178 <= windSpeed && windSpeed <= 208)
            {
                message = "devastating damage will occur";
            }
            else if (209 <= windSpeed && windSpeed <= 251)
            {
                message = "catastrophic damage will occur";
            }
            else if (252 <= windSpeed)
            {
                message = "cataclysmic damage will occur";
            }

            // Keep the following lines intact
            Console.WriteLine(OUT_FORMAT, windSpeed, message);
            Console.WriteLine("===========================");
        }
    }
}