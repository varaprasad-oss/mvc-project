using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    interface IExample
    {
        public int EmpId { get; set; }

        public void Display();
        public void add(int a, int b);
        
        public int Salary { get; set; }
    }
}
