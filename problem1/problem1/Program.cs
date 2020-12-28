using System;
using System.IO;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the filename");
            var fileName = Console.ReadLine();
            Console.WriteLine("Enter content");
            var content = Console.ReadLine();
            var p = Path.Combine(Environment.CurrentDirectory, fileName);
            File.WriteAllText(p, content);
            Console.WriteLine("file is created sucessfully");
            var result = File.ReadAllText(p);
            Console.WriteLine(result);


        }
    }
}
