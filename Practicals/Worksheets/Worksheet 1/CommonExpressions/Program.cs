using System;

namespace CommonExpressions
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n"+s+"\n");
            Console.ResetColor();
        }
        public static void Main(string[] args)
        {
            Question1();
        }

        public static void Question1()
        {
            info("Question 1:");
            
            dynamic a = 2 + 5 * 3;
            Console.WriteLine($"a) {a,2} {a.GetType()}");

            dynamic b = 9 / 4 + 10;
            Console.WriteLine($"b) {b,2} {b.GetType()}");
            
            dynamic c = 10 / 3;
            Console.WriteLine($"c) {c,2} {c.GetType()}");
            
            dynamic d = 21 % 10;
            Console.WriteLine($"d) {d,2} {d.GetType()}");
            
            dynamic e = (5 - 1) * 3;
            Console.WriteLine($"e) {e,2} {e.GetType()}");
            
            dynamic f = 37 / 5;
            Console.WriteLine($"f) {f,2} {f.GetType()}");
        }
    }
}
