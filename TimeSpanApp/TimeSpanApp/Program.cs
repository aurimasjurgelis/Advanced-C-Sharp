using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(26,10,15);
            Console.WriteLine(ts.TotalHours);

            ts = ts.Add(new TimeSpan(0, 0, 30));
            Console.WriteLine(ts);

            DateTime myDateOne = new DateTime(1990, 10, 30);
            DateTime myDateTwo = new DateTime(2017, 10, 30);

            TimeSpan sub = myDateTwo - myDateOne;
            sub = myDateTwo.Subtract(myDateOne);
            Console.WriteLine(sub.TotalDays/365.25);
        }
    }
}
