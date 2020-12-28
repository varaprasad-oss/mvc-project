using System;
using System.Collections.Generic;
using System.Text;

namespace taskdec
{
    class Class4
    {
        public void sf() {
            Console.WriteLine("enter the string ::");
            var str = Console.ReadLine();
            Console.WriteLine("required output ::");
            var sub = str.Substring(1, str.Length - 2);
            Console.WriteLine($"{str[str.Length-1]}{sub}{str[0]}");

            }
    }
}
