
using System;

namespace passby_value_an_dpaas_by_ref
{
    class Program
    {
       public void calculate ( int v)
        {
            v = v * v;
            Console.WriteLine(v);
        }
        public void refer(ref int va)
        {
            va*= va;
            Console.WriteLine(va);
        }
        static void Main(string[] args)
        {
            int s = 30;
            int j = 50;
            Console.WriteLine("Hello World!");
            var obj = new Program();
            obj.calculate(45);
            obj.refer(ref s);
            Console.WriteLine(j);
            Console.WriteLine(s);
        }
    }
}
