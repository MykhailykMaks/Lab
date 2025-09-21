using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3_
{
    internal class Create
    {
        private static Random random = new Random();
        public static string[] lastNames = { "Шевченко", "Ковальчук", "Ткаченко", "Бондаренко", "Мельник" };
        public static string[] names = { "Олександр", "Ірина", "Микита", "Ганна", "Денис" };
        public static string[] fathersNames = { "Вікторович", "Сергіївна", "Андрійович", "Олексіївна", "Юрійович" };
        public static int[] userPrioritys = { 1, 2, 3, 4, 5 };
        public static DateTime[] times = { DateTime.Now };

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
        public static string GetRandomPIB()
        {
            return $"{GetRandomLastName()} {GetRandomName()} {GetRandomFatherName()}";
        }
        public static int GetRandomPriority()
        {
            return userPrioritys[random.Next(userPrioritys.Length)];
        }
        public static DateTime GetRandomTime()
        {
            return times[random.Next(times.Length)];
        }
        public static User CreateRandomUser()
        {
            return new User(GetRandomPIB(), GetRandomPriority(), GetRandomTime());
        }
    }
}
