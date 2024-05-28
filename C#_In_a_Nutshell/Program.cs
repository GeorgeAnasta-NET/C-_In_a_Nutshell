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
            //Console.WriteLine(FeetToInches(30));
            //Console.WriteLine(FeetToInches(100));

            string message = "Hello World";
            string  upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);                //HELLO WORLD

            int x = 2015;
            message = message + x.ToString();
            Console.WriteLine(message);                     //Hello World2015

            bool simpleVar =  false;
            if (simpleVar)
            {
                Console.WriteLine("This will not print");
            }

            int y = 5000;
            bool lessThanAMile = y < 5280;
            if(lessThanAMile)
            {
                Console.WriteLine("this will print");
            }

            Console.Read();

        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
