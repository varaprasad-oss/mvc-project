using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppnov14
{
    public class methodoverload
    {
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int  add(int a, int b)
        {
            return a + b;

        }

    }
}
