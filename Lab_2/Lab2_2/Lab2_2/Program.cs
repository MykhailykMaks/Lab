using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] xNumbers = { 2, 10, -10 };
            double eps = 1e-6;
            double S = 1.0;
            double term = 1.0;
            double ln2 = Math.Log(2);
            int n = 1;
            Console.WriteLine(" x\t S\t y(x) = 2^x\t Error");
            for (int i = 0; i < xNumbers.Length; ++i)
            {
                double x = xNumbers[i];  
                while (Math.Abs(term) >= eps)
                {
                     term *= (x * ln2) / n;
                     S += term;
                     n++;
                }
                double y = Math.Pow(2, x);
                double error = Math.Abs(S - y);
                Console.WriteLine($" {x}\t {S:F3}\t {y:F6}\t {error:E}");
            }    
        }
    }
}
