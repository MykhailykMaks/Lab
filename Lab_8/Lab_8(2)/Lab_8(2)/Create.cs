using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2_
{
    class Create
    {
        static Random random = new Random();
        static string[] colors = { "Red", "Blue", "Green", "Black", "White" };
        static string[] manufacturers = { "Manufacturer1", "Manufacturer2", "Manufacturer3", "Manufacturer4" };
        static int[] weights = { 1, 2, 3, 4 ,5 };
        static int[] sizes = { 10, 20, 30, 40, 50 };    
        static int[] capacity = {5, 10, 15, 20, 25 };
        static string[] items = { "Item1", "Item2", "Item3", "Item4", "Item5" };
        static int[] sizesItems = { 1, 2, 3, 4, 5 };
        public static string GetRandomColor()
        {
            return colors[random.Next(colors.Length)];
        }
        public static string GetRandomManufacturer()
        {
            return manufacturers[random.Next(manufacturers.Length)];
        }
        public static int GetRandomWeight()
        {
            return weights[random.Next(weights.Length)];
        }
        public static int GetRandomSize()
        {
            return sizes[random.Next(sizes.Length)];
        }
        public static int GetRandomCapacity()
        {
            return capacity[random.Next(capacity.Length)];
        }
        public static string GetRandomItemName()
        {
            return items[random.Next(items.Length)];
        }
        public static int GetRandomItemSize()
        {
            return sizesItems[random.Next(sizesItems.Length)];
        }
        public static Items CreateItems()
        {
            return new Items(GetRandomItemName(), GetRandomItemSize());
        }
        public static Case CreateCase()
        {
            return new Case(GetRandomColor(), GetRandomManufacturer(), GetRandomWeight(), GetRandomSize(), new Items[0], GetRandomCapacity());
        }
    }
}
