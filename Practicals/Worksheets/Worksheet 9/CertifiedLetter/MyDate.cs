using System;

namespace Letter
{
    /// <summary>
    /// A class that references a date.
    /// </summary>
    class MyDate
    {
        /// <summary>
        /// The date's day.
        /// </summary>
        public int Day { get; private set; }

        /// <summary>
        /// The date's month.
        /// </summary>
        public int Month { get; private set; }

        /// <summary>
        /// The date's year.
        /// </summary>
        public int Year { get; private set; }


        /// <summary>
        /// The date.
        /// </summary>
        /// <param name="day">The date's day.</param>
        /// <param name="month">The date's month.</param>
        /// <param name="year">The date's year.</param>
        public MyDate(int day, int month, int year)
        {

            if ((day < 0) || (day > 31)) exit();
            if ((month < 0) || (month > 12)) exit();

            if ((day >= 31) && ((month == 4) || (month == 6) || (month == 9) || (month == 11))) exit();

            if ((day >= 30) && (month == 2)) exit();

            if ((day >= 29) && (month == 2) && !leapYear(year)) exit();

            this.Day = day;
            this.Month = month;
            this.Year = year;

        }

        /// <summary>
        /// Return if the date is a leap year
        /// </summary>
        /// <param name="year">A year.</param>
        /// <returns>True if it is a leap year and false otherwise.</returns>
        private bool leapYear(int year)
        {
            if ((year % 400) == 0) return true;
            if ((year % 100) == 0) return false;
            if ((year % 4) == 0) return true;
            return false;
        }


        /// <summary>
        /// An exit
        /// </summary>
        private void exit()
        {
            Console.WriteLine("Error");
            Environment.Exit(-1);
        }
    }
}