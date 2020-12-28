using System;

namespace taskdec4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("swaping example programme !");
            Class1 swaping = new Class1();
            var r=swaping.add(45,89);
            Console.WriteLine("the adding output is"+r);
            swaping.swap();
            swaping.mul();
            //multiplicationprogram mu = new multiplicationprogram();
            //mu.mul();
        }
    }
}
