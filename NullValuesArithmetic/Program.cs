using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? intValue = null;
            double? doubleValue = null;
            Console.WriteLine("Try to print the integer value {0} and the double value {1}.", intValue, doubleValue);
            intValue += 1;
            doubleValue += null;
            Console.WriteLine("Second try to print the integer value {0} and the double value {1}.", intValue, doubleValue);
        }
    }
}
