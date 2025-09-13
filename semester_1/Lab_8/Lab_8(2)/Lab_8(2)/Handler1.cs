using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2_
{
    class Handler1
    {
        public void ItemsAddHandler(ref Items[] items, Items item)
        {
             Array.Resize(ref items, items.Length + 1);
             items[items.Length - 1] = item;
        }
    }
}
