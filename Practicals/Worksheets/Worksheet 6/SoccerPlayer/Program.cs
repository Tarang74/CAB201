using System;

namespace Question2
{
    class SoccerPlayer
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }

        public SoccerPlayer(string _name, int _jerseyNumber, int _goals, int _assists)
        {
            Name = _name;
            JerseyNumber = _jerseyNumber;
            Goals = _goals;
            Assists = _assists;
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
            info("Question 2:");

            SoccerPlayer a = new SoccerPlayer("Alice", 1, 15, 23);
            Console.WriteLine(a.Name);
            Console.WriteLine(a.JerseyNumber);
            Console.WriteLine(a.Goals);
            Console.WriteLine(a.Assists);
        }
    }
}