using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1111
{
    public class Employee
    {
        
        public void add()
        {
            List<Class1> classes = new List<Class1>();
            Console.WriteLine("enter the number of employees ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {


                Class1 op = new Class1();
                Console.WriteLine("enter the emp name");
                op.empName = Console.ReadLine();
                Console.WriteLine("ENTER THE SALARY");
                op.salary = Convert.ToInt32(Console.ReadLine());
                classes.Add(op);
            }
         
            foreach (var ok in classes)
            {
                Console.WriteLine($"empolyee name:{ok.empName}  {ok.salary}");

            }





        }
                //Console.WriteLine("enter the 2nd empolyee details");
                //Class1 emp2 = new Class1()
                //{
                //    depname = Console.ReadLine(),
                //    empId = int.Parse(Console.ReadLine()),
                //    salary = int.Parse(Console.ReadLine()),
                //    empName = Console.ReadLine()

                //};

                //Console.WriteLine("enter the 3rd empolyee details");
                //Class1 emp3 = new Class1()
                //{
                //    depname = Console.ReadLine(),
                //    empId = int.Parse(Console.ReadLine()),
                //    salary = int.Parse(Console.ReadLine()),
                //    empName = Console.ReadLine()

                //};

                //Console.WriteLine("enter the  4th empolyee details");
                //Class1 emp4 = new Class1
                //{
                //    depname = Console.ReadLine(),
                //    empId = int.Parse(Console.ReadLine()),
                //    salary = int.Parse(Console.ReadLine()),
                //    empName = Console.ReadLine()

                //};
                
                //emp.Add(emp2);
                //emp.Add(emp3);
                //emp.Add(emp4);
            
        
        

    }
}
