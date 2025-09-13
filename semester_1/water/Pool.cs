using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water
{
    public class Pool : Water, IComparable<Pool> 
    {
        public int capacity;
        public Pool()
        {
            nameWater = "";
            depthOfWater = 0;
            temperature = 0;
            isCanSwim = true;
            capacity = 0;
        }
        public Pool(int capacity, string nameWater, int depthOfWater, int temperature, bool isCanSwim)
        {
            this.nameWater = nameWater;
            this.depthOfWater = depthOfWater;
            this.temperature = temperature;
            this.isCanSwim = isCanSwim;
            this.capacity = capacity;
        }
        public override int Capacity
        {
            get { return capacity; }
            set
            {
                if (int.TryParse(value.ToString(), out int capacity))
                {
                    throw new ArgumentException("capacity must be whole number");
                }
                capacity = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int CompareTo(Pool obj)
        {
            Pool pool = (Pool)obj;
            if (this.nameWater.Length > pool.nameWater.Length)
                return 1;
            else if (this.nameWater.Length < pool.nameWater.Length)
                return -1;
            else
                return 0;
        }
        public override void ShowInfoOfWater()
        {
            Console.WriteLine($"This pool have a capacity: {capacity}");
        }  
    }
}
