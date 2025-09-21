using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3_
{
    public class Print
    {
        private string? pib;
        private int priority;
        private DateTime requestTime;
        private DateTime endingTime;

        public Print() 
        {
            pib = "";
            priority = 0;
            requestTime = DateTime.Now;
            endingTime = DateTime.Now;
        }
        public Print(string? pib, int priority, DateTime requestTime, DateTime endingTime)
        {
            this.pib = pib;
            this.priority = priority;
            this.requestTime = requestTime;
            this.endingTime = endingTime;
        }
        public string? PIB
        {
            get { return pib; }
            set { pib = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public DateTime RequestTime
        {
            get { return requestTime; }
            set { requestTime = value; }
        }
        public DateTime EndingTime
        {
            get { return endingTime; }
            set { endingTime = value; }
        }
        public override string ToString()
        {
            return ($"User {PIB} with priority {Priority} requested on {RequestTime} and his requesrt completed on {EndingTime}");
        }
    }
}
