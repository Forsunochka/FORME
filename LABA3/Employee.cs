using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA3
{
   abstract class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfHiring { get; set; }
        public virtual int StartSalary { get; } = 500;

        public Employee(string name, DateTime birth, DateTime hire)
        {
            Name = name;
            DateOfBirth = birth;
            DateOfHiring = hire;
        }
        public int GetEmployeeAge()
        { return DateTime.Now.Year - DateOfBirth.Year; }
        public int GetEmployeeExperiense()
        { return DateTime.Now.Year - DateOfHiring.Year; }
        public virtual double GetRaiseByExperiense()
        { if (GetEmployeeExperiense() >= 1 && GetEmployeeExperiense() < 3)
            { return StartSalary * 0.15; }
            else if (GetEmployeeExperiense() >= 3 && GetEmployeeExperiense() < 5)
            { return StartSalary * 0.20; }
            else if (GetEmployeeExperiense() >= 5)
            { return StartSalary * 0.25; }
            return 0;
        }
        public virtual double GetSalaryWithRaise()
        { return StartSalary + GetRaiseByExperiense(); }
        public override string ToString()
        {
            return $"{GetType().Name}:Name={Name}, Age={GetEmployeeAge()}, Experiense={GetEmployeeExperiense()}, StartSalary={GetSalaryWithRaise()}";
        }
    }
}
