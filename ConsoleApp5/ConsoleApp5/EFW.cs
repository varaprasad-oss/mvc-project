using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public class EFW
    {
       public void ListEmployee1Table()
       {
            using(DbContextClass1 context = new DbContextClass1()) 
            {
                var employees = context.Employees1.Where(d =>d.EmpId.Equals(448));

                foreach (var item in employees)
                {
                    Console.WriteLine($"Employee Id:{item.EmpId}  Employee location :{item.Location} employee phone numbe:{item.Phonenumberr}"  );

                }
            }
       }
        public void ListEmployee2Table()
        {
            using (DbContextClass1 context=new DbContextClass1())
            {
                var emp2 = context.Eemployee2;
                foreach (var emp in emp2)
                {
                    Console.WriteLine($" Employee2 table id:{emp.EmpId}   employee2 slary: {emp.EmpSalary} Employee Department:{emp.department}");

                }

            }
        }
        public void AddEmployee2(string departmentName)
        {
            using (DbContextClass1 context=new DbContextClass1())
            {
                Employe2 emp2 = new Employe2()
                {
                    department = departmentName
                };
                context.Eemployee2.Add(emp2);
                context.SaveChanges();

            }
        }
        public void UpdatEMployee2(int empid, string department)
        {
            using (DbContextClass1 context=new DbContextClass1())
            {
                var emp2=context.Eemployee2.Where(d=>d.EmpId==empid).FirstOrDefault();
                if (emp2 != null)
                {
                    emp2.department = department;
                    context.Entry(emp2).State= Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();

                }
            }
        }
        public void DeleteEmployee2(int empid)
        {
            using (DbContextClass1 context=new DbContextClass1())
            {
                var emp2 = context.Eemployee2.Where(d => d.EmpId == empid).FirstOrDefault();
                if (emp2!=null)
                {
                    context.Eemployee2.Remove(emp2);
                    context.SaveChanges();

                }

            }
        }
        public void ListWithJoins()
        {
            using (DbContextClass1 context = new DbContextClass1())
            {
                var data = from Employe1 in context.Employees1
                           join Employe2 in context.Eemployee2
                           on Employe1.EmpId equals Employe2.EmpId
                           select new
                           {
                               EmpName = Employe1.EmpName,
                               Location = Employe1.Location,
                               department = Employe2.department

                           };

                foreach (var item in data)
                {
                    Console.WriteLine($"{item.EmpName} {item.Location}{item.department}");

                }

            }

        }

    }
}
