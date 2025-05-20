using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_
{
    public interface IFileContainer<TElement> : IContainer<TElement>
    {
        void Save(string fileName);
        void Load(string fileName);
        Boolean IsDataSaved { get; }
    }
}
