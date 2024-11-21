using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3._1
{
    class Fish : Animal
    {
        public bool DyhaneePodVodoi { get; }
        public string Voice { get; set; }
        public Fish(string name, DateTime birth, double weight, bool dyhanee) : base(name, birth, weight)
        {
            DyhaneePodVodoi = dyhanee;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Nasekomoe do not make a sound.");
        }

        public override string ToString()
        {
            return base.ToString() + $", Ymeet dyshat pod vodoi: {DyhaneePodVodoi}";
        }
    }
}
