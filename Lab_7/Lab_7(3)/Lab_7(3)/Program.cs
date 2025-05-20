namespace Lab_7_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACipher cipher1 = new ACipher();
            Console.WriteLine("Enter text for cipher1:");
            cipher1.text = Console.ReadLine();
            Console.WriteLine("Encoded: ");
            Console.WriteLine(cipher1.encode(cipher1.text));
            Console.WriteLine("Decoded: ");
            Console.WriteLine(cipher1.decode(cipher1.text));
            BCipher cipher2 = new BCipher();
            Console.WriteLine("Enter text for cipher2: ");
            cipher2.text = Console.ReadLine();
            Console.WriteLine("Encoded: ");
            Console.WriteLine(cipher2.encode(cipher2.text));
            Console.WriteLine("Decoded: ");
            Console.WriteLine(cipher2.decode(cipher2.text));
        }
    }
}
