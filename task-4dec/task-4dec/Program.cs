using System;

namespace task_4dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist  number");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            var b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after swaping of two numbers:{a}{b}");

            //Console.WriteLine("enter the name");
            //string s = Console.ReadLine();
            //Console.WriteLine("ente the index value");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (i == n)
            //    {
            //        continue;
            //    }
            //    Console.Write(s[i]);
            //}
            //Class1 obj = new Class1();
            ////obj.display();
            //Class3 obj = new Class3();
            //obj.disp();
            //Class4 sw = new Class4();
            //sw.swap();

        }
    }
}
