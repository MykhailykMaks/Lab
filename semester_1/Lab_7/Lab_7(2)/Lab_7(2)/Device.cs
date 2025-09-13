using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    class Device : IDevice<Device>, IComparable<Device>, ICloneable
    {
        public string deviceName;
        public string deviceType;
        public bool isElectric;
        public bool isMatchEngine;

        public Device()
        {
            deviceName = "";
            deviceType = "";
            isElectric = false;
            isMatchEngine = false;
        }
        public Device(string deviceName, string deviceType, bool isElectric, bool isMatchEngine)
        {
            this.deviceName = deviceName;
            this.deviceType = deviceType;
            this.isElectric = isElectric;
            this.isMatchEngine = isMatchEngine;
        }
        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }
        public string DeviceType
        {
            get { return deviceType; }
            set { deviceType = value; }
        }
        public bool IsElectric
        {
            get { return isElectric; }
            set { isElectric = value; }
        }
        public bool IsMatchEngine
        {
            get { return isMatchEngine; }
            set { isMatchEngine = value; }
        }
        public override string ToString()
        {
            return $"Name of device: {deviceName}, Type of device: {deviceType}, Is device a electric?: {isElectric}, Is device match engine?: {isMatchEngine}";
        }
        public int CompareTo(Device obj)
        {
            Device device = (Device)obj;
            if (this.deviceName.Length > device.deviceName.Length)
                return 1;
            else if (this.deviceName.Length < device.deviceName.Length)
                return -1;
            else
                return 0;
        } 
        public object Clone()
        {
            return new Device { deviceName = this.deviceName, deviceType = this.deviceType, isElectric = this.isElectric, isMatchEngine = this.isMatchEngine };
        }
    }
}
