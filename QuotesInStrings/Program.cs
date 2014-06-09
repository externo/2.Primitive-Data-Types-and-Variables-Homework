using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstValue = "The \"use\" of quotations causes difficulties.";
            string secondValue = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("Print the variable in the first way: {0}", firstValue);
            Console.WriteLine("Print the variable in the second way: {0}", secondValue);
        }
    }
}
