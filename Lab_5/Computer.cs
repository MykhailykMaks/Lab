using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Computer
    {
        private Person? person;
        private TypeOfWork typeOfWork;
        private string ipAddress;
        private Device[] devices;
        private int totalCost = 0;

        public Computer(Person person, TypeOfWork typeOfWork, string ipAddress, Device[] devices)
        {
            this.person = person;
            this.typeOfWork = typeOfWork;
            this.ipAddress = ipAddress;
            this.devices = devices;
        }
        public Computer()
        {
            person = null;
            typeOfWork = TypeOfWork.Home;
            ipAddress = "";
            devices = new Device[0];
        }
        public Person? Person
        {
            get { return person; }
            set
            {
                if (person == null)
                {
                    throw new ArgumentException("Information abiout person must not be empty!");
                }
                person = value;
            }
        }
        public TypeOfWork TypeOfWork
        {
            get { return typeOfWork; }
            set
            {
                if (!Enum.TryParse(value.ToString(), out TypeOfWork type))
                {
                    throw new ArgumentException("Type of work must be a valid type");
                }
                typeOfWork = type;
            }
        }
        public string IPaddress
        {
            get { return ipAddress; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("IP address must not be empty");
                }
                ipAddress = value; 
            }

        }
        public Device[] Devices
        {
            get { return devices; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Array of devices must not be empty");
                }
                devices = value;
            }
        }
        public double TotalCost
        {
            get
            {
                foreach (Device device in devices)
                {
                    if (int.TryParse(device.CostOfDevice, out int cost))
                    {
                        totalCost += cost;
                    }
                }
                return totalCost;
            }
        }
        public bool this[TypeOfWork typeOfWork]
        {
            get { return this.typeOfWork == typeOfWork; }
        }
        public void AddDevices(Device[] newDevices)
        {
            foreach(Device device in newDevices)
            {
                if (device != null)
                {
                    Array.Resize(ref devices, devices.Length + 1);
                    devices[devices.Length - 1] = device;
                }
            }
        }
        public override string ToString()
        {
            return $"Person: {person}, type of work: {TypeOfWork.Home}, IP address: {ipAddress}, devices: {devices}";
        }
        public string ToShortString()
        {
            return $"Person: {person}, type of work: {TypeOfWork.Home}, IP address: {ipAddress}, Total cost: {totalCost}";
        }
    }
}
