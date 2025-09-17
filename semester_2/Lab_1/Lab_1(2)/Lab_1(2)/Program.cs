using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace Lab_1_2_
{
    internal class Program
    {
        static int p, k;
        static void AnalyzeFile(string pathFile)
        {
            if (!File.Exists(pathFile))
            {
                Console.WriteLine("File dont exist!");
                return;
            }
            string textFile = File.ReadAllText(pathFile);
            char[] rozdilyatory = { '.', ',', '?', '!', ' ' };
            string[] words = textFile.Split(rozdilyatory, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount.Add(word, 1);
                }
            }
            Console.WriteLine("After analyze:");
            foreach (var counts in wordsCount)
            {
                Console.WriteLine($"Слово: '{counts.Key}' зустрічалось: {counts.Value} раз");
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("What do you want to do?(1 - read the files, 0 - Exit)");
                p = int.Parse(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Console.WriteLine("Input the path for text to file"); // C:\Users\user\source\repos\Lab_1(2)\Lab_1(2)\bin\Debug\net8.0\firstFile.txt
                        string? pathText = Console.ReadLine();
                        if (!File.Exists(pathText))
                        {
                            Console.WriteLine("File dont exist!");
                            continue;
                        }
                        string fileText = File.ReadAllText(pathText);
                        Console.WriteLine("In File:\n" + fileText);
                        do
                        {
                            Console.WriteLine("Which file you want to analyze?(1 - A book of adventures, 2 - Castle and king, 3 - Evening walk," +
                            " 4 - River and forest, 5 - The road to home, 0 - Exit)");
                            k = int.Parse(Console.ReadLine());
                            switch (k)
                            {
                                case 1:
                                    string pathFile1 = "C:\\Users\\user\\source\\repos\\Lab_1(2)\\Lab_1(2)\\bin\\Debug\\net8.0\\A book of adventures.txt";
                                    AnalyzeFile(pathFile1);
                                    break;
                                case 2:
                                    string pathFile2 = "C:\\Users\\user\\source\\repos\\Lab_1(2)\\Lab_1(2)\\bin\\Debug\\net8.0\\Castle and king.txt";
                                    AnalyzeFile(pathFile2);
                                    break;
                                case 3:
                                    string pathFile3 = "C:\\Users\\user\\source\\repos\\Lab_1(2)\\Lab_1(2)\\bin\\Debug\\net8.0\\Evening walk.txt";
                                    AnalyzeFile(pathFile3);
                                    break;
                                case 4:
                                    string pathFile4 = "C:\\Users\\user\\source\\repos\\Lab_1(2)\\Lab_1(2)\\bin\\Debug\\net8.0\\River and forest.txt";
                                    AnalyzeFile(pathFile4);
                                    break;
                                case 5:
                                    string pathFile5 = "C:\\Users\\user\\source\\repos\\Lab_1(2)\\Lab_1(2)\\bin\\Debug\\net8.0\\The road to home.txt";
                                    AnalyzeFile(pathFile5);
                                    break;
                                case 0:
                                    Console.WriteLine("Exit.....");
                                    break;
                                default:
                                    Console.WriteLine("You input a wrong number!!!!!");
                                    break;
                            }
                        }
                        while (k != 0);
                        break;
                    case 0:
                        Console.WriteLine("Exit.....");
                        break;
                    default:
                        Console.WriteLine("You input a wrong number!!!!!");
                        break;
                }
            }
            while (p != 0 );
        }
    }
}
