using System;
using System.Collections.Generic;
using System.Text;

namespace taskdec
{
    class Class2
    {
        public void avarage()
        {
            Console.WriteLine("enter fournumbers");
            double a, b, c, d;
            Console.WriteLine("enter the  1 st number ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the 3rd number");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the 4th number");
            d =Convert.ToDouble(Console.ReadLine());
            double result = (a + b + c + d) / 4;
            Console.WriteLine($"the average of {a}and {b}and {c}and {d}is ={result}");

        }
    }
}
