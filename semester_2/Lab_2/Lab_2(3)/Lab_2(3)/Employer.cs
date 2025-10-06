using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3_
{
    public class Employer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Education { get; set; }
        public string Position { get; set; }  
        public DateTime BirthDate { get; set; }
        public int Experience { get; set; }  
        public double Salary { get; set; }  

        public Employer(string name, string surname, string education, string position, DateTime birthDate, int experience, double salary)
        {
            Name = name;
            Surname = surname;
            Education = education;
            Position = position;
            BirthDate = birthDate;
            Experience = experience;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name and surname: {Name}, {Surname}, Age: {Age} years, Expetience: {Experience} years, Education: {Education}, Salary: {Salary,6} grn, Date of birth: {BirthDate: dd.MM.yyyy}";
        }
    }
}
