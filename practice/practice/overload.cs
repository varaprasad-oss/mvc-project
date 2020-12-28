using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class OverLoad
    {
        public  static  void Calculate(int a, int b)
        {
            Console.WriteLine((a+b));
        }
        public  static void Calculate(int a, int b,int c)
        {
            Console.WriteLine((a+b+c));
        }
    }
}
