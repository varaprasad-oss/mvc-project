using System;
using System.Collections.Generic;
using System.Exception;


namespace collection
{
    class GenericClass<t>
    {
        public void display(t name)
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> integer = new GenericClass<int>(448);
            GenericClass<string> stringd = new GenericClass<string>("rama krishna vara prasad");
          
            Console.WriteLine("this is the collction example ");
            //var listname = new List<string>();
            //Console.WriteLine("enter no.of elements you want in the list");
            //int c = int.Parse(Console.ReadLine());
            //for(int i = 0; i < c; i++)
            //{
            //    listname.Add(Console.ReadLine());
            //}
            //foreach (var item in listname)
            //{
            //    Console.WriteLine(item);

            //}
            //var hs = new HashSet<string>();
            //Console.WriteLine("enter no.of hash elements ");
            //int a =int.Parse( Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    hs.Add(Console.ReadLine());

            //}
            //foreach (var item in hs)
            //{
            //    Console.WriteLine(item);

            ////}
            //var st = new Stack<string>();
            //Console.WriteLine("enter the no.of elements");
            //int h = int.Parse(Console.ReadLine());
            //for (int i = 0; i < h; i++)
            //{
            //   st.Push (Console.ReadLine());

            //}
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);

            //}
            //var queue = new Queue<string>() ;
            //Console.WriteLine("enter the number of elements ");
            //int c = int.Parse(Console.ReadLine());
            //for (int i = 0; i < c; i++)
            //{
            //    queue.Enqueue(Console.ReadLine());


            //}
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);

            //}
            //var dictonary = new Dictionary<string, string>();
            //dictonary.Add("1", "ramakrishna");
            //dictonary.Add("2", "vara prasad");
            //dictonary.Add("3", "vijay");


            //foreach (var item in dictonary)
            //{
            //    Console.WriteLine(item);

            //}
            //var di = new Dictionary<int, string>();
            //Console.WriteLine("ente the elements");
            //int v = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the );
            //for (int i = 0; i < v; i++)
            //{
            //    di.Add(int.Parse(Console.ReadLine()), Console.ReadLine());

            //}
            //foreach (var item in di)
            //{
            //    Console.WriteLine(item);

            //}
            //var r = new SortedList<int, string>();
            //Console.WriteLine("enter the elements ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    r.Add(int.Parse(Console.ReadLine()),Console.ReadLine());

            //}
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item);
                

            //}


           
               

        }
    }
}
