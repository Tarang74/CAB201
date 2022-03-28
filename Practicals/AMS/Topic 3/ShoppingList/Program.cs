using System;
using System.Collections.Generic;

namespace ShoppingList
{
    public class Program
    {
        static void Main( string [] args )
        {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            // Insert your solution here.
            Console.WriteLine("Please provide the number of items:");
            int amount = Int32.Parse(Console.ReadLine()!);

            List<string> items = new List<string>();

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Next item:");
                items.Add(Console.ReadLine()!);
            }

            items.Sort();

            Console.WriteLine("--------------");
            Console.WriteLine("Shopping list:");
            Console.WriteLine("--------------");

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Item {i} -- {items[i]}");
            }

            // Keep the following line intact
            Console.WriteLine( "===========================" );
        }
    }
}   