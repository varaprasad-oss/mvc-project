using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test12
{
    class ContentOfFileClass3
    {
    
            public void create()
            {
                Console.WriteLine("Enter the file name:");
                var Fname = Console.ReadLine();
                Console.WriteLine("Enter the content of the file:");
                var content = Console.ReadLine();
                var path = System.IO.Path.Combine(Environment.CurrentDirectory, Fname);
                File.WriteAllText(path, content);
                //using FileStream fs = File.Create(path);
                //using var sr = new StreamWriter(fs);
                //sr.Write(content);
                Console.WriteLine("the content in the file is:");
                var fileContent = File.ReadAllText(path);
                Console.WriteLine(fileContent);
            }
        }

    }

