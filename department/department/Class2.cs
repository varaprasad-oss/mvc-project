using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace department
{
    class Class2
    {
        private string depname;
        private decimal salary;

        public void Getdepartment()
        {
                var depa = new List<department>();
                Console.WriteLine("Enter a number");
                var r = int.Parse(Console.ReadLine());
                
                for (int i = 1; i <= r; i++)
                {
                    
                    var dep = new department
                    {
                     Console.WriteLine("Enter the details );
                   
                     depname = Console.ReadLine(),
                      salary  = decimal.Parse(Console.ReadLine())
                    };
                   depa.Add(dep);
                }
                return employees;
            }

            public void ShowAllEmployees()
            {
            Console.WriteLine("Printing all employee details using foreach loop");
              
                foreach (var emp in Getdepartment())
                {
                    Console.WriteLine($"Emp id: {emp.EmpId}\tEmp name: {emp.EmpName}\tSalary: {emp.Salary}");
                }
               
                Console.WriteLine($"simple foreach loop took {timer.ElapsedMilliseconds} milliseconds");
                Console.WriteLine("Printing all employee details using for loop");
                for (int i = 0; i < Getdepartment().Count; i++)
                {
                    var emp = Getdepartment()[i];
                    Console.WriteLine($"Emp id: {emp.EmpId}\tEmp name: {emp.EmpName}\tSalary: {emp.Salary}");
                }

            Parallel.ForEach(Getdepartment(), (emp) => {
                    Console.WriteLine($"Emp id: {emp.EmpId}\tEmp name: {emp.EmpName}\tSalary: {emp.Salary}");
                });

            Parallel.For(0, Getdepartment().Count, (indexCount) =>
                {
                    var emp = employees[indexCount];
                    Console.WriteLine($"Emp id: {emp.EmpId}\tEmp name: {emp.EmpName}\tSalary: {emp.Salary}");
                });
            }
        }
    }



}

            }
                
            r
            }
    }
}
