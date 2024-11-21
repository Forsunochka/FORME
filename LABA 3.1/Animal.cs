using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3._1
{
    abstract class Animal
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        public double Weight { get; set; }
        public Animal(string name, DateTime birth, double weight)
        {
            Name = name;
            DateOfBirth = birth;
            Weight = weight;

        }


        public abstract void MakeSound();


        public override string ToString()
        {
            return $"{GetType().Name}: Name: {Name}, Age: {Age}, Weight: {Weight}kg ";
        }

    }
}
