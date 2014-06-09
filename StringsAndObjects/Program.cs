using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstValue = "Hello";
            string secondValue = "World";
            object objValue = firstValue + " " + secondValue;
            string thirdValue = (string)objValue;
            Console.WriteLine(thirdValue);
        }
    }
}
