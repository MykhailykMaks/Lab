using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    internal class FlyingCarpet : Device, IDevice<FlyingCarpet>, IEngine<FlyingCarpet>, IPart<FlyingCarpet>, IComparable<FlyingCarpet>
    {
        public int capacity;
        public string engineName { get; set; }
        public string engineType { get; set; }
        public int enginePower { get; set; }
        public string partName { get; set; }
        public int partWeight { get; set; }
        public int partCost { get; set; }

        public FlyingCarpet() : base()
        {
            engineName = "";
            engineType = "";
            enginePower = 0;
            partWeight = 0;
            partCost = 0;
            capacity = 0;
            isElectric = false;
            isMatchEngine = false;
        }
        public FlyingCarpet(string deviceName, string deviceType, int capacity, bool isMatchEngine, bool isElectric) : base(deviceName, deviceType, isElectric, isMatchEngine)
        {
            this.engineName = engineName;
            this.engineType = engineType;
            this.enginePower = enginePower;
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
        public string ToStringEngine()
        {
            return $"Name of engine: {engineName}, Type of engine: {engineType}, Power of engine: {enginePower}";
        }
        public string ToStringPart()
        {
            return $"Name of part: {partName}, Weight of part: {partWeight}, Cost of part: {partCost}";
        }
        public int CompareTo(FlyingCarpet obj)
        {
            FlyingCarpet plane = (FlyingCarpet)obj;
            if (this.deviceName.Length > plane.deviceName.Length)
                return 1;
            else if (this.deviceName.Length < plane.deviceName.Length)
                return -1;
            else
                return 0;
        }
        public object Clone()
        {
            return new Plane { deviceName = this.deviceName, deviceType = this.deviceType, engineName = this.engineName, engineType = this.engineType, enginePower = this.enginePower, partName = this.partName, partWeight = this.partWeight, partCost = this.partCost };
        }
    }
}
