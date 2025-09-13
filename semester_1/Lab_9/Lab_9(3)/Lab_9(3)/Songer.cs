using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_3_
{
    internal class Songer
    {
        public string pibSonger;
        public int ageSonger;
        public Songer()
        {
            pibSonger = "";
            ageSonger = 0;
        }
        public Songer(string nameSonger, int ageSonger)
        {
            this.pibSonger = nameSonger;
            this.ageSonger = ageSonger;
        }
        public string NameSonger
        {
            get { return pibSonger; }
            set { pibSonger = value; }
        }
        public int AgeSonger
        {
            get { return ageSonger; }
            set { ageSonger = value; }
        }
        public override string ToString()
        {
            return ($"Songers PIB: {pibSonger}, Songers age: {ageSonger}");
        }

    }
}
