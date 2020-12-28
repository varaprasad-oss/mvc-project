using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace list_collction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Class1> listName = new List<Class1>();
            Console.WriteLine("enter the no.of employees");
            var n = int.Parse(Console.ReadLine());
            for (int i =1; i < n; i++)
            {
                Class1 person = new Class1();
                Console.WriteLine($"enter {i}th person details");
                Console.WriteLine("enter the employee name");
                person.EmployeeaName = Console.ReadLine();
                Console.WriteLine("enter the employee salary");
                person.Salary = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the date of joining ");
                person.dateofjoining = Convert.ToDateTime(Console.ReadLine());
                listName.Add(person);


            }
            Parallel.For(0, listName.Count, i =>
            {
                var person = listName[i];
                Console.WriteLine("en:"+person.EmployeeaName+"es"+person.Salary+"dj:"+person.dateofjoining);
            });
            

            }
            
         }
    }

