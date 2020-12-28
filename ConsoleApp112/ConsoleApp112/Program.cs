using System;  
using System.Threading;
public class fatherInhretence
{
    public void big()
    {
        Console.WriteLine("father dna");
    }
}

public class son : fatherInhretence
{


    public void modarate()
    {
        Console.WriteLine("son1 dna ");
    }
}
public class Sonn :son
{


    public void son2()
    {
        Console.WriteLine("son2 dna");
    }
}
    //public void Thread1()  
    //{  
    //    for (int i = 0; i < 5; i++)  
    //    {  
    //        Console.WriteLine(i);  
    //        Thread.Sleep(200);  
    //    }  
    //}  

public class ThreadExample  
{  
    public static void Main()  
    {
        Sonn f = new Sonn();
        f.big();
        f.modarate();
        f.son2();


        //MyThread mt = new MyThread();  
        //Thread t1 = new Thread(new ThreadStart(mt.Thread1));  
        //Thread t2 = new Thread(new ThreadStart(mt.Thread1));  
        //Thread t3 = new Thread(new ThreadStart(mt.Thread1));
        //t1.Start();
        //t1.Join();  
        //t2.Start();  
        //t3.Start();
        
    }  
}  
