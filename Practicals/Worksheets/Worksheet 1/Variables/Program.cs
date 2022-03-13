using System;

namespace Variables
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
            Question2();
            Question3();
            Question4();
            Question5();
            Question6();
        }

        public static void Question2()
        {
            info("Question 2:");

            int _base = 100;
            int _length = 200;

            dynamic volume = _base / 3 * _length;
            Console.WriteLine($"base / 3 * length:\t{volume,4} {volume.GetType()}");

            volume = _base * _length / 3;
            Console.WriteLine($"base * length / 3:\t{volume,4} {volume.GetType()}");

            volume = 1 / 3 * _base * _length;
            Console.WriteLine($"1 / 3 * base * length:\t{volume,4} {volume.GetType()}");

            volume = _base * _length * 1 / 3;
            Console.WriteLine($"base * length * 1 / 3:\t{volume,4} {volume.GetType()}\n");

            // Notes
            Console.WriteLine(@"Binary operators always convert the resulting data type to the data type of the 
argument with the largest size in memory 
(with a few exceptions when converting between floating-point types).
Hence division between two integers truncates any floating-point precision.

Caution should be used when dividing two numbers to avoid loss of precision.

When converting between types, the number of bits required to represent the 
resulting value should be considered in the event that the result 
requires more bits than is specified (resulting in an overflow), or if the result is 
negative but stored as an unsigned numeric type (resulting in an underflow).");
        }
        public static void Question3()
        {
            info("Question 3:");

            double fahrenheit = 69;

            dynamic celsius = (fahrenheit - 32) * (5.0 / 9.0);
            Console.WriteLine($"(fahrenheit - 32) * (5.0 / 9.0):\t{celsius,2:F4} {celsius.GetType()}\n");

            Console.WriteLine(@"We didn't write 32.0 because fahrenheit is already a double, 
so the resulting value is implicitly converted to a double (from an integer).");

            celsius = (fahrenheit - 32) * (5.0 / 9);
            Console.WriteLine($"(fahrenheit - 32) * (5.0 / 9):\t{celsius,2:F4} {celsius.GetType()}");

            celsius = (fahrenheit - 32) * (5 / 9.0);
            Console.WriteLine($"(fahrenheit - 32) * (5 / 9.0):\t{celsius,2:F4} {celsius.GetType()}");
        }
        public static void Question4()
        {
            info("Question 4:");

            Console.WriteLine("a) electricBill - legal");

            Console.WriteLine("b) ElectricBill - legal");

            Console.WriteLine("c) Electric Bill - illegal - identifier contains whitespace");
            Console.WriteLine("\tUnexpected symbol `Bill', expecting `,', `;', or `='");

            Console.WriteLine("d) Static - legal");

            Console.WriteLine("e) void - illegal - reserved return type for functions");
            Console.WriteLine("\tUnexpected symbol `void'");

            Console.WriteLine("f) #ssn - illegal - reserved syntax for preprocessor directives");
            Console.WriteLine("\tPreprocessor directives must appear as the first non-whitespace character on a line");

            Console.WriteLine("g) Ay56we - legal");

            Console.WriteLine("h) Theater_Tickets - legal");

            Console.WriteLine("i) 212AreaCode - illegal - identifier must begin with a letter");
            Console.WriteLine("\tUnexpected symbol `212'\n\tUnexpected symbol `AreaCode'");
        }
        public static void Question5()
        {
            info("Question 5:");

            Console.WriteLine("a) byte   - 0 to 255 (2^8) - for years 1 through 12");
            Console.WriteLine("b) float  - floating-point type with the least precision for grades between 0% and 100%");
            Console.WriteLine("c) uint   - 0 to 4294967295 (2^32) - which is enough given the population of China or India");
            Console.WriteLine("d) ulong  - 0 to 18446744073709551615 (2^64) - as the population is almost 8B, we cannot use uint");
            Console.WriteLine("e) ushort - 0 to 65535 (2^16) - maximum number of passengers is around 1000");
            Console.WriteLine("f) ushort - 0 to 65535 (2^16) - maximum score is approx. less than 2000");
            Console.WriteLine("g) byte   - 0 to 255 (2^8) - lowest recorded temp. was 4C, and winter lasts for around 100 days. Can also use bool (true/false)");
            Console.WriteLine("h) ushort - 0 to 65535 (2^16) - depends on the game, can also use byte");
        }
        public static void Question6()
        {
            info("Question 6:");

            Console.WriteLine("Using verbatim multiline strings `@\"\"`:");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Input:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(@"csharp> Console.WriteLine(@""  ******
 *      *
*  STOP  *
 *      *
  ******
    **
    **
    **
    **"");");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Output:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(@"  ******
 *      *
*  STOP  *
 *      *
  ******
    **
    **
    **
    **");

            Console.WriteLine("Using escaped newlines `\\n`:");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Input:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("csharp> Console.WriteLine(\"  ******  \\n *      * \\n*  STOP  *\\n *      * \\n  ******  \\n    **    \\n    **    \\n    **    \\n    **\");");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Output:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("  ******  \n *      * \n*  STOP  *\n *      * \n  ******  \n    **    \n    **    \n    **    \n    **");
        }
    }
}
