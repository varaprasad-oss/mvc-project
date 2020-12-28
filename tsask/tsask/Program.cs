using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks;
delegate int  calculate(int n);


namespace tsask
{
   public  class Program
    {
        
       
        static void Main(string[] args)
        {
            Partial partial = new Partial();
            Console.WriteLine("Pratial Class example  to implemnet the method ");
            partial.Add(10, 30);
            partial.Mul(40, 20);
            //Class1 class1 = new Class1();
            //int a = 30;
            //Console.WriteLine("before calling function"+a );

            //class1.show(ref a);
            //Console.WriteLine("after calling function"+a);

            //calculate calculate = new calculate(add);
            //var result =calculate(50);
            //Console.WriteLine(result);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}





            //string[] filepath = Directory.GetFiles(@"D:\RK");
            //    Parallel.For(0, filepath.Length, (index) =>
            //    {
            //        var currentFile = File.OpenRead(filepath[index]);
            //        Console.WriteLine(filepath[index] + "\t" + currentFile.Length);
            //    });
        }
        public static int num = 100;
        public  static int add(int n)
        {
            return n + num;
        }
    }
}
