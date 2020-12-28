using System;
using System.Collections.Generic;
using System.Text;

namespace test12
{
    public class Overrid
    {
        public virtual int Cal(int a, int b)
        {
            return a + b;
        }
        public void Disp()
        {
            Console.WriteLine("This is the overiding example");
        }
      

    }
    
}
