using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number");
            int id = int.Parse(Console.ReadLine());
            switch (id)
            {
                case 0:
                    Console.WriteLine("case0 is excuted");
                    break;
                case 1:
                    Console.WriteLine("case1 is excuted");
                    break;
                case 2:
                    Console.WriteLine("case2 is excuted");
                    break;
                case 3:
                    Console.WriteLine("case3 is excuted");
                    break;
                default:
                    Console.WriteLine("default block  is excuted");
                    break;





            }
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("numbers from 0 to99"+i);
            }
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            if (n <10)
            {
                Console.WriteLine("PRINT THE NUMBERS IN BETWEEN 10");
            }
            else if(n<=20)
             {
                Console.WriteLine("print the number  in  between 20);


            }
            else
            {
                Console.WriteLine("printing numbers are greater then 20);
            }

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            try
            {
                var j = Console.ReadLine();
                var r = n1 / n2;
                Console.WriteLine(r);

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException f)
            {
                Console.WriteLine(f.Message);
            }
            catch(NullReferenceException fw)
            {
                Console.WriteLine(fw.Message);
            }
           
        }
    }
}
