using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Encap
    {
        private string name;
        public string Name { 
            get 
            {
                return name;
            }
            set 
            {
                name = "ram";
            }
        }
        public void Display()
        {
            Console.WriteLine("This is encapsulation example ");

        }
        protected void Add(int a,int b)
        {
            Console.WriteLine("Adding twonumbers:");
            Console.WriteLine(a+b);
        }
        private void Mul(int a, int b)
        {

            Console.WriteLine((a*b));
        }
    }
}
