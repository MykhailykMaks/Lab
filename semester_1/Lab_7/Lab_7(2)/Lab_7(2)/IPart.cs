using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    interface IPart<Part>
    {
        string partName { get; set; }
        int partWeight { get; set; }
        int partCost { get; set; }
        string ToStringPart();
    }
}
