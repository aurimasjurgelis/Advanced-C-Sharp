using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Deadlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Files file = new Files();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\accounts{i}.txt");
            }
        }
    }

    class Files
    {
        public Object thisLock = new Object();
        public void Write(object path)
        {
            //lock (thisLock)
            //{
            //    // some logic of writing in files goes in where
            //    Console.WriteLine("Writing in " + path);
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Writing process has been completed");
            //}
            try
            {
                // some logic of writing in files goes in where
                Monitor.Enter(path);
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed");

            }
            finally
            {
                Monitor.Exit(path);
            }
        }

        public void Read(object path)
        {
            //lock (thisLock)
            //{
            //    // some logic of writing in files goes in where
            //    Console.WriteLine("Reading from " + path);
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Reading process has been completed");
            //}

            Console.WriteLine("Reading from " + path);
            Thread.Sleep(1000);
            Console.WriteLine("Reading process has been completed");


        }
    }
}
