using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace nov101
{
    class Program
    {
        public static void count1()
        {
           Program obj = new Program();
            lock (obj)
            {
                Console.WriteLine("count1 begins.");
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("count1:" + i);

                }
                Console.WriteLine("coun1 exits.");
            }
        }
        public static void count2()
        {
            Console.WriteLine("count2 begins");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("count2:" + i);

            }
            Console.WriteLine(" count2 exits:");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main mthod begins");
            Thread t1 = new Thread(count1);
            Thread t2 = new Thread(count1);
          
            //var t = Task.Run(() => count1());
            //var t3 = Task.Run(() => count2());
            //Console.WriteLine(t);
            //Console.WriteLine(t3);
            t1.Start();
            t2.Start();
           // t1.Join();
            t2.Join();
            Console.WriteLine( " main method exits");
        }
     

    }
}
