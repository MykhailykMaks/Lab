namespace Lab_2_2_
{
    internal class Program
    {
        static void Print(IEnumerable<Phone> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<Phone> phones = Create.GetRandomPhones();
            Print(phones);

            Console.WriteLine("All phones\n");
            Console.WriteLine(phones.Count);

            Console.WriteLine("Price > 100\n");
            Console.WriteLine(phones.Count(p => p.Price > 100));

            Console.WriteLine("400 < Price < 700\n");
            Console.WriteLine(phones.Count(p => p.Price >= 400 && p.Price <= 700));

            Console.WriteLine("Count of Samsungs\n");
            Console.WriteLine(phones.Count(p => p.Manufacturer == "Samsung"));

            Console.WriteLine("Min price\n");
            var minPricePhone = phones.MinBy(p => p.Price);
            Console.WriteLine(minPricePhone);

            Console.WriteLine("Max price\n");
            var maxPricePhone = phones.MaxBy(p => p.Price);
            Console.WriteLine(maxPricePhone);

            Console.WriteLine("The oldest phone\n");
            var oldestPhone = phones.MinBy(p => p.ReleaseDate);
            Console.WriteLine(oldestPhone);

            Console.WriteLine("The most new phone\n");
            var newestPhone = phones.MaxBy(p => p.ReleaseDate);
            Console.WriteLine(newestPhone);

            Console.WriteLine("Average price\n");
            Console.WriteLine($"{phones.Average(p => p.Price):F2}");

            Console.WriteLine("Top 5 by price\n");
            phones.OrderByDescending(p => p.Price).Take(5).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Top 5 by low price\n");
            phones.OrderBy(p => p.Price).Take(5).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Top 3 by age\n");
            phones.OrderBy(p => p.ReleaseDate).Take(3).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Top 3 by less age\n");
            phones.OrderByDescending(p => p.ReleaseDate).Take(3).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Infp about companies pf phones\n");
            var byManufacturer = phones
                .GroupBy(p => p.Manufacturer)
                .Select(g => new { Manufacturer = g.Key, Count = g.Count() });
            foreach (var item in byManufacturer)
                Console.WriteLine($"{item.Manufacturer} – {item.Count}");

            Console.WriteLine("Info about models pf phones\n");
            var byModel = phones
                .GroupBy(p => p.Name)
                .Select(g => new { Model = g.Key, Count = g.Count() });
            foreach (var item in byModel)
                Console.WriteLine($"{item.Model} – {item.Count}");

            Console.WriteLine("Info about years of release\n");
            var byYear = phones
                .GroupBy(p => p.ReleaseDate.Year)
                .Select(g => new { Year = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Year);
            foreach (var item in byYear)
                Console.WriteLine($"{item.Year} – {item.Count}");
        }
    }
}
