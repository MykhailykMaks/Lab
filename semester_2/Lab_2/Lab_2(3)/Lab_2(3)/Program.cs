using System.Collections.Generic;

namespace Lab_2_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("TechVision Group");
            President president = Create.GetRandomPresident();
            company.AddEmployee(president);
            for (int i = 0; i < 10; i++)
            {
                var worker = Create.GetRandomWorker();
                company.AddEmployee(worker);
            }
            for (int i = 0; i < 5; i++)
            {
                var manager = Create.GetRandomManager();
                company.AddEmployee(manager);
            }
            Console.WriteLine($"Count of workers: {company.GetWorkerCount()}\n");
            Console.WriteLine($"Total salary: {company.GetTotalSalary()} grn\n");

            Console.WriteLine("Youngest with high education:");
            Console.WriteLine(company.GetYoungestHighEducated());

            var (young, old) = company.GetYoungestAndOldestManagers();
            Console.WriteLine("Managers:");
            Console.WriteLine($"Youngest: {young}");
            Console.WriteLine($"Oldest: {old}");

            Console.WriteLine("Born in october:");
            foreach (var e in company.GetBornInOctober())
                Console.WriteLine(e);

            Console.WriteLine("Volodymyry:");
            company.CongratulateVolodymyr();
        }
    }
}
