using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    class MobilePhone : DeviceForCommunicate
    {
        public string mobilePhoneName;
        public int mobilePhoneNumber;

        public MobilePhone() : base()
        {
            mobilePhoneName = string.Empty;
            mobilePhoneNumber = 0;
        }
        public MobilePhone(string mobilePhoneName, int mobilePhoneNumber) : base()
        {
            this.mobilePhoneName = mobilePhoneName;
            this.mobilePhoneNumber = mobilePhoneNumber;
        }
        public string MobilePhoneName
        {
            get { return mobilePhoneName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                mobilePhoneName = value;
            }
        }
        public int MobilePhoneNumber
        {
            get { return mobilePhoneNumber; }
            set
            {
                if (int.TryParse(value.ToString(), out int parsedNumber))
                {
                    throw new ArgumentException("Phone number must be whole number");
                }
                mobilePhoneNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Name of mobile phone: {mobilePhoneName}, Number of mobile phone: {mobilePhoneNumber}\n";
        }
        public override bool Equals(object? obj)
        {
            if (obj is MobilePhone)
            {
                return ToString().Equals(((MobilePhone)obj).ToString());
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string PhoneNumbers()
        {
            return ($"All numbers: {mobilePhoneNumber}");
        }
    }
}
