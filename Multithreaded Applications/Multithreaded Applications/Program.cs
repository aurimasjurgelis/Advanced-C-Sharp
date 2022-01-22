using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultithreadApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleOne();
            ExampleTwo();
        }

        static void ExampleOne()
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 1 started");
                Console.WriteLine("Process 1 is running");
                for (long i = 0; i < 2_500_000_000; i++)
                { }
                Console.WriteLine("Process 1 has been completed \n");
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 2 started");
                Console.WriteLine("Process 2 is running");
                for (long i = 0; i < 5_000_000_000; i++)
                { }
                Console.WriteLine("Process 2 has been completed \n");
            }));
            t2.Start();

            Thread t3 = new Thread(new ThreadStart(delegate ()
            {
                Thread.Sleep(1);
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name + " welcome back");
            }));
            t3.Start();
        }


        static void ExampleTwo()
        {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            t1.Start(500);
        }



        class Helper
        {
            public void Loop(object number)
            {
                for (int i = 0; i < int.Parse(number.ToString()); i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
