using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Encapsulation
    {
        private string name;
        public string   Name { 
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            } 
        }
        public int add(int a, int b)
        {
            return a + b;
            

        }
        private int sub(int  a, int b)
        {
            return a - b;
        }
        protected int mul(int a, int b)
        {
            return a * b;
        }
    }
}
