using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Class1
    {
        private int empNo;
        private int empSalary;
        private string empName;
        private string depName;
        public int No
        {
            get
            {
                return empNo;

            }
            set
            {
                empNo = value;
                if (empNo > 1001)
                {
                    throw new Exception("empolyee number shuold be less then the1000 only");
                }
            }
        }
        public int Sa
        {
            get
            {
                return empSalary;
            }
            set
            {
                empSalary = value;
                if( empSalary < 0)
                {
                    throw new Exception("empolyee salary should not be negative");
                }
            }
        }
        public string na
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
                if (empName.Length < 3 || empName == null)
                {
                    throw new Exception("name should be more then three charcteristics");

                }
                
            }
        }

    }
}
