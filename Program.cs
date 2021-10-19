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

            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(11.1, 22.2, 33.3);
            //Console.WriteLine(doubleoutput);

            //string stringoutput = MaximumNumberCheck.MaximumStringNumber("apple", "mango", "grapes");
            //Console.WriteLine(stringoutput);

            int[] intArray = { 11, 3442, 4032, 55, 68 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);

            double[] doubleArray = { 1.2, 340.4, 44.36, 51.55, 67.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "grapes", "banana", "pineapple" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

            Console.ReadKey();
        }
    }
}
