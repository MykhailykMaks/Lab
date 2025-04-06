using System.Text.RegularExpressions;

namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "abcdefghijklmnopqrstuv18340";
            Regex regex = new Regex(phrase);
            Console.Write("Input a test phrase:");
            string inputPhrase = Console.ReadLine();
            if (regex.IsMatch(inputPhrase))
            {
                Console.WriteLine("phrase is correct");
            }
            else
            {
                Console.WriteLine("phrase is not correct");
            }
        }
    }
}
