namespace Lab4_2
{
    internal class Program
    {
        private static string[]? newArrayString()
        {
            int N = 10;
            Console.Write("How much strings you input?");
            int n = int.Parse(Console.ReadLine());
            string[]? retStrArr = new string[n];
            Console.WriteLine("Input number of your strings:");
            for (int i = 0; i < n; ++i)
            {
                string inputString = String.Empty;
                while (true)
                {
                    Console.Write($"String {i}:(Less 10 symbols)");
                    inputString = Console.ReadLine();
                    if (inputString.Length <= N)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your string bigger than limit");
                    }
                }
                retStrArr[i] = inputString;
            }
            Console.WriteLine("Your strings:");
            foreach (string item in retStrArr)
            {
                Console.WriteLine(item);
            }
            return retStrArr;
        }
        private static string[]? newArrayStringFile(string v)
        {
            int N = 10;
            string[]? retStrArr = null;
            using (StreamReader strRead = new StreamReader(v))
            {
                string str = strRead.ReadToEnd();
                char[] rozdilyatory = { '.', '!', '?', '\n', '/' };
                retStrArr = str.Split(rozdilyatory, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Your strings:");
                foreach (string item in retStrArr)
                {
                    Console.WriteLine(item);
                }
            }
            return retStrArr;
        }
        static int StringSort(string a, string b)
        {
            char stringA = a[a.Length - 1];
            char stringB = b[b.Length - 1];

            if (stringA != stringB)
            {
                return stringA.CompareTo(stringB);
            }

            return a.Length.CompareTo(b.Length);
        }
        static void Main(string[] args)
        {
            string[]? Arr = null;
            Console.Write("Choose a option to input a array:(1 - from file, 2 - input yourself)");
            int Pr = Convert.ToInt32(Console.ReadLine());
            switch (Pr)
            {
                case 1:
                    Arr = newArrayStringFile("infoString.txt");
                    Array.Sort(Arr, StringSort);
                    Console.WriteLine("Sorted array:");
                    foreach(string item in Arr)
                    {
                        Console.WriteLine($"{item}");
                    }
                    break;
                case 2:
                    Arr = newArrayString();
                    Array.Sort(Arr, StringSort);
                    Console.WriteLine("Sorted array:");
                    foreach (string item in Arr)
                    {
                        Console.WriteLine($"{item}");
                    }
                    break;
                default:
                    Console.WriteLine("You input a wrong option!");
                    break;

            }

        }
    }
}
