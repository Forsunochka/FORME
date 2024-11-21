using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA3
{
   enum ProgrammerLevel
    { JUNIOR, MIDDLE, SENIOR, LEAD}
    internal class Programmer : Employee
    {
        public ProgrammerLevel Level { get; set; }
        public Programmer (string name, DateTime birth, DateTime hire, ProgrammerLevel level) :base(name, birth, hire) 
        { Level = Level; }

        public double GetRaiseByLevel()
        { switch (Level)
                { case ProgrammerLevel.MIDDLE:return StartSalary * 2;
                case ProgrammerLevel.SENIOR:return StartSalary * 3.5;
                    case ProgrammerLevel.LEAD:return StartSalary * 4.5;
                }
                return 0;
                }
        public override double GetSalaryWithRaise()
        {
                 return base.GetSalaryWithRaise() + GetRaiseByLevel(); 
        }
        public override string ToString()
        {
            return base.ToString()+$",{Level}";
        }
    }
}
