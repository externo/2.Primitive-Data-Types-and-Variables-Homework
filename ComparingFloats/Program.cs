using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparingFloats
{
    class Program
    {
        static bool CompareFloats(float a, float b)
        {
            decimal eps = Math.Abs((decimal)a - (decimal)b);
            if (eps < 0.000001m)
            {
                return true;
            }
            return false;            
        }
        static void Main()
        {
            Console.WriteLine("The result of comparing the float numbers 5.3 and 6.01 is {0}",
                Program.CompareFloats(5.3f, 6.01f));
            Console.WriteLine("The result of comparing the float numbers 5.00000001 and 5.00000003 is {0}",
                Program.CompareFloats(5.00000001f, 5.00000003f));
            Console.WriteLine("The result of comparing the float numbers -0.0000007 and 0.00000007 is {0}",
                Program.CompareFloats(-0.0000007f, 0.00000007f));
            Console.WriteLine("The result of comparing the float numbers -4.999999 and -4.999998 is {0}",
                Program.CompareFloats(-4.999999f, -4.999998f));
        }
    }
}
