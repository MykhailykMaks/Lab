using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3_
{
    public class Company
    {
        public string Name { get; set; }
        public List<Employer> Employers { get; set; }

        public Company(string name)
        {
            Name = name;
            Employers = new List<Employer>();
        }
        public void AddEmployee(Employer employee)
        {
            Employers.Add(employee);
        }
        public int GetWorkerCount() => Employers.Count(e => e.Position == "Worker");
        public double GetTotalSalary() => Employers.Sum(e => e.Salary);
        public Employer GetYoungestHighEducated()
        {
            return Employers.OrderByDescending(e => e.Experience).Take(10).Where(e => e.Education == "High").OrderBy(e => e.Age).FirstOrDefault();
        }
        public (Employer Youngest, Employer Oldest) GetYoungestAndOldestManagers()
        {
            var managers = Employers.Where(e => e.Position == "Manager");
            return (managers.OrderBy(e => e.Age).FirstOrDefault(), managers.OrderByDescending(e => e.Age).FirstOrDefault());
        }
        public IEnumerable<Employer> GetBornInOctober()
        {
            return Employers.Where(e => e.BirthDate.Month == 10).OrderBy(e => e.Position);
        }
        public void CongratulateVolodymyr()
        {
            var volodymyrs = Employers.Where(e => e.Name == "Volodymyr");
            if (!volodymyrs.Any())
            {
                Console.WriteLine("No one Volodymyr.");
                return;
            }
            foreach (var v in volodymyrs)
                Console.WriteLine(v);
            var youngest = volodymyrs.OrderBy(e => e.Age).First();
            double bonus = youngest.Salary / 3;
            Console.WriteLine($"Congratulations!!!! {youngest.Name} {youngest.Surname} with bonus {bonus:F2} grn");
        }
    }
}
