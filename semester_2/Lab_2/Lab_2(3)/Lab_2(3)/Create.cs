using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3_
{
    internal class Create
    {
        private static Random random = new Random();
        private static string[] names = { "Volodymyr", "Volodymyr", "Sasha", "Bogdan", "Dmytro", "Nazar" };
        private static string[] surnames = { "Smith", "Smirnov", "Koen", "Kozak", "Bobuh", "KurbanMuhamedov" };
        private static int[] ages = { 35, 38, 32, 29, 28, 42, 19, 24 };
        private static string[] educations = { "High", "Mid" };
        private static int[] experiences = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        private static double[] salarys = { 15000, 20000, 25000, 30000, 40000 };
        public static DateTime GetRandomDateOfBirth()
        {
            int years = random.Next(1, 60);
            int months = random.Next(1, 13);
            int days = random.Next(1, 29);
            return DateTime.Now.AddYears(-years).AddMonths(-months).AddDays(-days);
        }
        public static string GetRandomName()
        {
            return names[random.Next(0, names.Length)];
        }
        public static string GetRandomSurname()
        {
            return surnames[random.Next(0, surnames.Length)];
        }
        public static int GetRandomAge()
        {
            return ages[random.Next(0, ages.Length)];
        }
        public static string GetRandomEducation()
        {
            return educations[random.Next(0, educations.Length)];
        }
        public static int GetRandomExperience()
        {
            return experiences[random.Next(0, experiences.Length)];
        }
        public static double GetRandomSalary()
        {
            return salarys[random.Next(0, salarys.Length)];
        }
        public static President GetRandomPresident()
        {
            return new President(GetRandomName(), GetRandomSurname(), "High", GetRandomDateOfBirth(),GetRandomExperience(), 40000);
        }
        public static Manager GetRandomManager()
        {
            return new Manager(GetRandomName(), GetRandomSurname(), GetRandomEducation(), GetRandomDateOfBirth(), GetRandomExperience(), GetRandomSalary());
        }
        public static Worker GetRandomWorker()
        {
            return new Worker(GetRandomName(), GetRandomSurname(), GetRandomEducation(), GetRandomDateOfBirth(), GetRandomExperience(), GetRandomSalary());
        }
    }
}
