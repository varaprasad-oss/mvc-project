using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace test12
{
    class ArrayEx
    {
        //constructor
        public ArrayEx()
        {
            Console.WriteLine("this is constructor implementation");
        }
        public void Print()
        {
            int[] array = new int[5];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;
            Console.WriteLine("The Array elements are ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //foreach (var item3 in array)
            //{
            //    Console.WriteLine(array);
            //}
           
        }
    }
}

