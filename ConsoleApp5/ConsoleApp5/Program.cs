using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the example program of the Entity FrameWork");
            EFW obj = new EFW();
            Console.WriteLine("List the elements starts with s");
            //obj.ListEmployee1Table();
            //obj.ListEmployee2Table();
           // obj.ListWithJoins();
            obj.UpdatEMployee2(6,"HR");


        }
    }
}
