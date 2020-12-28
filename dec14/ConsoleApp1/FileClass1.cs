using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public  class FileClass1
    {
        public void Disp()
        {
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
