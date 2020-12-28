using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp2
{
    public class Program:IExample

    {
        public string FirstName { get => Console.WriteLine(); set => throw new NotImplementedException(); }

        public static  void Main()
        {
            Program ob = new Program();
            ob.add();
         
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        private void add()
        {
            int a = 23;
            int b = 30;
            Console.WriteLine((a + b));
        }
    }
    public interface IExample
    {
        void Add(); // method
        string FirstName { get; set; } // property
    }
}