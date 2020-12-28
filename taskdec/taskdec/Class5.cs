using System;
using System.Collections.Generic;
using System.Text;

namespace taskdec
{
    /* Review comment: Please use function to work on this task */
    class Class5
    {public void disp()
        {
            Console.WriteLine("enter the name");
            var a = Console.ReadLine();
            char c = a[0];
            var f = a.Replace(a[0], a[a.Length - 1]);
            var result = f + c;
            Console.WriteLine($"replaced output{result}");

        }
    }
}
