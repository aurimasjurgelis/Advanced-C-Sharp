using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TasksWithParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(new Action<object>(SayHi), "Jennifer");
            task1.Start();

            Task task2 = new Task(delegate (object name)
            {
                Console.WriteLine("Welcome back " + name);
            }, "Auriux");
            task2.Start();

            Task task3 = new Task(n => { Console.WriteLine("Welcome back " + n); }, "Jack");
            task3.Start();

            Console.ReadLine();


            Console.WriteLine("Tasks with Return value");

            Task<int> task4 = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 0; i <= 5; i++)
                {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
            task4.Start();
            Console.WriteLine(task4.Result);
        }

        public static void SayHi(object name)
        {
            Console.WriteLine("Welcome back " + name);
        }
    }
}
