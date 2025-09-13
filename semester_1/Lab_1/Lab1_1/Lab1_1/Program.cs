namespace Lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double y = ((Math.Sqrt(Math.Abs(-a * x + c))) / (Math.Abs(Math.Log(Math.Abs(x + Math.Pow(c, 3)))))) - (Math.Pow(Math.Tan(a), 4));
            Console.WriteLine($"{y}");
            Console.ReadKey();
        }
    }
}
