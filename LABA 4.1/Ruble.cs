using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_4._1
{
    class Ruble : Koupon, IConvertable
    {
        public string SerialNumber { get; set; }
        public double Course { get; set; }

        public void ConvertToUSD()
        {
            Denomination = (int)(Denomination / Course);
        }
    }
}
