using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppnov13
{
    class Class1
    {
        public void RunMoreThanOneTaskAndWaitForAll()
        {
            var list = new ConcurrentBag<string>();

            string[] dirNames = { ".", "../../../" };
            List<Task> tasks = new List<Task>();
            foreach (var dirName in dirNames)
            {
                Task t = Task.Run(() =>
                {
                    foreach (var path in Directory.GetFiles(dirName))
                    {
                        list.Add(path);
                    }
                });
                tasks.Add(t);
            }

            //TODO: Comment following line and see the difference
            Task.WaitAll(tasks.ToArray());

            foreach (Task t in tasks)
            {
                Console.WriteLine("Task {0} Status: {1}", t.Id, t.Status);
            }

            Console.WriteLine("List of files \n\r=================");
            foreach (var file in list)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("Number of files read: {0}", list.Count);
            Console.Read();

        }
    }   
}
