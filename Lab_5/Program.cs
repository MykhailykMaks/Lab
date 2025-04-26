using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
        enum TypeOfWork
        {
            Home, Business, Server
        }
    internal class Device
    {
        public string NameOfDevice { get; set; }
        public string CostOfDevice { get; set; }
        public DateTime DateOfCreateDevice { get; set; }
        public Device()
        {
            NameOfDevice = string.Empty;
            CostOfDevice = string.Empty;
            DateOfCreateDevice = DateTime.Now;
        }
        public Device(string NameOfDevice, string CostOfDevice, DateTime DateOfCreateDevice)
        {
            this.NameOfDevice = NameOfDevice;
            this.CostOfDevice = CostOfDevice;
            this.DateOfCreateDevice = DateOfCreateDevice;
        }
        public override string ToString()
        {
            return $"Name of device: {NameOfDevice}, Cost of device: {CostOfDevice}, Date of create device: {DateOfCreateDevice}";
        }

    }
    static void Main(string[] args)
    {
        Computer computer = new Computer();
        Console.WriteLine(computer.ToShortString());
        Console.WriteLine("Indexators:");
        Console.WriteLine(TypeOfWork.Home);
        Console.WriteLine(TypeOfWork.Server);
        Console.WriteLine(TypeOfWork.Business);
        computer.Person = "";
        computer.TypeOfWork = TypeOfWork.Home;
        computer.IPaddress = "";
        Device computer2 = new Device();
        Console.WriteLine(computer.ToString());
        computer.AddDevices();
        Console.WriteLine($"Update list of devices: {computer}");
        Device[] computers = new Device[] { computer1, computer2, computer3, computer4, computer5 };
    }
}
