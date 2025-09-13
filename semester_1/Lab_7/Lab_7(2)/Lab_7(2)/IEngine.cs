using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_
{
    interface IEngine<Engine>
    {
        string engineName { get; set; }
        string engineType { get; set; }
        int enginePower { get; set; }
        string ToStringEngine();
    }
}
