using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3._1
{
    class Mlecopitayshee : Animal
    {
        public string Voice { get; set; }

        public Mlecopitayshee(string name, DateTime birth, double weight, string voice) : base(name, birth, weight)
        {
            Voice = voice;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Mlecopitayshee makes the sound: {Voice}");
        }


        public override string ToString()
        {
            return base.ToString() + $", Voice: {Voice}";
        }
    }
}
