using System;

namespace RoomArea
{
    public class Program
    {
        public static void Main( string [] args )
        {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            // Insert your solution here.
            Console.WriteLine("Please enter the width of the room, in metres:");
            double width = Convert.ToDouble(Console.ReadLine()!);

            Console.WriteLine("Please enter the length of the room, in metres:");
            double length = Convert.ToDouble(Console.ReadLine()!);

            double area = width * length;

            Console.WriteLine($"The floor area of a {width:F2} by {length:F2} metre room is {area:F6} square metres.");

            // Keep the following line intact 
            Console.WriteLine( "===========================" );
        }
    }
}