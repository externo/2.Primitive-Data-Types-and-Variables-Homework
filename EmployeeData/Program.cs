using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Iliya";
            string LastName = "Vassilev";
            byte Age = 29;
            char Gender = 'm';
            long PersonalIDNumber = 8405100000;
            int UniqueEmployeeNumber = 27561234;
            Console.WriteLine("{0} {1} is {2} years old. His gender is {3}. He has personal Id number {4} and unique employee number {5}", FirstName, LastName, Age, Gender, PersonalIDNumber, UniqueEmployeeNumber);
        }
    }
}
