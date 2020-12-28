using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public  class Abs: abstraction
    {
        public override void Ad(int a, int b)
        {
            Console.WriteLine("output:"+(a+b));
        }
        public void Add(int a, int b)
        {
            Console.WriteLine("this is class method");
        }
       

    }
}
