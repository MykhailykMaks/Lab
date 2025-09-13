using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_1_
{
    internal class Methods
    {
        public static void ShowTime()
        {
             Console.WriteLine($"{DateTime.Now}");
        }
        public static void ShowDate()
        {
            Console.WriteLine($"{DateTime.Now.Date}");
        }
        public static void ShowDayOfWeek()
        {
            Console.WriteLine($"{DateTime.Now.DayOfWeek}");
        }
        public static bool IsSimpleNumber(int n)
        {
            if(n > 1)
            {
                for(int i = 2;  i < n; i++)
                {
                    if(n / i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsNumberFibonacci(int n)
        {
            int isFibonacci = (n - 1) + (n - 2);
            if(isFibonacci < 0)
            {
                return false;
            }
            if(isFibonacci == 0)
            {
                return true;
            }
            return false;
        }
        public static double RectangleArea(double a, double b)
        {
            double s = a * b;
            return s;
        }
        public static double TriangleArea(double a, double b)
        {
            double s = (a * b) / 2;
            return s;
        }
    }
}
