using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2_
{
    internal class Create
    {
        public static List<Phone> GetRandomPhones()
        {
            return new List<Phone>
            {
                new Phone("iPhone 13", "Apple", 999, new DateTime(2021, 9, 24)),
                new Phone("iPhone 14", "Apple", 1199, new DateTime(2022, 9, 16)),
                new Phone("Galaxy S22", "Samsung", 899, new DateTime(2022, 2, 25)),
                new Phone("Galaxy S21", "Samsung", 799, new DateTime(2021, 1, 29)),
                new Phone("Pixel 6", "Google", 599, new DateTime(2021, 10, 28)),
                new Phone("Pixel 7", "Google", 699, new DateTime(2022, 10, 13)),
                new Phone("Xperia 1 IV", "Sony", 1200, new DateTime(2022, 5, 11)),
                new Phone("Xperia 5 III", "Sony", 899, new DateTime(2021, 8, 1)),
                new Phone("Redmi Note 11", "Xiaomi", 299, new DateTime(2022, 1, 26)),
                new Phone("Mi 11 Ultra", "Xiaomi", 749, new DateTime(2021, 3, 29)),
                new Phone("Nokia G20", "Nokia", 199, new DateTime(2021, 5, 17))
            };
        }
    }
}
