using System;
using System.Collections.Generic;
using System.Text;

namespace test12
{
    class OverloadinEx
    {
        public int Calculate(int a, int b,int c)
        {
            return a + b + c;

        }
        public int Calculate(int a,int b)
        {
            return a+b;
        }

        
    }
}
