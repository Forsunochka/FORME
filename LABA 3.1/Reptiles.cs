using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3._1
{
    class Reptiles : Animal
    {
        public bool Chesya { get; }


        public Reptiles(string name, DateTime birth, double weight, bool chesya) : base(name, birth, weight)
        {
            Chesya = chesya;

        }

        public override void MakeSound()
        {
            Console.WriteLine("Reptiles make a sound: SSSSSSSSSSSSSSSSSSSSS!");
        }

        public override string ToString()
        {
            return base.ToString() + $", Chesya: {Chesya}";

        }
    }
}
