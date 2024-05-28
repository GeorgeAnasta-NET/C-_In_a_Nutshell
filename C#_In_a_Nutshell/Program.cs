using System;

namespace C__In_a_Nutshell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FeetToInches(30));
            //Console.WriteLine(FeetToInches(100));

            string message = "Hello World";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);                //HELLO WORLD

            int x = 2015;
            message = message + x.ToString();
            Console.WriteLine(message);                     //Hello World2015

            bool simpleVar = false;
            if (simpleVar)
            {
                Console.WriteLine("This will not print");
            }

            int y = 5000;
            bool lessThanAMile = y < 5280;
            if (lessThanAMile)
            {
                Console.WriteLine("this will print");
            }

            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));                                   //360
            Console.WriteLine(feetToInchesConverter.Convert(100));                                  //1200
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));      //63360

            Console.Read();

        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }

    }

    public class UnitConverter
    {
        int ratio;                                                          //field
        public UnitConverter(int unitRatio) { ratio = unitRatio; }          //ctor
        public int Convert(int unit) { return unit * ratio; }               //method
    }
}
