using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2_
{
    class Handler2
    {
        public void ItemDeleteHandler(ref Items[] items, Items item)
        {
            Items[] temp = new Items[items.Length - 1];
            int index = Array.IndexOf(items, item);
            for (int i = 0; i < items.Length; i++)
            {
                if (i != index)
                {
                    temp[i] = items[i];
                }
            }
            items = temp;
        }
    }
}
