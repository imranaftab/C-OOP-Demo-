using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            emps[0] = new FixedSalaryEmployee("Usman", 30, 4000);
            emps[1] = new HourlySalaryEmployee("Imran", 26, 10, 40);

            foreach (var emp in emps)
                Console.WriteLine(emp + "\n");

            Console.ReadKey();
        }
    }
}
