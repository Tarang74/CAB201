using System;

namespace Question6
{
    class HousePlant
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Fed { get; set; }

        public HousePlant(string _name, double _price, bool _fed)
        {
            Name = _name;
            Price = _price;
            Fed = _fed;
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
            info("Question 6:");

            HousePlant a = new HousePlant("Philodendron", 29.99, true);
            Console.WriteLine($"{a.Name} costs {a.Price}. Fed: {a.Fed}");

            a.Fed = false;
            a.Price = 28.99;

            Console.WriteLine($"{a.Name} costs {a.Price}. Fed: {a.Fed}");
        }
    }
}