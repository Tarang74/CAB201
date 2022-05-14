using System;

namespace Letter
{
    /// <summary>
    /// A letter class. Contains the name of the recipient and the date mailed.
    /// </summary>
    class Letter
    {
        /// <summary>
        /// The name of the recipient.
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The date that is was mailed.
        /// </summary>
        public MyDate Date { get;}

        /// <summary>
        /// A class that represets a letter.
        /// </summary>
        /// <param name="name">The name of the recipient.</param>
        /// <param name="date">The date that is was mailed.</param>
        public Letter(string name, MyDate date)
        {
            this.Name = name;
            this.Date = date;
        }
    }
}
