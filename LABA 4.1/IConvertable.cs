using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_4._1
{
    interface IConvertable
    {
        double Course { get; set; }
        void ConvertToUSD();
    }
}
