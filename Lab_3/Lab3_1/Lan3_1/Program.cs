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
            Random rand = new Random();
            const int N = 40;
            int[] Arr = new int[N];
            for (int i = 0; i < N; ++i)
            {
                Arr[i] = rand.Next(-50, 50);
            }
            Console.WriteLine("Array:");
            foreach (int value in Arr)
            {
                Console.Write(value.ToString().PadLeft(10));
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

