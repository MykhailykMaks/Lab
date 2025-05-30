﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    static class Create
    {
        private static Random random = new Random();
        static int[] devicesNumbers = { 27096457, 03225363, 0674582709, 0971204567, 0442709223, 0327532709 };
        static int[] phoneNumbers = {0442709123, 0322532709, 0577563012, 0612137045 };
        static int[] mobilePhoneNumbers = { 0674562709, 0971234567, 0987654321, 0954527090 };
        static int[] modemNumbers = { 27096437, 03225343, 77562709, 12137045 };
        static string[] devicesTypes = { "Phone", "Mobile Phone", "Modem" };
        static string[] devicesNames = { "Device1", "Device2", "Device3", "Device4", "Device5" };
        static string[] phoneNames = { "Panasonic", "Siemens", "Alcatel", "Motorola" };
        static string[] mobilePhoneNames = { "Google", "Samsung", "Xiaomi", "Apple" };
        static string[] modemNames = { "TP-Link", "D-Link", "Netgear", "Asus" };

        public static int GetRandomPhoneNumber()
        {
            return phoneNumbers[random.Next(phoneNumbers.Length)];
        }
        public static int GetRandomMobilePhoneNumber()
        {
            return mobilePhoneNumbers[random.Next(mobilePhoneNumbers.Length)];
        }
        public static int GetRandomModemNumber()
        {
            return modemNumbers[random.Next(modemNumbers.Length)];
        }
        public static string GetRandomPhoneName()
        {
            return phoneNames[random.Next(phoneNames.Length)];
        }
        public static string GetRandomMobilePhoneName()
        {
            return mobilePhoneNames[random.Next(mobilePhoneNames.Length)];
        }
        public static string GetRandomModemName()
        {
            return modemNames[random.Next(modemNames.Length)];
        }
        public static string GetRandomDeviceName()
        {
            return devicesNames[random.Next(devicesNames.Length)];
        }
        public static int GetRandomDeviceNumber()
        {
            return devicesNumbers[random.Next(devicesNumbers.Length)];
        }
        public static LandlinePhone GetRandomPhone()
        {
            return new LandlinePhone(GetRandomDeviceName(), devicesTypes[0], GetRandomDeviceNumber(), GetRandomPhoneName(), GetRandomPhoneNumber());
        }
        public static MobilePhone GetRandomMobilePhone()
        {
            return new MobilePhone(GetRandomDeviceName(), devicesTypes[1], GetRandomDeviceNumber(), GetRandomMobilePhoneName(), GetRandomMobilePhoneNumber());
        }
        public static Modem GetRandomModem()
        {
            return new Modem(GetRandomDeviceName(), devicesTypes[2], GetRandomDeviceNumber(), GetRandomModemName(), GetRandomModemNumber());
        }
    }
}
