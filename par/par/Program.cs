using System;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Partial obj = new Partial();
            Console.WriteLine( obj.add(34, 45));
            obj.sub(20, 10);
        }
    }
}
