using System;
using System.Collections.Generic;
using System.Text;

namespace task_4dec
{
    class Class1
    {
        public void display()
        {
            Console.WriteLine("enter the name");
            string j = Console.ReadLine();
            char c = j[0];
            string j1=j.Replace(j[0], j[j.Length - 1]);
            string cd = j1.Remove(j.Length - 1);
            string c1 = cd+c;
            
            Console.WriteLine(c1);
         
        }

    }
}
