using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = new Task(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task is cancelled!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i + 1);
                    }
                }
                Console.WriteLine("Task is Complete!");
            });

            task.Start();

            //Thread.Sleep(3000);
            //cancellationTokenSource.Cancel();
            cancellationTokenSource.CancelAfter(5000);

            Console.ReadLine();
        }
    }
}
