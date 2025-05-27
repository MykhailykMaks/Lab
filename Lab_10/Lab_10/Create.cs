using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    internal class Create
    {
        private static Random random = new Random();
        public static string[] lastNames = { "Шевченко", "Ковальчук", "Ткаченко", "Бондаренко", "Мельник" };
        public static string[] names = { "Олександр", "Ірина", "Микита", "Ганна", "Денис" };
        public static string[] fathersNames = { "Вікторович", "Сергіївна", "Андрійович", "Олексіївна" ,"Юрійович" };
        public static string[] parties = { "Партія А", "Партія Б", "Партія В", "Партія Г", "Партія Д" };
        public static string[] datesOfBirth = { "01.01.1980", "15.05.1990", "20.10.1985", "30.03.1975", "25.12.2000" };
        public static int[] popularityIndexes = { 100, 200, 300, 400, 500 };

        public static string GetRandomLastName()
        {
            return lastNames[random.Next(lastNames.Length)];
        }
        public static string GetRandomName()
        {
            return names[random.Next(names.Length)];
        }
        public static string GetRandomFatherName()
        {
            return fathersNames[random.Next(fathersNames.Length)];
        }
        public static string GetRandomPartia()
        {
            return parties[random.Next(parties.Length)];
        }
        public static string GetRandomDateOfBirth()
        {
            return datesOfBirth[random.Next(datesOfBirth.Length)];
        }
        public static int GetRandomPopularityIndex()
        {
            return popularityIndexes[random.Next(popularityIndexes.Length)];
        }
        public static string GetRandomPIB()
        {
            return $"{GetRandomLastName()} {GetRandomName()} {GetRandomFatherName()}";
        }
        public static Candidate CreateRandomCandidate()
        {
            return new Candidate(GetRandomPIB(), GetRandomDateOfBirth(), GetRandomPartia(), GetRandomPopularityIndex());
        }
    }
}
