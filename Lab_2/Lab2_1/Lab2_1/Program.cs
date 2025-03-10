namespace Lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbersA = { 0.5, 0.75, 1, 1.25 };
            int xStart = 0;
            int xEnd = 3;
            double dx = 0.1;
            for (int i = 0; i < numbersA.Length; ++i) 
            {
                for (double x = xStart; x <= xEnd; x += dx)
                {
                    double a = numbersA[i];
                    double y = (Math.Atan(x / (a * 2)) / (Math.Pow(x, 2) + (a * 2)));
                    Console.WriteLine($"Function y = {y}, if,  x = {x}, a = {a} ");
                }
            }
        }
    }
}
         
