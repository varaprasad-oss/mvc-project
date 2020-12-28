
using System;
using System.Threading;

namespace threadspractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;


            object lockerObject = new object();

            // it makes sure that multiple thread can't access the lock block simultaneously 
            lock (lockerObject)
            {
                i++;
                Console.Write("Do something " + i);

            }

        }
    }
}
        //private static void print(object obj)
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Console.WriteLine(i);
                

        //    }
        //}
        //public static void Display()
        ////{
        ////    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine("print with out object ");
        //        Console.WriteLine(i);

        //    }

       
    //class ThreadSafe
    //{
    //    static readonly object _locker = new object();
    //    static int _val1, _val2;

    //    static void Go()
    //    {
    //        lock (_locker)
    //        {
    //            if (_val2 != 0) Console.WriteLine(_val1 / _val2);
    //            _val2 = 0;
    //        }
    //    }
    //}

