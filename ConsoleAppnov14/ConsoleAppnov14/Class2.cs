using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppnov14
{
    class Class2:Class1
    {
        public void execute()
        {
            //Class1 ok = new Class1();
            Class2 obj = new Class2();
            obj.add(5, 6);
            obj.mul(6, 6);
        }
    }
}
