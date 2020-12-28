using System;

namespace extensionExample
{
    
    public class program
    {

        static void Main(string[] args)
        {
            //#region
            ////Class1 extension1 = new Class1();
            ////Console.WriteLine($"the multiplication output :");
            ////extension1.Mul(8,5);
            ////Console.WriteLine($"adding two numbers :");
            ////extension1.add(87, 93);
            ////Console.WriteLine("subtracting two numbers:");
            ////extension1.sub(3, 5);
            ////#endregion
            int aa = 10;
            int  bb = 20;
            int cc;

            Class3 pv = new Class3();
            //var res =pv.PassByValue(aa, bb);
            //Console.WriteLine(res);
            //Console.WriteLine(aa);
            //var res= pv.Pa(ref aa, bb);
            // Console.WriteLine(res);
            // Console.WriteLine(aa);
         
            Console.WriteLine(pv.Pa(aa, bb, out cc)+" \n  " +cc);
            





        }
    }
}
