using System;
using System.Collections.Generic;
using System.Text;

namespace problem3
{
    class Class5 : parent, Class3
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
}
