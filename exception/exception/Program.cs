using System;
using System.IO;

namespace exception
{
    class Program
    {
       

      
        static void Main(string[] args)
        {
            Console.WriteLine("enter the file name in  csharp");
            var filename = Console.ReadLine();
            Console.WriteLine("enter the content of the file");
            var cont = Console.ReadLine();
            var pa = Path.Combine(Environment.CurrentDirectory, filename);
            using FileStream fs = File.Create(pa);
            using var sr = new StreamWriter(fs);
           sr.Write(cont);
            
            

            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("enter:" + d);
            }
            catch (ArithmeticException f)
            {
                Console.WriteLine(f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //finally
            //{
            //    Console.WriteLine("ENTER THE FILENAME");
            //    var fn = Console.ReadLine();
            //    Console.WriteLine("ENTER THE CONTENT");
            //    var cn = Console.ReadLine();
            //    var p = Path.Combine(Environment.CurrentDirectory, fn);
            //    File.WriteAllText(p, cn);
               // Console.WriteLine("file is created and must be save with the .ts extension");
               // var result = File.ReadAllText(p);
               // Console.WriteLine(result);


            
               //}
           

                
            
        }
       
    }
}
