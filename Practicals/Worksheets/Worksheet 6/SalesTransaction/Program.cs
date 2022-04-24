using System;

namespace Question5
{
    class SalesTransaction
    {
        public string salespersonName;
        public double amount;
        public double commission;

        public SalesTransaction(string _salespersonName, double _amount, double _commissionRate)
        {
            salespersonName = _salespersonName;
            amount = _amount;
            commission = amount * _commissionRate;
        }
        public SalesTransaction(string _salespersonName, double _amount) 
        { 
            salespersonName = _salespersonName;
            amount = _amount;
            commission = 0;
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
            info("Question 5:");

            SalesTransaction a = new SalesTransaction("Alice", 100, 0.1);
            Console.WriteLine(a.commission);

            SalesTransaction b = new SalesTransaction("Alice", 100);
            Console.WriteLine(b.commission);
        }
    }
}