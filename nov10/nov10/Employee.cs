using System;
using System.Collections.Generic;
using System.Text;

namespace nov10
{
      public partial class Employee
    {
        public void Display(Employee employee)
        {
            Console.WriteLine("enter the frist name");
            employee.fristName = Console.ReadLine();
            Console.WriteLine("enter you last name");
            employee.lastName = Console.ReadLine();
            Console.WriteLine("enter your salary");
            employee.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( fristName);
            Console.WriteLine(lastName);
            Console.WriteLine(salary);


        }

    }
}
