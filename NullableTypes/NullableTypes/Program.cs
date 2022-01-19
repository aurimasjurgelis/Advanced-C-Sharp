using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? myDate = null;
            Console.WriteLine(myDate);

            int? number = null;
            Console.WriteLine(number);
            //number = 5;

            int numberTwo = 10;
            
            Console.WriteLine( number ?? numberTwo);

            string firstName = null;
            firstName = "John";

            string message = null;
            message= "first name is null";

            Console.WriteLine(firstName ?? message);

        }
    }
}
