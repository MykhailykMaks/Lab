using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2_
{
    class Items
    {
        public string name;
        public int size;

        public Items(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
        public Items()
        {
            name = "";
            size = 0;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public override string ToString()
        {
            return $"Name: {name}, Size: {size}";
        }

    }
}
