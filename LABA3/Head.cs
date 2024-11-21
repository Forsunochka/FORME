using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA3
{
    internal class Head : Employee
    {
        public override int StartSalary { get; } = 4500;
        public Head(string name, DateTime birth, DateTime hire):base(name, birth, hire) { }

        public override double GetRaiseByExperiense()
        {
            if (GetEmployeeExperiense() >= 1 && GetEmployeeExperiense() < 3)
            { return StartSalary * 0.20; }
            else if (GetEmployeeExperiense() >= 3 && GetEmployeeExperiense() < 5)
            { return StartSalary * 0.25; }
            else if (GetEmployeeExperiense() >= 5)
            { return StartSalary * 0.30; }
            return 0;
        }
    }
}
