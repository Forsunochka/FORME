using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba 4
{
     class Koupon
    {
        public int[] AvailableDenominations { get; set; }
        public int Denomination { get; set; }
        public DateTime IssueDate { get; set; }

        public override string ToString()
        {
            return $"Denomination: {Denomination}, Issue Date: {IssueDate}";
        }

    }
}
