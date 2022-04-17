// See https://aka.ms/new-console-template for more information
//  Console.WriteLine("Hello, World!");
using System;
using System.Globalization;

namespace App1 {
     class Program 
     {
        public static void Main()
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            string numberString = "32.e64";
            try
            {
                double a = double.Parse(numberString);
                Console.WriteLine(a);
            }
            catch (FormatException)
            { Console.WriteLine("FormatException"); }


            double number;
            bool result = double.TryParse(numberString, out number);
            if (result) { Console.WriteLine("EEEE !!"); }
            else { Console.WriteLine("OI !"); }

        }


     }
}