using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3_
{
    public class Worker : Employer
    {
        public Worker(string name, string surname, string education, DateTime birthDate, int experience, double salary)
            : base(name, surname, education, "Worker", birthDate, experience, salary) { }
    }
}
