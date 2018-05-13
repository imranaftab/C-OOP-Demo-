using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    class FixedSalaryEmployee : Employee
    {
        private double _fixedSalary;
        public double FixedSalary
        {
            get
            {
                return _fixedSalary;
            }
            set
            {
                _fixedSalary = value;
            }
        }
        public FixedSalaryEmployee(string name, int age, double salary) : base(name, age)
        {
            _fixedSalary = salary;
        }

        public override double GetSalary()
        {
            return _fixedSalary;
        }
    }
}
