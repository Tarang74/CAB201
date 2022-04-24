using System;

namespace Question8
{
    class Number
    {
        public int Square { get; private set; }
        public int Cube { get; private set; }
        private int baseNumber;
        public int BaseNumber
        {
            get
            {
                return baseNumber;
            }
            set
            {
                baseNumber = value;
                Square = baseNumber * baseNumber;
                Cube = Square * baseNumber;
            }
        }

        public Number(int _number)
        {
            BaseNumber = _number;
        }
        public void Info()
        {
            Console.WriteLine($"Number: {BaseNumber} Square: {Square} Cube: {Cube}");
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
            info("Question 8:");

            Number a = new Number(2);
            a.Info();

            a.BaseNumber = 4;
            a.Info();
        }
    }
}