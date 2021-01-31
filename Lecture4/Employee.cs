using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public Employee(string Name, string Surname)
        {
            name = Name;
            surname = Surname;
        }
        public Employee()
        {

        }
        public int[] postSalary = { 1500, 2500, 3500, 5000 };
        public string[] post = { "intern", "junior", "middle", "senior" };
        public int[] service = { 200, 400, 600, 800 };
        public int salary(int cP, int cE)
        {
            return postSalary[cP - 1] + service[cE - 1];
        }
        public double tax(int salary)
        {
            return 0.14 * salary;
        }
    }
}
