using System.Security.Cryptography.X509Certificates;

namespace Lab_8_1_
{
    internal class Program
    {
        public static Action showTime;
        public static Action showDate;
        public static Action showDayOfWeek;
        public static Predicate<int> isSimpleNumber;
        public static Predicate<int> isNumberFinonacci;
        public static Func<double, double, double> rectangleArea;
        public static Func<double, double, double> triangleArea;
        static void Main(string[] args)
        {
            showTime = Methods.ShowTime;
            showTime(); 
            showDate = Methods.ShowDate;
            showDate();
            showDayOfWeek = Methods.ShowDayOfWeek;
            showDayOfWeek();
            Console.Write("Your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            isSimpleNumber = Methods.IsSimpleNumber;
            Console.WriteLine($"Your number is:{isSimpleNumber(n)}");
            isNumberFinonacci = Methods.IsNumberFibonacci;
            Console.WriteLine($"Your number is:{isNumberFinonacci(n)}");
            Console.Write("your numder a:");
            double a = Convert.ToDouble( Console.ReadLine());
            Console.Write("your number b:");
            double b = Convert.ToDouble( Console.ReadLine());
            rectangleArea = Methods.RectangleArea;
            Console.WriteLine($"Your rectangle have a area: {rectangleArea(a, b)}");
            triangleArea = Methods.TriangleArea;
            Console.WriteLine($"Your rectangle have a area: {triangleArea(a, b)}");
        }
    }
}