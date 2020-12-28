using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Employee e = new Employee();
                Console.WriteLine("Enter emp number");
                e.EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter emp name");
                e.EmpName = (Console.ReadLine());
                Console.WriteLine("Enter emp salary");
                e.Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Department name");
                e.DeptName = (Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Dabang"+e);
            }

        }
    }
    public class Employee
    {
        private int empNo;
        private string empName;
        private int salary;
        private string deptName;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
            set
            {
                empNo = value;
                if (empNo < 1001)
                {
                    throw new Exception("Employee number should be more than 1001");
                }
            }
        }

        public string EmpName
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
                    throw new Exception("Employee name should be more than 3 characters");
                }
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
                if (salary < 0)
                {
                    throw new Exception("salary should be positive");
                }
            }
        }

        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
                if (deptName != "Devolopment")
                {
                    throw new Exception("Department must be devolopment");
                }
            }
        }
    }
}
