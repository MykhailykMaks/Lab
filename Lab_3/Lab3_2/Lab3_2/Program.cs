namespace Lab3_2
{
    internal class Program
    {
        static void PrintArray(int[,] Arr)
        {
            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);
            int[] columnWidth = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int maxWidth = 0;
                for (int i = 0; i < rows; i++)
                {
                    maxWidth = Math.Max(maxWidth, Arr[i, j].ToString().Length);
                }
                columnWidth[j] = maxWidth;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(Arr[i, j].ToString().PadLeft(columnWidth[j] + 2));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            const int N = 5;
            int[,] Arr = new int[N, N];
            Console.Write("Choose a option of input array(1 - input numbers yourself, 2 - input numbers from file, 3 - input numbers randomly):");
            int Pr = Convert.ToInt32(Console.ReadLine());
            switch (Pr)
            {
                case 1:
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            Console.Write($"Array[{i},{j}] = ");
                            Arr[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("Array:");
                    PrintArray(Arr);
                    break;
                case 2:
                    string[] lines = File.ReadAllLines("input.txt");
                    for (int i = 0; i < N; i++)
                    {
                        string[] row = lines[i].Split();
                        for (int j = 0; j < N; j++)
                        {
                            Arr[i, j] = int.Parse(row[j]);
                        }
                    }
                    Console.WriteLine("Array:");
                    PrintArray(Arr);
                    break;
                case 3:
                    Random rand = new Random();
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            Arr[i, j] = rand.Next(-50, 50);
                        }
                    }
                    Console.WriteLine("Array:");
                    PrintArray(Arr);
                    break;
            }
            double sum = 0;
            double dobutok = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum += Arr[i, j];
                    dobutok *= Arr[i, j];
                }
            }
            double dif = dobutok - sum;
            Console.WriteLine($"\nDiffrence in array:{dif}");
            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int maxIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (Arr[i, j] > Arr[i, maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                if (maxIndex < cols - 1)
                {
                    int[] bufArr = new int[cols - maxIndex - 1];
                    for (int j = 0; j < bufArr.Length; j++)
                    {
                        bufArr[j] = Arr[i, maxIndex + 1 + j];
                    }
                    Array.Sort(bufArr);
                    Array.Reverse(bufArr);
                    for (int j = 0; j < bufArr.Length; j++)
                    {
                        Arr[i, maxIndex + 1 + j] = bufArr[j];
                    }
                }
            }
            Console.WriteLine("Array after sorting:");
            PrintArray(Arr);
        }
    }
}
