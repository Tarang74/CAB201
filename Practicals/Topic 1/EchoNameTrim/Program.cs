using System;

namespace EchoNameTrim
{
    class Program
    {
        public static void Main( string [] args )
        {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            // Insert your solution here.
            //  Display prompt
            Console.WriteLine("Please enter your name:");

            //  Read name, trim leading and trailing white space
            string name = Console.ReadLine()!.Trim();

            //  Display message involving name
            Console.WriteLine($"Hello {name}, welcome to CAB201!");

            // Keep the following line intact 
            Console.WriteLine( "===========================" );
        }
    }
}