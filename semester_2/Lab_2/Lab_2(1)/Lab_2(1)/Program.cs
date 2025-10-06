using System.Runtime.Intrinsics.X86;

namespace Lab_2_1_
{
    internal class Program
    {
        static void Print(IEnumerable<Company> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            const int n = 10;
            List<Company> companies = Create.GetRandomCompanies();
            // 1.Усі компанії
            Console.WriteLine("Created companies");
            Print(companies);

            // 2. Компанії, які мають назву Food
            var foodCompanies = companies.Where(c => c.Name.Contains("Food", StringComparison.OrdinalIgnoreCase));
            Print(foodCompanies);

            // 3. Компанії, що працюють у галузі маркетингу
            var marketingCompanies = companies.Where(c => c.TypeOfBusiness.Equals("Маркетинг", StringComparison.OrdinalIgnoreCase));
            Print(marketingCompanies);

            // 4. Компанії у галузі маркетингу або IT
            var marketingOrIT = companies.Where(c => c.TypeOfBusiness.Equals("Маркетинг", StringComparison.OrdinalIgnoreCase) || c.TypeOfBusiness.Equals("IT", StringComparison.OrdinalIgnoreCase));
            Print(marketingOrIT);

            // 5. Компанії з кількістю працівників > 100
            var moreThan100 = companies.Where(c => c.CountWorkers > 100);
            Print(moreThan100);

            // 6. Компанії з кількістю працівників у діапазоні 100–300
            var count100to300 = companies.Where(c => c.CountWorkers >= 100 && c.CountWorkers <= 300);
            Print(count100to300);

            // 7. Компанії у Лондоні
            var london = companies.Where(c => c.Address.Contains("London", StringComparison.OrdinalIgnoreCase));
            Print(london);

            // 8. Компанії, директор яких має прізвище White
            var ceoWithWhite = companies.Where(c => c.PIBCEO.StartsWith("White", StringComparison.OrdinalIgnoreCase));
            Print(ceoWithWhite);

            // 9. Компанії, засновані понад два роки тому
            var olderThan2Years = companies.Where(c => {
                if (DateTime.TryParse(c.Date, out DateTime founded))
                     return (DateTime.Now - founded).TotalDays > 365 * 2;
                return false; });
            Print(olderThan2Years);

            // 10. Компанії, з дня заснування яких минуло більше 150 днів
            var olderThan150Days = companies.Where(c =>
            {
                if (DateTime.TryParse(c.Date, out DateTime founded))
                    return (DateTime.Now - founded).TotalDays > 150;
                return false;
            });
            Print(olderThan150Days);

            // 11. Компанії, де CEO має прізвище Black і назва містить White
            var blackWhite = companies.Where(c => c.PIBCEO.StartsWith("Black", StringComparison.OrdinalIgnoreCase) && c.Name.Contains("White", StringComparison.OrdinalIgnoreCase));
            Print(blackWhite);
        }
    }
}
