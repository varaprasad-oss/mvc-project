using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overriding example in method overriding the parameter must be same and method name is also same.
           

            ride r = new ride();
           var z= r.Calculate(5, 6);
            Console.WriteLine("the multiplication of two numberis:"+z);

            //method overloading example in method overloading we can method name must be same
            load ob = new load();

            int add1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two numbersis: " + add1);



            int add2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three numbers" + add2);




        }
    }
}
