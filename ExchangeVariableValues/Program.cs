using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before the first change, a = {0}, b = {1}", a, b);

            //the first way of changing the values is
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("after the first change, a = {0}, b = {1}", a, b);

            //the second way of changing the values is
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after the second change, a = {0}, b = {1}", a, b);
        }
    }
}
