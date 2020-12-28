using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallelfor_loop
{
    class list
    {
        public void listing()
        {
            List<Class1> classes = new List<Class1>();
            Console.WriteLine("enter the number of empolyees");
            var r = int.Parse(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                Class1 person = new Class1();

                Console.WriteLine($"enter {i} person details");
                Console.Write("enter the id");
                person.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter the name");
                person.name = Console.ReadLine();
                classes.Add(person);

            }
            //ParallelOptions obj = new ParallelOptions();
            //obj.MaxDegreeOfParallelism = 3;
            Parallel.For(0, r, i =>
            {
                Console.WriteLine("{0} employee details",i+1);
                Console.WriteLine("{0}", classes[i]);
            });

        }
    }
}
