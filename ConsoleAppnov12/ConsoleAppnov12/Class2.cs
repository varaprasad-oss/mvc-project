using System;
using System.Collections.Generic;
using System.Text;

namespace extensionExample
{
     public static class Class2
    {
        public static void Mul(this Class1 extension1, int b,int a)
        {
            Console.WriteLine(a*b);

        }
    }
}
