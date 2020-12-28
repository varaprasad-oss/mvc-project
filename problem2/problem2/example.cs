using System;
using System.Collections.Generic;
using System.Text;

namespace problem2
{
    class Example
    {
        public virtual int Calculate(int x, int y)
        {
            return x+y;
        }
    }
    class ride : Example
    {
        public override int Calculate(int x, int y)
        {
            return x * y;

        }
    }


}
