using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceexample
{
    class parent
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
    class child : parent
    {
        public void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
}
