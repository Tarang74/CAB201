using System;

namespace Homework1
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
            Question1();
            Question2();
            Question3();
            Question4();
        }

        public static void Question1()
        {
            info("Question 1:");

            dynamic a = 64 % 8;
            Console.WriteLine($"a) {a} {a.GetType()}");

            dynamic b = 5 + 2 * 4 - 3 * 4;
            Console.WriteLine($"b) {b} {b.GetType()}");

            dynamic c = 3 * (2 + 5) / 5;
            Console.WriteLine($"c) {c} {c.GetType()}");

            dynamic d = 28 % 5 - 2;
            Console.WriteLine($"d) {d} {d.GetType()}");

            dynamic e = 19 / 2 / 2;
            Console.WriteLine($"e) {e} {e.GetType()}");

            dynamic f = 28 / (2 + 4);
            Console.WriteLine($"f) {f} {f.GetType()}");
        }
        public static void Question2()
        {
            info("Question 2:");

            Console.WriteLine("a) heightInCentimeters - legal");

            Console.WriteLine("b) Zip23891 - legal");

            Console.WriteLine("c) Void - legal");

            Console.WriteLine("d) _123_456 - legal");

            Console.WriteLine("e) 123_456_ - legal");

            Console.WriteLine("f) double base - illegal - identifier contains whitespace");
            Console.WriteLine("\tUnexpected symbol `double'\n\tUnexpected symbol `base'\n\tUnexpected symbol `='");

            Console.WriteLine("g) double-base - illegal - identifier cannot contain `-`");
            Console.WriteLine("\tUnexpected symbol `double'\n\tUnexpected symbol `-'\n\tUnexpected symbol `='");

            Console.WriteLine("h) double_base - legal");
        }
        public static void Question3()
        {
            info("Question 3:");

            string a, b;

            a = "one";
            b = "two";
            Console.WriteLine($"a) \"{a}\".CompareTo(\"{b}\") - {a.CompareTo(b),2}");
            
            a = "one";
            b = "one";
            Console.WriteLine($"b) \"{a}\".CompareTo(\"{b}\") - {a.CompareTo(b),2}");

            a = "One";
            b = "one";
            Console.WriteLine($"c) \"{a}\".CompareTo(\"{b}\") - {a.CompareTo(b),2}");

            a = "one";
            b = "One";
            Console.WriteLine($"d) \"{a}\".CompareTo(\"{b}\") - {a.CompareTo(b),2}");
        }
        public static void Question4()
        {
            info("Question 4:");

            string a = "It's a me, Mario";
            Console.WriteLine($"a) a.Remove(11).Insert(11, \"Luigi\") -> {a.Remove(11).Insert(11, "Luigi")}");

            string b = "    Hello    ";
            Console.WriteLine($"b) b.Trim() -> {b.Trim()}");

            string c = "Hello";
            Console.WriteLine($"c) c.Contains(\"hell\") -> {c.Contains("hell")}");

            string d = "hello";
            Console.WriteLine($"d) d.Contains(\"hell\") -> {d.Contains("hell")}");
        }
    }
}
