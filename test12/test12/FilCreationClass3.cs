using System;
using System.IO;

namespace test12
{
    public class FilCreationClass3
    {
        //Method for Creating file
        public void File1()
        {
            Console.WriteLine("Enter your File Name");
            var FileName = Console.ReadLine();
            Console.WriteLine("Enter your content here");
            var Content = Console.ReadLine();
            var p = Path.Combine(Environment.CurrentDirectory, FileName);
            try
            {
                if (Content == "")
                {
                    throw new Exception("error");
                }
                else
                {
                    File.WriteAllText(p, Content);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            



        }
    }
}