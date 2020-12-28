using System;
using System.Collections.Generic;
using System.Text;

namespace extensionExample
{
    class Class3
    {
        public int  PassByValue(int a, int b)
        {
            a = 10;
            return a + b;
        }
        public int Pa( int a,  int b,out int c)
        {
            c = a + b + 10;
            return a + b;


        }
    }
}
