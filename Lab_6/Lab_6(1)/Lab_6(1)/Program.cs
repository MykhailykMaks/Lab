using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Triada[] test = {Create.GetRandomTriada(), Create.GetRandomTriada(), Create.GetRandomTime(), Create.GetRandomTime() };
            foreach (var item in test)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Objects after metods");
            foreach (var item in test)
            {
                item.PlusOne();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
