using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppnov14
{
    class Class1
    {
        

        public void add(int a, int b)
        {
            Console.WriteLine("The addition of {0}and{1}is{2}",a,b,a+b);

        }
        private void sub(int a, int b)
        {
            Console.WriteLine("The subtraction of two numbers:" +(a - b));
        }
        protected void mul(int a, int b)
        {
            Console.WriteLine("the multiplivcation of {0} and {1} is {2}  ",a,b,a*b);
        }
            
    }
}
