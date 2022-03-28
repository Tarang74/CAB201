using System;

namespace TypeConversion
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
            Question7();
        }

        public static void Question7()
        {
            info("Question 7:");

            byte a = 80;
            Console.WriteLine("a) implicit");
            Console.WriteLine($"\t{80} {(80).GetType()} -> {a} {a.GetType()}");
            
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked-and-unchecked
            int b_int = 300;
            byte b = (byte)b_int;
            Console.WriteLine("b) explicit and must be unchecked as out-of-range constants are converted at execution time");
            Console.WriteLine($"\t{b_int} {b_int.GetType()} -> {b} {b.GetType()}");

            double c = (double)400;
            Console.WriteLine("c) explicit as 400 is an integer by default");
            Console.WriteLine($"\t{400} {(400).GetType()} -> {c} {c.GetType()}");

            int d = (int)400.25m;
            Console.WriteLine("d) explicit as int truncates floating-point values");
            Console.WriteLine($"\t{400.25m} {(400.25m).GetType()} -> {d} {d.GetType()}");

            int e = (int)400.75f;
            Console.WriteLine("e) explicit as int truncates floating-point values");
            Console.WriteLine($"\t{400.75f} {(400.75f).GetType()} -> {e} {e.GetType()}");

            decimal f = (decimal)721.63d;
            Console.WriteLine("f) explicit as decimals are represented differently to floats and doubles");
            Console.WriteLine($"\t{721.63d} {(721.63d).GetType()} -> {f} {f.GetType()}");
        }
    }
}
