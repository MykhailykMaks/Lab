using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2_
{
    public class Phone
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Phone(string name, string manufacturer, double price, DateTime releaseDate)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $" Name of phone: {Name}, made by: {Manufacturer}, Price: {Price},  {ReleaseDate: dd.MM.yyyy}";
        }
    }
} 

