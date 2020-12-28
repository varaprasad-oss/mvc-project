using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace problem3
{
    
        class Program
        {
            public void FileCreation()
            {
                Console.WriteLine("enter file name:");
                var filename = Console.ReadLine();
                Console.WriteLine("enter content here:");
                var content = Console.ReadLine();
                var path = Path.Combine(Environment.CurrentDirectory, filename);
                using FileStream fs = File.Create(path);
                using var sr = new StreamWriter(fs);
                sr.WriteLine(content);
                Console.WriteLine("Hurrayy!!!File is created");
            }
            static void Main(String[] args)
            {
                new Program().FileCreation();
            }

        }

    

}
