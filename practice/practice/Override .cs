using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Overrides
    {
        public virtual int Print(int a, int b)
        {
            return a + b;
        }
        public void Display()
        {
            Console.WriteLine("Method overloading example");
        }

    }
}
