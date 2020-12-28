using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace parallelfor_loop
{
        class lists
        {
        public void listing()
        {
            List<Class1> classes = new List<Class1>();
            Console.WriteLine("enter how many employees");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < n; i++)
            {
                Class1 person = new Class1();

                Console.WriteLine($"enter {i} person details");
                Console.Write("enter the id");
                person.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter the name");
                person.name = Console.ReadLine();
                classes.Add(person);

            }
            Parallel.For(0, n, i =>
            {
                //classes.Id
                Console.WriteLine("{0} employee details", i + 1);
                Console.WriteLine("{0}\n{1}\n{2}" + classes[n]);
            });
        }


        }

    
    

}
