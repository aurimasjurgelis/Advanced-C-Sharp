using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Debugging
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            x = 2;
            y = 2;
            Console.WriteLine("Inside main");
            ChangeValues();
            x = 10;
            y = 20;
            Console.WriteLine("Inside main again");

            Debug.WriteLine("Hello from the debug writeline");
            Debug.WriteLineIf(x == 10,"X is ten");
            
        }

        public static void ChangeValues()
        {
            x = 4;
            y = 5;
            Console.WriteLine("Inside change values");
        }

    }
}
