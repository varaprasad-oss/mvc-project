using System;
using System.Collections.Generic;
using System.Text;

namespace taskdec4
{
    /* Review comment: Please use function to swap two numbers */
    public class Class1
    {
        public void swap()
        {
            Console.WriteLine("enter the frist number");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            var b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"frist number:{a}/n second number:{b}");
            
        }
        public void mul()
        {
            Console.WriteLine("multiplication table");
            Console.WriteLine("-------------------------");
            int j;
            int n = int.Parse(Console.ReadLine());
            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} X {1} = {2} ", n, j, n * j);
            }
        }

        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
