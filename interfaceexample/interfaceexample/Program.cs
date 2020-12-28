
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
delegate int dispaly(int a);
delegate string presenting(string b);
namespace interfaceexample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var listname = new List<string>() { "ram", "sam", "tom", "raj", "tej", "jesus" };
            //Console.WriteLine("printing list  elements using the foreach loop");
            //foreach (var item in listname)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("printing list elements using for loop");
            //for(int i = 0; i < listname.Count; i++)
            //{
            //    Console.WriteLine(listname[i]);
            //}
            var name = new List<int>();
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the list elements ");
            for(int i = 0; i < n; i++)
            {
                name.Add(int.Parse(Console.ReadLine()));
            }
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("Hello World!");
            //Class2 obj = new Class2();
            //obj.add(4, 5);

            //Console.WriteLine(obj.name)
            //int a = 40;
            //int b = 10;
            //passbyv_and_ref obj = new passbyv_and_ref();
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //obj.dis(a);
            //passbyv_and_ref.rref(ref b);
            //Console.WriteLine(a);
            //Console.WriteLine("after:+" + b);
            //int[] x= new int[5] { 1, 2, 3, 4, 5 };
            //foreach (var i in x)
            //{
            //    Console.WriteLine(i);
            //}
            //void ad(int a, int b=4) { 

            //    int c = a - b;
            //    Console.WriteLine(c);
            //    Console.WriteLine("vvxv"+b);
            //}
            //ad(2);
            //ad(4, 5);\
            //goto Mylabel;
            //Console.WriteLine("enter a number ");
            //Mylabel:
            //int id =int.Parse( Console.ReadLine());
            //switch (id)
            //{
            //    case 1: Console.WriteLine("this is number one ");goto default; break;
            //    case 2: Console.WriteLine("number two"); break;
            //    case 3: Console.WriteLine("number three ");break ;
            //    default: Console.WriteLine("none"); break;

            //}
            // int  add(int a)
            //{
            //    Console.WriteLine("this is the delegate example ");
            //    return a * a;
            //}
            //string present(string n)
            //{
            //    Console.WriteLine("this is the delegate stirng example");
            //    return n;


            //}
            //presenting obj = new presenting(present);
            //Console.WriteLine(  obj("rama krishna vara prasad"));

            ////dispaly obj = new dispaly(add);
            ////Console.WriteLine(  obj(20)); 
            ///enum

            //int x = (int)EDay.saturday;
            //Console.WriteLine(x);
            //    foreach (string t in Enum.GetNames(typeof(EDay)));
            //    {
            //        Console.WriteLine(value:t);

            ////    }
            //child ob = new child();
            //ob.add(10, 20);
            //ob.sub(10, 30);
            
        } 
        //        ShowThreadInfo("Application");
        //        var t = Task.Run(() => ShowThreadInfo("Task"));
        //        // t.Wait();
        //        for (var i = 0; i < 200; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //        t.Wait();
        //        Console.Read();
        //    }

        //private static void ShowThreadInfo(string v)
        //{
        //    Console.WriteLine(v, Thread.CurrentThread.ManagedThreadId) ;
        //}
    }
    
}

