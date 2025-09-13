using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
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
}
