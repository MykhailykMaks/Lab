using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_
{
    internal class Person : IComparable<Person>, ICloneable
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
        public object Clone()
        {
            return new Person { firstName = this.firstName, lastName = this.lastName, birthDate = this.birthDate };
        }
        public int CompareTo(Person obj)
        {
            Person person = (Person)obj;
            if (this.firstName.Length > person.firstName.Length)
                return 1;
            else if (this.firstName.Length < person.firstName.Length)
                return -1;
            else
                return 0;
        }
    }
}
