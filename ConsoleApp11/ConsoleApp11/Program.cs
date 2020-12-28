using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var listName = new List<String>();
            
            listName.Add("rama krishna vara prasad");
            listName.Add("rama rao");
            listName.Add("maha lakshmi");
            listName.Add("antha chandra sehker");
            foreach (var i in listName)
            {
                Console.WriteLine($"displaying the list elements:{i}");

            }
            for(int i = 0; i < listName.Count; i++)
            {
                Console.WriteLine($"{listName[i]}");
            }
            var numbers = new List<int>();
            numbers.Add(448);
            numbers.Add(438);
            numbers.Add(443);
            foreach (var k in numbers)
            {
                Console.WriteLine($"displaying list numbers :");
                Console.WriteLine(k);

            }
            var hashExample = new HashSet<string>() { "rk", "ramarao", "antha", "chandra sehker" };
            Console.WriteLine("enter the hashset varibles");
            foreach (var h in hashExample)
            {
                
                Console.WriteLine(/*$"the hashset strings are given below:"*/ h);

            }


            //Class1 c = new Class1();
            //c.file();
            
            
            //var t = Task.Run(() => show("never give up"));
            //t.Wait();
            //for(var i = 1; i < 200; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

        }

        //private static void show(string s)
        //{
        //    Console.WriteLine("{0}thred idis:{1}",s,Thread.CurrentThread.ManagedThreadId); ;
        //}
    }
}
