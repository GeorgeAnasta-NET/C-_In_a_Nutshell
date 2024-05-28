using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__In_a_Nutshell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
