using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceexample
{
    class Class2 : Iex
    {
        private string name1 ="ramakrishna";

        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void add(int a, int b)
        {
            throw new NotImplementedException();
        }

        //public string name { get { return name1; } set { name1 = value; } }

        //public void add(int a, int b)
        //{
        //    Console.WriteLine((a+b));
        //}
    }
}
