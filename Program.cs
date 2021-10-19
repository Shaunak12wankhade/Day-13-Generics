using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Generics");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            //Console.WriteLine(output);

            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(11.1, 22.2, 33.3);
            Console.WriteLine(doubleoutput);
        }
    }
}
