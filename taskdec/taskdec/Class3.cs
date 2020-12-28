using System;
using System.Collections.Generic;
using System.Text;

namespace taskdec
{
    class Class3
    {
        public void StringIndex()
        {
            Console.WriteLine("enter the name");
            string s = Console.ReadLine();
            Console.WriteLine("enter the index value ");
            int j = int.Parse(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                if (i == j)
                {
                    continue;
                }
                Console.Write(s[i]);

            }



        }
        public void StringReverse()
        {
            Console.WriteLine("enter the string ::");
            var str = Console.ReadLine();
            Console.WriteLine("required output ::");
            var sub = str.Substring(1, str.Length - 2);
            Console.WriteLine($"{str[str.Length - 1]}{sub}{str[0]}");

        }
    }
}

