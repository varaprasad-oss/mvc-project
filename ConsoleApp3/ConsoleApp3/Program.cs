using System;

namespace ConsoleApp3
{
    class Program:Iex
    {
        private string name = string.Empty;
        public string nam 
        {
            get
            {
                return name;
            }
            set
            {
                name= value;
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Class1 obj = new Class1();
            //obj.excute();
            ////Program obje = new Program();
            //obje.subt(4, 5);
            //obje.sum(4, 6);
            //Console.WriteLine(obje.nam = Console.ReadLine());
            Abs oj = new Abs();
            oj.Ad(5, 5);
            oj.Add(3, 4);

            oj.display();
            //polymorphisum oe = new polymorphisum();
            //Console.WriteLine( oe.cal(3, 4));
            //Console.WriteLine( oe.cal(3, 4, 5));


        }

        public void subt(int a, int b)
        {
            Console.WriteLine((a+b));
        }

        public void sum(int a, int b)
        {
            Console.WriteLine((a-b));
        }
    }
}
