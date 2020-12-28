using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class1 : Encapsulation
    {
        public void excute()
        {
            Class1 obj = new Class1();
            obj.Name = "rama krishna ";
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.add(3, 4));
            Console.WriteLine(obj.mul(8, 4));
        }
    }
}
