using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ManagingThreads
{
    class Program
    {
        static Thread t1;
        static Thread t2;
        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread Number 1 (English)";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread Number 2 (Spanish)";
            t2.Start();

            Thread t3 = new Thread(new ThreadStart(() => Console.WriteLine("Hello from lambda expression")));
            t3.Start();


            Thread t4 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from the anonymous method assigned to the t4 thread");
                }
            }));

            t4.Start();

            
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(1000);
                //if (i == 31)
                //{
                //    Console.WriteLine(Thread.CurrentThread.Name + " is about to be aborted");
                //    t1.Abort();
                //}
                Console.WriteLine(i + " Hi...");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                t1.Join();
                //Thread.Sleep(new TimeSpan(0, 0, 1));
                Console.WriteLine(i + " Hola...");
            }
        }




    }
}
