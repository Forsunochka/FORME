using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3._1
{
    class Bird : Animal, IFly
    {
        public bool Krylia { get; }
        public string Voice { get; set; }
        public Bird(string name, DateTime birth, double weight, bool krylia, string voice) : base(name, birth, weight)
        {
            Krylia = krylia;
            Voice = voice;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Bird makes the sound: {Voice}");
        }

        public void Fly()
        {
            Console.WriteLine("Bird flying good.");
        }

        public override string ToString()
        {
            return base.ToString() + $", Imeet krylia: {Krylia},Voice: {Voice}";
        }
    }
}
