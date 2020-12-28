using System;
using System.Collections.Generic;
using System.Text;

namespace nov17
{
    
        class lists
        {
            public void listing()
            {
                List<Class1> classes = new List<Class1>();
                Console.WriteLine("enter number of empolyees");
                var j = int.Parse(Console.ReadLine());


                for (int i = 1; i < j; i++)
                {
                    Class1 person = new Class1();

                    Console.WriteLine($"enter {i} person details");
                    Console.Write("enter the id");
                    person.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter the name");
                    person.name = Console.ReadLine();
                    classes.Add(person);

                }
                parallel.for (0, classes.Count, (i) =>
                {
                var res = classes[i];
                Console.WriteLine({ res.Id},""{ res.name}) ;
            });
               
            
        }

    }
}

    }
}
