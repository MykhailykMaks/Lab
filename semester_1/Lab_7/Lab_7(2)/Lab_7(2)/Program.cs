using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    internal class Program
    {
        class SortByType : IComparer<Device>
        {
            public int Compare(Device a, Device b)
            {
                if (a == null || b == null) return 0;
                return a.deviceType[0].CompareTo(b.deviceType[0]);
            }
        }
        class SortByName : IComparer<Device>
        {
            public int Compare(Device a, Device b)
            {
                if (a == null || b == null) return 0;
                return a.deviceName[0].CompareTo(b.deviceName[0]);
            }
        }
        static void Main(string[] args)
        {
            Device device1 = Create.GetRandomDevice();
            Device device2 = Create.GetRandomDevice();
            Device device3 = Create.GetRandomDevice();
            Device device4 =  (Device)device3.Clone();
            Device[] devices = { device1, device2, device3, device4 };
            Console.WriteLine("All devices");
            Register.Print(devices);
            Console.WriteLine("Devices without engine");
            Register.PrintWithoutEngine(devices);
            Console.WriteLine("Electrical devices ");
            Register.PrintElectical(devices);
            Array.Sort(devices, new SortByType());
            Console.WriteLine("Sorted by type devices");
            foreach (Device device in devices)
            {
                Console.WriteLine(device.ToString());
            }
            Array.Sort(devices, new SortByName());
            Console.WriteLine("Sorted by name devices");
            foreach (Device device in devices)
            {
                Console.WriteLine(device.ToString());
            }
        }
    }
}
