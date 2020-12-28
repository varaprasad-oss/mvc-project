using System;
using System.Collections.Generic;
using System.Text;

namespace task_4dec
{
    class Class3
    {
        public void disp()
        {


            Console.WriteLine("enter your name");
            var f = Console.ReadLine();
            var g = f[0];
            var r = f.Replace(f[0], f[f.Length - 1]);
            var remove = r.Remove(f.Length - 1);
            var result = remove + g;
            Console.WriteLine(result);
        }
    }
}
