using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_
{
    public interface IContainer<TElement>
    {
        int Count { get; }
        TElement this[int index] { get; set; }
        void Add(TElement element);
        void Delete(TElement element);
    }
}
