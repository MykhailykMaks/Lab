namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] startNumbers = File.ReadAllLines("Lab1_2.txt");
            double x0 = double.Parse(startNumbers[0]);
            double y0 = double.Parse(startNumbers[1]);
            double xMin = double.Parse(startNumbers[2]);
            double xMax = double.Parse(startNumbers[3]);
            int n = 8;
            double point = (xMax - xMin) / (n - 1);
            using (StreamWriter writeFile = new StreamWriter("Lab1_2_output.txt")) {
                writeFile.WriteLine("Отримано");
                for (double x = xMin; x <= xMax; x += point)
                {
                    double y = Math.Pow(x, 2) - 3 * Math.Sin(x);
                    writeFile.WriteLine($"Для заданої функції Y({x}) = {y}");
                }
                writeFile.WriteLine("Виконав студент групи КН-24-1 Михайлик Максим");
            }
        }
    }
}
