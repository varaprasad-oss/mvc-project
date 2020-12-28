using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace taskdec
{
    class Class6
    {
        public static void ps()
        {
            List<int>  listName = new List<int>();
            for (int  i = 0; i < 10000; i++)
            {
                listName.Add(i );

            }
            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = 3;
            CancellationTokenSource t = new CancellationTokenSource();
            po.CancellationToken = t.Token;
            Console.WriteLine("Press any key to continue ...press c to cancel");
            Console.ReadKey();
            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'c')
                {
                    t.Cancel();
                }

            });
            try
            {
                Parallel.ForEach(listName, po, i =>
                {
                    Console.WriteLine("lidt"+i);
                    po.CancellationToken.ThrowIfCancellationRequested();
                });

            }
            catch (OperationCanceledException c)
            {
                Console.WriteLine(c.Message);
            }
            finally
            {
                Console.WriteLine("hello");
            }
            Console.ReadKey();



        }
    }
}
