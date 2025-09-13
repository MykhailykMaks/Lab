using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    internal class Time : Triada
    {
        public DateTime hours;
        public DateTime minutes;
        public DateTime seconds;

        public Time(DateTime hours, DateTime minutes, DateTime seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Time()
        {
            hours = DateTime.Now;
            minutes = DateTime.Now;
            seconds = DateTime.Now;
        }
        public DateTime Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public DateTime Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public DateTime Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public override void PlusOne()
        {
            hours = hours.AddHours(1);
            minutes = minutes.AddMinutes(1);
            seconds = seconds.AddSeconds(1);
        }
        public void AddMinutes(int n)
        {
            this.minutes = this.minutes.AddMinutes(n);
        }
        public override string ToString()
        {
            return ($"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}");
        }
        public override bool Equals(object? obj)
        {
            if (obj is Time)
            {
                Time other = (Time)obj;
                return hours == other.hours && minutes == other.minutes && seconds == other.seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
