using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab_8_3_
{
    internal class Program
    { 
        public delegate int DelegateForDivide7(int[] numbers, Predicate<int> predicate); 
        public delegate int DelegateForPositiveNumbers(int[] numbers, Predicate<int> predicate);
        public delegate bool DelegateForDayOfProgrammers(DateTime date, Predicate<DateTime> predicate);
        public delegate bool DelegateForCheckText(string input, Regex regex);
        static void Main(string[] args)
        {
            int[] numbers = { 7, -9, 13, 14, -16, 19, 21, 57 };
            Predicate<int> divide7Predicate = number => number % 7 == 0;
            DelegateForDivide7 delegateForDivide7 = (arr, predicate) =>
            {
                int count = 0;
                foreach (var number in arr)
                {
                    if (predicate(number))
                    {
                        count++;
                    }
                }
                return count;
            };
            Console.WriteLine("Count of numbers divided by 7: " + delegateForDivide7(numbers, divide7Predicate));
            Predicate<int> positivePredicate = number => number > 0;
            DelegateForPositiveNumbers delegateForPositiveNumbers = (arr, predicate) =>
            {
                int count = 0;
                foreach (var number in arr)
                {
                    if (predicate(number))
                    {
                        count++;
                    }
                }
                return count;
            };
            Console.WriteLine("Count of positive numbers: " + delegateForPositiveNumbers(numbers, positivePredicate));
            DateTime date = DateTime.Now;
            Predicate<DateTime> dayOfProgrammersPredicate = date => date.DayOfYear == 256;
            DelegateForDayOfProgrammers delegateForDayOfProgrammers = (date, predicate) =>
            {
                return predicate(date);
            };
            Console.WriteLine("Today the Day of Programmers?\n" + delegateForDayOfProgrammers(date, dayOfProgrammersPredicate));
            Console.WriteLine("Input the text");
            string inputText = Console.ReadLine();
            string text = "KRNU";
            Regex regex = new Regex(text);
            DelegateForCheckText delegateForCheckText = (input, regex) =>
            {
                return regex.IsMatch(input);
            };
            bool isMatch = delegateForCheckText(inputText, regex);
            if (isMatch == true)
            {
                Console.WriteLine("The your text is match KRNU");
            }
            else
            {
                Console.WriteLine("The your text is not match KRNU");
            }
        }
    }
}
