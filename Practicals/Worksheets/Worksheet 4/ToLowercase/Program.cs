using System;

namespace ToLowercase
{
    class Program
    {
        public static void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + s + "\n");
            Console.ResetColor();
        }
        public static void ToLower(ref string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].ToLower();
            }
        }
        public static void Main(string[] args)
        {
            info("Question 6:");

            string[] quotes = {"Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.", 
                              "It is strange that only extraordinary men make the discoveries, which later appear so easy and simple.", 
                              "Falsity in intellectual action is intellectual immorality.",
                              "There is no law except the law that there is no law."};
            foreach (string quote in quotes) Console.WriteLine(quote);
            
            ToLower(ref quotes);
            foreach (string quote in quotes) Console.WriteLine(quote);
        }
    }
}