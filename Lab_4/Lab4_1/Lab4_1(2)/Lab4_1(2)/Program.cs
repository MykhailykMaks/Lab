using System.Text.RegularExpressions;

namespace Lab4_1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your GUID:");
            string input = Console.ReadLine();
            string phrase = @"^\{?[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}\}?$";

            bool isMatch = Regex.IsMatch(input, phrase);

            if (isMatch)
            {
                Console.WriteLine("Your input is eligible GUID");
            }
            else
            {
                Console.WriteLine("Your input is not eligible GUID");
            }
        }
    }
}
