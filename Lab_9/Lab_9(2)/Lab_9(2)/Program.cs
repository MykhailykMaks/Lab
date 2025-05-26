namespace Lab_9_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the path for text to file"); // C:\Users\user\source\repos\Lab_9(2)\Lab_9(2)\bin\Debug\net8.0\test.txt
            string? pathText = Console.ReadLine();
            if (!File.Exists(pathText))
            {
                Console.WriteLine("File dont exist!");
                return;
            }
            string fileText = File.ReadAllText(pathText);
            Console.WriteLine("In File:\n" + fileText);
            Console.WriteLine("Input the path for words to file"); // C:\Users\user\source\repos\Lab_9(2)\Lab_9(2)\bin\Debug\net8.0\words.txt
            string? pathWords = Console.ReadLine();
            if (!File.Exists(pathWords))
            {
                Console.WriteLine("File dont exist!");
                return;
            }
            string fileWords = File.ReadAllText(pathWords);
            Console.WriteLine("In File:\n" + fileWords);
            string[] words = fileWords.Split(",", StringSplitOptions.RemoveEmptyEntries);
            char[] rozdilyatory = { '.', ',', '?', '!', ' ' };
            string[] text = fileText.Split(rozdilyatory, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < words.Length; j++)
                {
                    if (text[i].Equals(words[j]))
                    {
                        char[] symbols = text[i].ToCharArray();
                        for (int k = 0; k < symbols.Length; k++)
                        {
                            symbols[k] = '*';
                        }
                        text[i] = new string(symbols);
                    }
                }
            }
            Console.WriteLine("Text after change:" );
            foreach (string sentence in text)
            {
                Console.Write(sentence + " ");
            }
            using (StreamWriter writer = new StreamWriter("newText.txt"))
            {
                foreach (string sentence in text)
                {
                    writer.Write(sentence + " ");
                }
            }

        }
    }
}
