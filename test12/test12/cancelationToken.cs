using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test12
{
    class FileClass3
    {

        
            public  void Cancelation()
            {
                List<string> li = new List<string>();
                for (var i = 1; i <= 10000; i++)
                {
                    li.Add("list elements are " + i);
                }
                ParallelOptions po = new ParallelOptions();
                po.MaxDegreeOfParallelism = 4;
                CancellationTokenSource t = new CancellationTokenSource();
                po.CancellationToken = t.Token;
                Console.WriteLine("enter  c to cancle");
                Console.ReadKey();
                Task.Factory.StartNew(() =>
                {
                    if (Console.ReadKey().KeyChar == 'c')

                        t.Cancel();
                    Console.WriteLine("press any key to exit");
                });
                try
                {
                    Parallel.ForEach(li, po, i =>
                    {
                        Console.WriteLine(i);
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



