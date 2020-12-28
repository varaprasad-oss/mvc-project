using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppnov14
{
    public class method_overriding
    {
        public virtual void run()
        {
            Console.WriteLine("running  in the school");

        }
    }
   public class match:method_overriding
    {
        public virtual void run()
        {
            Console.WriteLine("running in the wall");
        }
    }
    public class me : match
    {
        public override void run()
        {
            Console.WriteLine("running  in the groud");
        }
    }
}
