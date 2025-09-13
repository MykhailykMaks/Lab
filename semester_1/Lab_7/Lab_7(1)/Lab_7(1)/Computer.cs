using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_7_1_
{
    internal class Computer : IFileContainer<Device>, IEnumerable<Device>, IEnumerator<Device>
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
            foreach (Device device in newDevices)
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
        public int Count
        {
            get { return devices.Length; }
        }
        public Device this[int index]
        {
            get { return devices[index]; }
            set
            {
                if (index < 0 || index >= devices.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                devices[index] = value;
            }
        }
        public void Add(Device item)
        {
            Array.Resize(ref devices, devices.Length + 1);
            devices[devices.Length - 1] = item;
            IsDataSaved = false;
        }
        public void Delete(Device item)
        {
            Device[] newDevices = new Device[devices.Length - 1];
            int index = Array.IndexOf(devices, item);
            int j = 0;
            if (index >= 0)
            {
                for (int i = 0; i < devices.Length; i++)
                {
                    if (i != index)
                    {
                        newDevices[j] = devices[i];
                        j++;
                    }
                }
            }
            devices = newDevices;
            IsDataSaved = false;
        }
        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Device item in devices)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            IsDataSaved = true;
        }
        public void Load(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            Device[] newDevices = new Device[devices.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string namePart = parts[0];
                string costPart = parts[1];
                string datePart = parts[2];
                Device device = new Device(namePart, costPart, DateTime.Parse(datePart));
                newDevices[i] = (Device)device;
            }
            devices = newDevices;
            IsDataSaved = true;
        }
        public bool IsDataSaved { get; set; }

        public IEnumerator<Device> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<Device>)GetEnumerator();
        }
        private int position = 0;
        public Device Current
        {
            get { return devices[position]; }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public bool MoveNext()
        {
            position++;
            return (position < devices.Length);
        }
        public void Reset()
        {
            position = 0;
        }
        public void Dispose()
        {
            
        }
    }
}