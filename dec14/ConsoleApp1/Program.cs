using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileClass1 fileClass1 = new FileClass1();
            //fileClass1.Disp();
            Console.WriteLine("enter the file name");
            var fileName = Console.ReadLine();
            Console.WriteLine("Enter the content here");
            var content = Console.ReadLine();
            var p = Path.Combine(Environment.CurrentDirectory, fileName);
            try
            {
                if (content == "")
                {
                    throw new Exception("Error");

                }
                else
                {
                    File.WriteAllText(p, content);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}
