using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeviceForCommunicate[] devices = { Create.GetRandomPhone(), Create.GetRandomPhone(), Create.GetRandomMobilePhone(), Create.GetRandomMobilePhone(), Create.GetRandomModem(), Create.GetRandomModem() };
            for (int i = 0; i < devices.Length; i++)
            {
                Console.WriteLine(devices[i].ToString());
            }
            for (int i = 0; i < devices.Length; i++)
            {
                bool isMatch = Regex.IsMatch(devices[i].DeviceNumber.ToString(), "2709");

                if (isMatch == true)
                {
                    Console.WriteLine(devices[i].ToString());
                }   
            }
        }
    }
}
