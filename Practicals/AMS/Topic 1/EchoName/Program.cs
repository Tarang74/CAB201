using System;

namespace EchoName
{
    class Program
    {
        public static void Main(string[] args)
        {          
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here:
            //  Display prompt
            Console.WriteLine("Hello there, what is your name?");

            //  Read name
            string name = Console.ReadLine()!;

            //  Display message involving name
            Console.WriteLine($"Nice to meet you {name}, welcome to CAB201.");

            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}