using System;

namespace Letter
{
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

            Letter myLetter = new Letter("Sam", new MyDate(13, 11, 1982));

            Console.WriteLine($"The name of the letter: {myLetter.Name}\nand the day is: {myLetter.Date.Day}");

            CertifiedLetter cLetter = new CertifiedLetter("Alex", new MyDate(2, 5, 1995), 25);
        }
    }

    class CertifiedLetter : Letter
    {
        public int TrackingNumber {get;}

        public CertifiedLetter(string name, MyDate date, int trackingNumber) : base(name, date)
        {
            TrackingNumber = trackingNumber;
        }
    }
}