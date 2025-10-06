using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1_
{
    internal class Company
    {
        public string name;
        public string date;
        public string typeOfBusiness;
        public string pibCEO;
        public int countWorkers;
        public string address;


        public Company(string name, string date, string typeOfBusiness, string pibCEO, int countWorkers, string address)
        {
            this.name = name;
            this.date = date;
            this.typeOfBusiness = typeOfBusiness;
            this.pibCEO = pibCEO;
            this.countWorkers = countWorkers;
            this.address = address;
        }

        public Company()
        {
            name = "";
            date = "";
            typeOfBusiness = "";
            pibCEO = "";
            countWorkers = 0;
            address = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string TypeOfBusiness
        {
            get { return typeOfBusiness; }
            set { typeOfBusiness = value; }
        }

        public string PIBCEO
        {
            get { return pibCEO; }
            set { pibCEO = value; }
        }

        public int CountWorkers
        {
            get { return countWorkers; }
            set { countWorkers = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            return $"Company name: {name}, Founded: {date}, Type of business: {typeOfBusiness}, CEO: {pibCEO}, Workers: {countWorkers}, Address: {address}";
        }
    }
}


