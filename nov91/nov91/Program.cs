using System;

namespace nov91
{
    class Program
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public string add(string a,string b)
        {
            return a + "and" + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public virtual  int ad(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Console.WriteLine( p.add(7, 9));
            Console.WriteLine(p.add("vara ", "prasad"));
            Console.WriteLine( p.add(5, 5, 5));
            Class1 j = new Class1();
            Console.WriteLine(j.add(6,7));



        }
    }
}
