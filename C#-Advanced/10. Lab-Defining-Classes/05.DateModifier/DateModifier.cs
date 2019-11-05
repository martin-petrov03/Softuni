using System;

namespace DefiningClasses
{
    class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;
        private int difference;

        public int Dates()
        {
            difference = Math.Abs((firstDate.Date - secondDate.Date).Days);
            return difference;
        }

        public DateTime FirstDate
        {
            set { this.firstDate = value; }
        }

        public DateTime SecondDate
        {
            set { this.secondDate = value; }
        }
    }
}