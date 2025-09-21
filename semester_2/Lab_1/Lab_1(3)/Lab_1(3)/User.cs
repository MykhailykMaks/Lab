using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3_
{
    public class User
    {
        private string? pib;
        private int priority;
        private DateTime time;

        public User()
        {
            pib = "";
            priority = 0;
            time = DateTime.Now;
        }
        public User(string? pib, int priority, DateTime time)
        {
            this.pib = pib;
            this.priority = priority;
            this.time = DateTime.Now;
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
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        public override string ToString()
        {
            return ($"User: {PIB} have {priority} priority.");
        }
    }
}
