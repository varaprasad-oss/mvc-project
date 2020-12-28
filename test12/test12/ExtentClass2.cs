using System;
using System.Collections.Generic;
using System.Text;

namespace test12
{
    public static class extension2
    {
        public static int Method(this ExtensionClass1 extensionClass1, int x,int y)
        {
            Console.WriteLine("This is implementation of extension method");
            return x+y;
        }
    }
}
