using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    internal class FlyingBaloons : Device, IDevice<FlyingBaloons>,  IPart<FlyingBaloons>, IComparable<FlyingBaloons>
    {
        public int capacity;
        public string partName { get; set; }
        public int partWeight { get; set; }
        public int partCost { get; set; }

        public FlyingBaloons() : base()
        {
            partWeight = 0;
            partCost = 0;
            capacity = 0;
            isElectric = false;
            isMatchEngine = false;
        }
        public FlyingBaloons(string deviceName, string deviceType, int capacity, bool isMatchEngine, bool isElectric) : base(deviceName, deviceType, isElectric, isMatchEngine)
        {
            this.partWeight = partWeight;
            this.partCost = partCost;
            this.capacity = capacity;
            isElectric = false;
            isMatchEngine = false;
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public string IsMatchEngine()
        {
            return $"Does device match engine? {isMatchEngine}";
        }
        public string IsElectric()
        {
            return $"Is device electric? {isElectric}";
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public string ToStringPart()
        {
            return $"Name of part: {partName}, Weight of part: {partWeight}, Cost of part: {partCost}";
        }
        public int CompareTo(FlyingBaloons obj)
        {
            FlyingBaloons plane = (FlyingBaloons)obj;
            if (this.deviceName.Length > plane.deviceName.Length)
                return 1;
            else if (this.deviceName.Length < plane.deviceName.Length)
                return -1;
            else
                return 0;
        }
        public object Clone()
        {
            return new Plane { deviceName = this.deviceName, deviceType = this.deviceType, partName = this.partName, partWeight = this.partWeight, partCost = this.partCost };
        }
    }
}
