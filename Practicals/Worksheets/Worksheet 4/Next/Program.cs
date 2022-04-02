using System;

namespace Next
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static string NextRef(ref int integer)
        {
            return (++integer).ToString();
        }
        public static string NextOut(in int integerInput, out int integerOutput)
        {
            integerOutput = integerInput + 1;
            return integerOutput.ToString();
        }
        public static void Main(string[] args)
        {
            info("Question 8:");

            int i = 1;
            Console.WriteLine($"Ref: {NextRef(ref i)}\tValue of i: {i}\nOut: {NextOut(i, out i)}\tValue of i: {i}");
        }
    }
}
