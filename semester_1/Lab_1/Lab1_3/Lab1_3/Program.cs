namespace Lab1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            Console.WriteLine("Try yourself");
            Console.Write("Професор ліг спати о 8 годині, а встав о 9 годині. Скільки годин проспав професор?\n");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                ++point;
            }
            Console.Write("На двох руках десять пальців. Скільки пальців на 10 руках?\n");
            int answer2 = int.Parse(Console.ReadLine());
            if (answer2 == 50)
            {
                ++point;
            }
            Console.Write("Скільки цифр у дюжині?\n");
            int answer3 = int.Parse(Console.ReadLine());
            if (answer3 == 2)
            {
                ++point;
            }
            Console.Write("Скільки потрібно зробити розпилів, щоб розпиляти колоду на 12 частин?\n");
            int answer4 = int.Parse(Console.ReadLine());
            if (answer4 == 11)
            {
                ++point;
            }
            Console.Write("Лікар зробив три уколи в інтервалі 30 хвилин. Скільки часу він витратив?\n");
            int answer5 = int.Parse(Console.ReadLine());
            if (answer5 == 30)
            {
                ++point;
            }
            Console.Write("Скільки цифр 9 в інтервалі 1100?\n");
            int answer6 = int.Parse(Console.ReadLine());
            if (answer6 == 1)
            {
                ++point;
            }
            Console.Write("Пастух мав 30 овець.Усі, окрім однієї, розбіглися. Скільки овець лишилося?\n");
            int answer7 = int.Parse(Console.ReadLine());
            if (answer7 == 1)
            {
                ++point;
            }
            switch (point)
            {
                case 1:

                case 2:
                    Console.WriteLine("Вам треба відпочити!");
                    break;
                case 3:
                    Console.WriteLine("Здібності нижче середнього");
                    break;
                case 4:
                    Console.WriteLine("Здібності середні");
                    break;
                case 5:
                    Console.WriteLine("Нормальний");
                    break;
                case 6:
                    Console.WriteLine("Ерудит");
                    break;
                case 7:
                    Console.WriteLine("Геній");
                    break;
                default:
                    Console.WriteLine("Something happens");
                    break;
            }
            Console.WriteLine("Тест закінчений");
            Console.ReadKey();
        }
    }
}
