using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    class Modem : DeviceForCommunicate
    {
        public string? modemName;
        public int modemNumber;
        public Modem() : base()
        {
            modemName = string.Empty;
            modemNumber = 0;
        }
        public Modem(string modemName, int modemNumber) : base()
        {
            this.modemName = modemName;
            this.modemNumber = modemNumber;
        }
        public string ModemName
        {
            get { return modemName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                modemName = value;
            }
        }
        public int ModemNumber
        {
            get { return modemNumber; }
            set
            {
                if (int.TryParse(value.ToString(), out int parsedNumber))
                {
                    throw new ArgumentException("Phone number must be whole number");
                }
                modemNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Name of modem: {modemName}, Number of modem: {modemNumber}\n";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Modem)
            {
                return ToString().Equals(((Modem)obj).ToString());
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string PhoneNumbers()
        {
            return ($"All numbers: {modemNumber}");
        }
    }
}
