using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace taskdec
{
    class Class1
    { public  void Fil()
        {
            Console.WriteLine("enter the file name");
            var filename = Console.ReadLine();
            Console.WriteLine("content of the file ");
            var content = Console.ReadLine();
            var path = Path.Combine(Environment.CurrentDirectory, filename);
            File.WriteAllText(path, content);
            Console.WriteLine("file is created successfully ");
            var res = File.ReadAllText(path);
            Console.WriteLine(res);

        }
        public void Dis()
        {
            var path = "rk.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void GetFiles()
        {
            string[] filePaths = Directory.GetDirectories(@"C:\");
            string[] dr = new string[100];
          
            foreach (var item in filePaths)
            {
                var r=item;
                Console.WriteLine(r);
                


            }

        }
        public void GetDirector()
        {

            Console.WriteLine("Enter path");
            var path = Console.ReadLine();

            var dirInfo = new DirectoryInfo(path);

            foreach (FileInfo fi in dirInfo.GetFiles("*", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.FullName + "\t" + fi.Length);
            }
        }
    }
}
