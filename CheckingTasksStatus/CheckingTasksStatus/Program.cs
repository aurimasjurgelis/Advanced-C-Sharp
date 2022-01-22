using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CheckingTasksStatus
{
    class Program
    {
        static Timer timer;
        static Task task;
        static void Main(string[] args)
        {
            task = new Task(() =>
            {
                for (int i = 1; i <= 500; i++)
                {
                    Console.WriteLine(i);
                }
            });
            task.Start();

            timer = new Timer();
            timer.Elapsed += CheckTheTask;
            timer.Interval = 100;
            timer.Enabled = true;

            Console.ReadLine();
        }

        private static void CheckTheTask(object sender, ElapsedEventArgs e)
        {
            if (task.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is running.....");
            }
            else if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task is complete");
                timer.Enabled = false;  
            }
        }
    }
}
