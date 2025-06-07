using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace water
{
    public class Program
    {
        class SortByDepth : IComparer<Water>
        {
            public int Compare(Water a, Water b)
            {
                if (a == null || b == null) return 0;
                return a.depthOfWater.CompareTo(b.depthOfWater);
            }
        }
        static void Main(string[] args)
        {
            Water[] waters = { Create.GetRandomPool(), Create.GetRandomPool(), Create.GetRandomSea(), Create.GetRandomSea() };
            foreach (Water water in waters)
            {
                Console.WriteLine(water.ToString());
            }
            Array.Sort(waters, new SortByDepth());
            Console.WriteLine("Sorted by depth:");
            foreach (Water water in waters)
            {
                Console.WriteLine(water.ToString());
                water.ShowInfoOfWater();
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Water[]), new Type[] { typeof(Pool), typeof(Sea) });
            using (FileStream fs = new FileStream("waters.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, waters);
                Console.WriteLine("Data has been saved to file");
            }
        }
    }
}
