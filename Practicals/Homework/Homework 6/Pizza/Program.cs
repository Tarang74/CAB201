using System;
using System.Collections.Generic;

namespace Question1
{
    class Pizza
    {
        List<string> toppings;
        int diameter;
        double price;
        public Pizza(List<string> _toppings, int _diameter, double _price)
        {

        }
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
            info("Question 1:");

            Pizza a = new Pizza();
        }
    }
}