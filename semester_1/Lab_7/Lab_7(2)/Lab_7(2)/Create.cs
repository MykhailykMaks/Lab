using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    internal class Create
    {
        private static Random random = new Random();
        static string[] deviceTypes = { "Plane", "Helicopter", "FlyingCarpet", "FlyingBaloon", "Deltaplan" };
        static string[] deviceNames = { "aaaa", "nnnn", "bbbb", "xxxx", "cccc", "rrrr", "mmmm" };
        static int[] capacity = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static bool[] matchEngine = {true, false};
        static bool[] isElectic = {true, false};

        public static string GetRandomDeviceType()
        {
            return deviceTypes[random.Next(deviceTypes.Length)];
        }
        public static string GetRandomDeviceName()
        {
            return deviceNames[random.Next(deviceNames.Length)];
        }
        public static int GetRandomCapacity()
        {
            return capacity[random.Next(capacity.Length)];
        }
        public static bool GetRandomMatchEngine()
        {
            return matchEngine[random.Next(matchEngine.Length)];
        }
        public static bool GetRandomIsElectic() 
        {
            return isElectic[random.Next(isElectic.Length)];
        }
        public static Device GetRandomDevice()
        {
            return new Device(GetRandomDeviceName(), GetRandomDeviceType(), GetRandomMatchEngine(), GetRandomIsElectic());
        }
    }
}
