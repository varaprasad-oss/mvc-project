using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace test12
{
    class Program : IExample
    {
        static void Main(string[] args)
        {
            //cancelation token 4
            FileClass3 fileClass3 = new FileClass3();
            fileClass3.Cancelation();
            //boxing and unboxing
            //int a = 4;
            //object o = a;//boxing
            //int y = (int)o;//unboxing 
            //Console.WriteLine(a);
            //Console.WriteLine(o);
            //Console.WriteLine(y);


            // colloction class 11
            //CollectionClass3 collectionClass3 = new CollectionClass3();
            //collectionClass3.Print();

            //    ////////file program 5
            //FilCreationClass3 f = new FilCreationClass3();
            //f.File1();
            ////extension
            //ExtensionClass1 extensionClass1 = new ExtensionClass1();
            //var res = extensionClass1.Method(10, 80);
            //Console.WriteLine(res);

            //abstract class 21
            //AbsClass2 absClass2 = new AbsClass2();
            //absClass2.Add(10, 20);
            //absClass2.Display();//declaring non abstract method in abstract class 

            ////dictionary and sorted list 
            /////interface
            ///cancelation token

            //Program program = new Program();
            //program.DictionaryExample();
            //program.SortedListExample();
            //program.Add(10,20);
            //program.Mul(10, 20);


            ///overloading
            ///
            //OverloadinEx overloadinEx = new OverloadinEx();
            //var result1=overloadinEx.Calculate(10, 20);
            //Console.WriteLine(result1);
            //var result2 = overloadinEx.Calculate(10, 20, 30);
            //Console.WriteLine(result2);

            ////Array printing
            //ArrayEx arrayEx = new ArrayEx();
            //arrayEx.Print();
            //override
            // OverR1 overR1 = new OverR1();
            //var res= overR1.Cal(10, 20);
            // Console.WriteLine(res);
            // overR1.Disp();


        }

        public void Add(int a, int b)
        {
            Console.WriteLine("this is additoon"+(a+b));
        }

        public void DictionaryExample()
        {
            var d = new Dictionary<int, string>();
            d.Add(1, "Rama");
            d.Add(2, "Krishna");
            d.Add(3, "Tollplus");
            Console.WriteLine("The Dictionary elements are ");
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine("this is multiplication"+(a*b));
        }

        public void SortedListExample()
        {
            var s = new SortedList<int, string>();
            s.Add(2, "Apple");
            s.Add(3, "Development");
            s.Add(1, "TollPLus");
            Console.WriteLine("The Sorted list elements are");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
        
           
         
    }
}



