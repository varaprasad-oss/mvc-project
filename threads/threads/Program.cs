using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.dispaly();
            //Stopwatch s = new Stopwatch();
            //s.Start();
            Task t = Task.Run(()=>show("task"));
         
            for(int i = 0; i < 2000; i++)
            {
                Console.WriteLine(i);
            }
            t.Wait();
            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = 3;

            static    void show(string s)
            {
                Console.WriteLine( "{0}thread id is:{1}",s,Thread.CurrentThread.ManagedThreadId);
            }
            //s.Stop();
            //Console.WriteLine("thread timeis:"+s.ElapsedMilliseconds);

            
           
        }
        public void dispaly()
        {
            for (int i = 0; i < 202; i++)
            {
                Console.WriteLine("printing byusing method"+i);
            }
        }
        
			

    }
}
