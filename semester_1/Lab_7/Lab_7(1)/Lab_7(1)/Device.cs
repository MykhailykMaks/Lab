using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_
{
    internal class Device : IComparable<Device>, ICloneable
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
        public object Clone()
        {
            return new Device { NameOfDevice = this.NameOfDevice, CostOfDevice = this.CostOfDevice, DateOfCreateDevice = this.DateOfCreateDevice };
        }
        public int CompareTo(Device obj)
        {
            Device device = (Device)obj;
            if (this.NameOfDevice.Length > device.NameOfDevice.Length)
                return 1;
            else if (this.NameOfDevice.Length < device.NameOfDevice.Length)
                return -1;
            else
                return 0;
        }
    }
}