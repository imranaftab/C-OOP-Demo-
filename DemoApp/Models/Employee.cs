using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    abstract class Employee
    {
        protected string _name;
        protected int _age;

        public Employee(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public int Age
        {
            get
            {

                return _age;
            }

            set
            {
                if (value > 0)
                    _age = value;
            }

        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {_name} \nAge: {_age} \nSalary:{GetSalary()}";
        }

        public abstract double GetSalary();

    }  
}

