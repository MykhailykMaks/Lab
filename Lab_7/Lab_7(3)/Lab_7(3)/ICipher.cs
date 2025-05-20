using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_3_
{
    interface ICipher
    {
        public string encode(string text);
        public string decode(string text);
    }
}
