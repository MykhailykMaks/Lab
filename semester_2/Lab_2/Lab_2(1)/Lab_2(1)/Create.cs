using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1_
{
    internal class Create
    {
        public static List<Company> GetRandomCompanies()
        {
            return new List<Company>
            {
                new Company("WhiteFood", "01.03.2019", "Маркетинг", "White James Edward", 250, "London, Baker Street 12"),
                new Company("TechVision", "15.04.2015", "IT", "Ivanenko Oleg Ivanovich", 120, "Kyiv, Khreshchatyk 10"),
                new Company("GreenMarket", "20.05.2022", "Маркетинг", "Black Dmytro Petrovych", 80, "Lviv, Svobody Ave 25"),
                new Company("SkyFood", "10.01.2021", "Food Industry", "Brown Anna Oleksiivna", 320, "London, Oxford Street 7"),
                new Company("EcoBuild", "12.12.2020", "Будівництво", "Kovalenko Mykola Andriyovych", 50, "Kharkiv, Sumskaya 22"),
                new Company("MarketPro", "25.02.2018", "Маркетинг", "Petrenko Iryna Sergiivna", 200, "Odesa, Deribasivska 5"),
                new Company("FinWhite", "30.07.2019", "Фінанси", "Black Mykola Yuriyovych", 110, "Kyiv, Kharkivske Shose 15"),
                new Company("ITWorld", "05.06.2017", "IT", "Sydorenko Danylo Viktorovych", 450, "Dnipro, Gagarina Ave 9"),
                new Company("FoodExpress", "10.11.2023", "Food", "Melnychuk Olena Ivanivna", 90, "London, Green Street 20"),
                new Company("WhiteGroup", "01.08.2016", "IT", "Black Taras Oleksiyovych", 150, "Lviv, Franka 8")
            };
        }
    }
}
