using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace test12
{
    class CollectionClass3 : Employee {



        public void Print()
        {
            List<Employee> li = new List<Employee>();
            Console.WriteLine("enter no.of employees ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();
                Console.WriteLine($"enter the employee id {i}");
                employee.EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter the employee name{i} ");
                employee.EmpName = Console.ReadLine();
                Console.WriteLine($"enter the employee salary{i} ");
                employee.Salary = Convert.ToDecimal(Console.ReadLine());
                li.Add(employee);

            }
            foreach (var item in li)
            {
                Console.WriteLine("employee id is"+item.EmpId+" employee name"+item.EmpName+"employee salary"+item.Salary);

            }
            

           

            }
            





        }

}

