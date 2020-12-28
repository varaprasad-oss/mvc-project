using System;
using System.Collections.Generic;
using System.Text;

namespace test12
{
    class AbsClass2 : AbstrctClass2
    {
        public override void Add(int a, int b)
        {
            Console.WriteLine($"the sum of steo numbers is="+(a+b));
        }
        

    }
}
