namespace Lan3_1
{
    internal class Program
    {
        static int MinNum(int[] Arr, int N)
        {
            int min = Arr[0];
            for (int i = 1; i < N; ++i)
            {
                if (Arr[i] < min)
                {
                    min = Arr[i];
                }
            }
            return min;
        }

        static int NegativeNum(int[] Arr, int N)
        {
            int negative = Arr[0];
            for (int i = 0; i < N; ++i)
            {
                if (Arr[i] < 0)
                {
                    negative = Arr[i];
                }
            }
            return negative;
        }

        static int MinIndex(int[] Arr, int N, int number)
        {
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        static int NegativeIndex(int[] Arr, int N, int number)
        {
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            const int N = 40;
            int[] Arr = new int[N];
            Console.Write("Choose a option of input array(1 - input numbers yourself, 2 - input numbers from file, 3 - input numbers randomly):");
            int Pr = Convert.ToInt32(Console.ReadLine());
            switch (Pr)
            {
                case 1:
                    for (int i = 0; i < N; ++i)
                    {
                        Console.Write("Input a number for array:");
                        Arr[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Array:");
                    foreach (int value in Arr)
                    {
                        Console.Write(value.ToString().PadLeft(10));
                    }
                    break;
                case 2:
                    string[] lines = File.ReadAllLines("input.txt");
                    Arr = lines.Take(N).Select(int.Parse).ToArray();
                    Console.WriteLine("Array:");
                    foreach (int value in Arr)
                    {
                        Console.Write(value.ToString().PadLeft(10));
                    }
                    break;
                case 3:
                    Random rand = new Random();
                    for (int i = 0; i < N; ++i)
                    {
                        Arr[i] = rand.Next(-50, 50);
                    }
                    Console.WriteLine("Array:");
                    foreach (int value in Arr)
                    {
                        Console.Write(value.ToString().PadLeft(10));
                    }
                    break;
            }
            Console.WriteLine();
            int minNumber = MinNum(Arr, N);
            Console.WriteLine($"\nMin. number: {minNumber}");
            int negative = NegativeNum(Arr, N);
            Console.WriteLine($"\nLast negative number: {negative}");
            int minNumberIndex = MinIndex(Arr, N, minNumber);
            Console.WriteLine($"\nMin. number index: {minNumberIndex}");
            int negativIndex = NegativeIndex(Arr, N, negative);
            Console.WriteLine($"\nLast negative number index: {negativIndex}");

            int index1 = minNumberIndex;
            int index2 = negativIndex;

            int buf = Arr[index1];
            Arr[index1] = Arr[index2];
            Arr[index2] = buf;

            Console.WriteLine("\nArray after swapping:");
            foreach (int value in Arr)
            {
                Console.Write(value.ToString().PadLeft(10));
            }
        }
    }

}

