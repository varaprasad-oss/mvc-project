using collections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ArrayList alist = new ArrayList();
            alist.Add(1);
            alist.Add("rama");
            alist.Add(2);
            alist.Add("krishna");
            foreach (object o in alist)
            {
                Console.WriteLine($"the arraylist elements is:{o}");
            }
            for (int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine($"displaying arraylist elememis:{alist[i]}");
            }
            #endregion
            var list = new List<string>
            {
                "raam",
                "vijaya",
                "krish",
                "rama rao" 
            };
            list.Add("maha lakshmi");
            foreach(object oo in list)
            {
                Console.WriteLine($"displaying the list elements :{oo}");
            }
            var listNumbers = new List<int>
            {
                1,3,4,5,6,234,465

            };
            listNumbers.Add(448);
            
           for(int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine($"displaying the list elements:{listNumbers[i]}");
            }
            var list2 = new List<string>();
            list2.AddRange(list);
            foreach(object ok in list2)
            {
                Console.WriteLine(ok);
            }
            
            List<Person> lll = new List<Person>();
            Person op = new Person();
            op.name = Console.ReadLine();
            op.age = Convert.ToInt32(Console.ReadLine());
            lll.Add(op);
            Console.WriteLine(op);
                   

 


        }
    }
}
