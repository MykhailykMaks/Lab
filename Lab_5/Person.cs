using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Person
    {
        string firstName;
        string lastName;
        private DateTime birthDate;

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public Person()
        {
            firstName = String.Empty;
            lastName = String.Empty;
            birthDate = DateTime.Now;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate 
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public int YearOfBirth
        {
            get { return BirthDate.Year; }
            set { birthDate = new DateTime(value, birthDate.Month, birthDate.Day); }
        }
        public override string ToString()
        {
            return ($"Name:{firstName}, last name: {lastName}, date of birth: {birthDate}");
        }
        public string ToShortString()
        {
            return ($"Name:{firstName}, last name: {lastName}");
        }
    }
}

