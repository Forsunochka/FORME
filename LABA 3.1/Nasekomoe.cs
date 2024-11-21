using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3._1
{
    class Nasekomoe : Animal
    {
        public bool Lapki { get; }
        public string Voice { get; set; }
        public Nasekomoe(string name, DateTime birth, double weight, bool lapki) : base(name, birth, weight)
        {
            Lapki = lapki;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Nasekomoe do not make a sound.");
        }


        public override string ToString()
        {
            return base.ToString() + $", Imeetsya 6 lapok: {Lapki}";
        }
    }
}
