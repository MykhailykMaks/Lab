using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    abstract class DeviceForCommunicate
    {
        public string? deviceName;
        public string? typeOfDevice;
        public int deviceNumber;

        public DeviceForCommunicate()
        {
            deviceNumber = 0;
            deviceName = String.Empty;
            typeOfDevice = String.Empty;
        }

        public DeviceForCommunicate(string? deviceName, string? typeOfDevice, int deviceNumber)
        {
            this.deviceName = deviceName;
            this.typeOfDevice = typeOfDevice;
            this.deviceNumber = deviceNumber;
        }
        public string? DeviceName {
            get { return deviceName; }
            set
            { 
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException("value");
                }
                deviceName = value;
            }
        }
        public string? TypeOfDevice
        {
            get { return typeOfDevice; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                typeOfDevice = value;
            }
        }
        public int DeviceNumber
        {
            get { return deviceNumber; }
            set
            {
                if (int.TryParse(value.ToString(), out int parsedNumber))
                {
                    throw new ArgumentException("Phone number must be whole number");
                }
                deviceNumber = value;
            }
        }
        public string giveMeDeviceNumber
        {
            get { return deviceNumber.ToString(); }
            set { value = deviceNumber.ToString(); }
        }
        public override string ToString()
        {
            return ($"Name of device: {deviceName}, Type of device: {typeOfDevice}, Phone number: {deviceNumber}\n");
        }
        public abstract string PhoneNumbers();
    }
}
