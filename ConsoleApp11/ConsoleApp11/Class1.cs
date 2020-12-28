using System;
using System.IO;
namespace ConsoleApp11
{
    class Class1
    {
        public void file()
        {
            Console.WriteLine("enter the file name");
            var fileName = Console.ReadLine();
            Console.WriteLine("enter the content of the file");
            var content = Console.ReadLine();
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            File.WriteAllText(path, content);
            Console.WriteLine("file is created successfully");
            var r = File.ReadAllText(path);
            Console.WriteLine(r); 


        }
    }
}
