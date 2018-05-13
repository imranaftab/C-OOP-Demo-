using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    class HourlySalaryEmployee : Employee
    {
        private int _hoursWorked;
        private double _perHourRate;

        public int HoursWorked
        {
            get
            {
                return _hoursWorked;
            }
            set
            {
                _hoursWorked = value;
            }
        }
        public double PerHourRate
        {
            get
            {
                return _perHourRate;
            }
            set
            {
                _perHourRate = value;
            }
        }
        public HourlySalaryEmployee(string name, int age, int hoursWorked, double perHourRate):base(name, age)
        {
            _hoursWorked = hoursWorked;
            _perHourRate = perHourRate;
        }

        public override double GetSalary()
        {
            return _hoursWorked * _perHourRate;
        }
    }
}
