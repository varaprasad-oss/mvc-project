using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallelfor_loop
{
    public class emp
    {
        public void emplo()
        {
            List<int> id = new List<int>();
            List<string> empname = new List<string>();
            List<DateTime> datefjoin = new List<DateTime>();
            Console.WriteLine("enter how many employees");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter {0}employee details" + i + 1);
                Console.WriteLine("enter the id:");
                id.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("enter name");
                empname.Add(Console.ReadLine());
                Console.WriteLine("enter the date of joining");
                datefjoin.Add(DateTime.Parse(Console.ReadLine()));
            }
            Parallel.For(0, n, i =>
            {
                Console.WriteLine("{0} employee details", i + 1);
                Console.WriteLine("{0}\n{1}\n{2}", id[i], empname[i], datefjoin[i].ToShortDateString());
            });
        }
    }
}
