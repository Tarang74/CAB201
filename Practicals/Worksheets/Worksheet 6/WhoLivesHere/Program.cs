using System;

namespace Question1
{
    class WhoLivesHere
    {
        public string person;
        public string city;

        public WhoLivesHere(string _person, string _city)
        {
            person = _person;
            city = _city;
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
            info("Question 1:");

            WhoLivesHere a = new WhoLivesHere("Alice", "New York");
            Console.WriteLine(a.person);
            Console.WriteLine(a.city);
        }
    }
}