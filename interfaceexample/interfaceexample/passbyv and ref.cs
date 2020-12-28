using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceexample
{
    class passbyv_and_ref
    {
       public  void dis(int v)
        {
            v *= v;
            Console.WriteLine(v);
        }
        public static void rref(ref int r)
        {
            r *= r;
            Console.WriteLine(r);
        }
    }
}
