using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    class LandlinePhone : DeviceForCommunicate
    {
        public string phoneName;
        public int phoneNumber;

        public LandlinePhone() : base()
        {
            phoneName = string.Empty;
            phoneNumber = 0;
        }
        public LandlinePhone(string phoneName, int phoneNumber) : base()
        {
            this.phoneName = phoneName;
            this.phoneNumber = phoneNumber;
        }
        public string PhoneName
        {
            get { return phoneName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                phoneName = value;
            }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (int.TryParse(value.ToString(), out int parsedNumber))
                {
                    throw new ArgumentException("Phone number must be whole number");
                }
                phoneNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Name of phone: {phoneName}, Number of phone: {phoneNumber}\n";
        }
        public override bool Equals(object? obj)
        {
            if (obj is LandlinePhone)
            {
                return ToString().Equals(((LandlinePhone)obj).ToString());
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string PhoneNumbers()
        {
            return ($"All numbers: {phoneNumber}");
        }
    }
}
