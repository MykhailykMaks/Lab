using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    static class Create
    {
        private static Triada[] test = { };
        private static Random random = new Random();
        static DateTime[] hours = { DateTime.Now, DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), DateTime.Now.AddHours(5), DateTime.Now.AddHours(10) };
        static DateTime[] minutes = { DateTime.Now, DateTime.Now.AddMinutes(10), DateTime.Now.AddMinutes(20), DateTime.Now.AddMinutes(30), DateTime.Now.AddMinutes(40) };
        static DateTime[] seconds = { DateTime.Now, DateTime.Now.AddSeconds(10), DateTime.Now.AddSeconds(25), DateTime.Now.AddSeconds(30), DateTime.Now.AddSeconds(50) };

        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        public static DateTime GetRandomHour()
        {
            return hours[random.Next(hours.Length)];
        }
        public static DateTime GetRandomMinute()
        {
            return minutes[random.Next(minutes.Length)];
        }
        public static DateTime GetRandomSecond()
        {
            return seconds[random.Next(seconds.Length)];
        }
        public static Time GetRandomTime()
        {
            return new Time(GetRandomHour(), GetRandomMinute(), GetRandomSecond());
        }
        public static int GetRandomNumber()
        {
            return numbers[random.Next(numbers.Length)];
        }
        public static Triada GetRandomTriada()
        {
            return new Triada(GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
        }
    }
}
