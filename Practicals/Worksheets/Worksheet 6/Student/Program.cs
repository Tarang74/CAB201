using System;

namespace Question7
{
    class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            private set
            {
                number = value;
            }
        }

        public Student(string _name, int _number)
        {
            Name = _name;
            Number = _number;
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
            info("Question 7:");

            Student a = new Student("Alice", 10);
        }
    }
}