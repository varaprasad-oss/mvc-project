using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {

                Class1 e = new Class1();
                Console.WriteLine("Enter emp number");
                e.No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter emp name");
                e.na = Console.ReadLine();
                Console.WriteLine("Enter emp salary");
                e.Sa = int.Parse(Console.ReadLine());
                Console.WriteLine(e.No);
                Console.WriteLine(e.na);
                Console.WriteLine(e.Sa);
            }

            catch (Exception e)
            {
                Console.WriteLine("something went wrong " + e.Message);
            }
           
        }
    }
}
