using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water
{
    public class Create
    {
        private static Random random = new Random();
        static string[] namesWater = { "Baltic Sea", "Red Sea", "Black Sea", "NaftoHimik", "SportLife" };
        static int[] depthsWater = { 100, 200, 300, 400, 500 };
        static int[] temperature = { 5, 10, 15, 20, 25 };
        static int[] capacity = { 2, 5, 10, 15, 20 };
        static string[] lifeInSea = { "fish", "octopus", "turtle", "dolphin", "stingray"};
        static bool[] isCanSwim = { true, false };

        public static string GetRandomNameWater()
        {
            return namesWater[random.Next(namesWater.Length)];
        }
        public static int GetRandomDepthOfWater()
        {
            return depthsWater[random.Next(depthsWater.Length)];
        }
        public static int GetRandomTemperature()
        {
            return temperature[random.Next(temperature.Length)];
        }
        public static int GetRandomCapacity()
        {
            return capacity[random.Next(capacity.Length)];
        }
        public static string GetRandomLifeInSea()
        {
            return lifeInSea[random.Next(lifeInSea.Length)];
        }
        public static bool GetRandomCanSwim()
        {
            return isCanSwim[random.Next(isCanSwim.Length)];
        }
        public static Pool GetRandomPool()
        {
            return new Pool(GetRandomCapacity(), GetRandomNameWater(), GetRandomDepthOfWater(), GetRandomTemperature(), GetRandomCanSwim());
        }
        public static Sea GetRandomSea()
        {
            return new Sea(GetRandomLifeInSea(), GetRandomNameWater(), GetRandomDepthOfWater(), GetRandomTemperature(), GetRandomCanSwim());
        }
    }
}
