using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Over:Overrides
    {
        public override int Print(int a, int b)
        {
            Console.WriteLine("before method overriding");
            Console.WriteLine( base.Print(a, b));
            Console.WriteLine("after method overriding");
            return a * b;

        }
    }
}
