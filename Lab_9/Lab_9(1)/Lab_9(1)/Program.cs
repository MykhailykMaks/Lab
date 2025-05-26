namespace Lab_9_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the path to file"); // C:\Users\user\source\repos\Lab_9(1)\Lab_9(1)\bin\Debug\net8.0\test.txt
            string? path = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("File dont exist!");
                return;
            }
            string fileText = File.ReadAllText(path);
            Console.WriteLine("In File:\n" + fileText);
            string[] countSentences = fileText.Split(".");
            int sentenceCount = countSentences.Length;
            Console.WriteLine("Count of sentences in the file: " + sentenceCount);

            char[] fileSymbols = fileText.ToCharArray();
            int countUpSymbols = 0;
            int countLowSymbols = 0;
            foreach (char symbol in fileSymbols)
            {
                if (char.IsUpper(symbol))
                {
                    countUpSymbols++;
                }
                else if (char.IsLower(symbol))
                {
                    countLowSymbols++;
                }
            }
            Console.WriteLine("Count of upper symbols: " + countUpSymbols);
            Console.WriteLine("Count of lower symbols: " + countLowSymbols);

            char[] golosni = { 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я' };
            char[] prygolosni = { 'Б', 'В', 'Г', 'Ґ', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь' };
            int countGolosni = 0;
            int countPrygolosni = 0;
            foreach (char symbol in fileSymbols)
            {
                if (golosni.Contains(char.ToUpper(symbol)))
                {
                    countGolosni++;
                }
                else if (prygolosni.Contains(char.ToUpper(symbol)))
                {
                    countPrygolosni++;
                }
            }
            Console.WriteLine("Count of golosni symbols: " + countGolosni);
            Console.WriteLine("Count of prygolosni symbols: " + countPrygolosni);

            int countNumbers = 0;
            foreach (char symbol in fileSymbols)
            {
                if (char.IsDigit(symbol))
                {
                    countNumbers++;
                }
            }
            Console.WriteLine("Count of numbers in the file: " + countNumbers);
        }
    }
}
