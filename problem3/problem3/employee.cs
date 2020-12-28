using System;
using System.Collections.Generic;
using System.Text;

namespace problem3
{
    class Employee
    {
        public int salary { get; set; }
        public string empName { get; set; }
        public int empId { get; set; }
        public int join { get; set; }

        

        public  void salary( )
        {
            var t = int.Parse(Console.ReadLine());
            Console.WriteLine(t);
        }

        internal string empName(Employee e)
        {
            return e;
        }
    }
}
