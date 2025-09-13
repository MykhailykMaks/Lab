using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water
{
    public class Sea : Water, IComparable<Sea>
    {
        public string whoIslivingInSea;
        public Sea() 
        {
            nameWater = "";
            depthOfWater = 0;
            temperature = 0;
            isCanSwim = true;
            whoIslivingInSea = "";
        }
        public Sea(string whoIslivingInSea, string nameWater, int depthOfWater, int temperature, bool isCanSwim)
        {
            this.nameWater = nameWater;
            this.depthOfWater = depthOfWater;
            this.temperature = temperature;
            this.isCanSwim = isCanSwim;
            this.whoIslivingInSea = whoIslivingInSea;
        }
        public override string WhoIsLivingInSea
        {
            get { return whoIslivingInSea; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                whoIslivingInSea = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int CompareTo(Sea obj)
        {
            Sea sea = (Sea)obj;
            if (this.nameWater.Length > sea.nameWater.Length)
                return 1;
            else if (this.nameWater.Length < sea.nameWater.Length)
                return -1;
            else
                return 0;
        }
        public override void ShowInfoOfWater()
        {
            Console.WriteLine($"This sea is inhabited by: {whoIslivingInSea}");
        }
    }
}
