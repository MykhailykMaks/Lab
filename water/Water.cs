using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water
{
    public abstract class Water : IComparable<Water>
    {
        public string nameWater { get; set; }
        public int depthOfWater { get; set; }
        public int temperature { get; set; }
        public bool isCanSwim { get; set; }
        public virtual int Capacity { get; set; }
        public virtual string WhoIsLivingInSea { get; set; }
        public override string ToString()
        {
            return ($"Name of Water: {nameWater}, Depth of water: {depthOfWater}, temperature: {temperature}, Did I Swim here: {isCanSwim}");
        }
        public int CompareTo(Water obj)
        {
            Water water = (Water)obj;
            if (this.nameWater.Length > water.nameWater.Length)
                return 1;
            else if (this.nameWater.Length < water.nameWater.Length)
                return -1;
            else
                return 0;
        }
        public abstract void ShowInfoOfWater();
    }
}
