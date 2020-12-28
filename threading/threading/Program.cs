using System;
using System.Threading;
using System.Threading.Tasks;

namespace threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2.Go();
                Thread.CurrentThread.Name = "main";
                Thread worker = new Thread(Go);
                worker.Name = "worker";
                worker.Start();
                Go();
            

            static void Go()
            {
                Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
            }
        
       

            //var task = new Task(() => { Console.WriteLine("this is threding "); });
            //Console.WriteLine("THIS  IS THREADING  EXAMPLE");
            //var t1 = new Thread(Print);
            //var t2 = new Thread(Display);
            //t1.Start();
            //t2.Start();
            //t1.Join();





          
            //Console.WriteLine("my name is rama krishna vara prasad");
            //Display();

        }
    }
}
