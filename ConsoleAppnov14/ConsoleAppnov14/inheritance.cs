using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppnov14
{
    public class inheritanceExample
    {
        public string cat = "stay";
        public void animal()
        {
            Console.WriteLine("animals are eexample");
        }
    }
    public class inheritance1 : inheritanceExample
    {
        public string dog = "barking";
        public  void lion()
        {
            Console.WriteLine("lion is roaring");
        }
    }

    
}
