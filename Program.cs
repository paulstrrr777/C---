// See https://aka.ms/new-console-template for more information
//  Console.WriteLine("Hello, World!");
using System;

namespace App1 {
     class Program 
     {
        public static void Main()
        {
            Console.WriteLine("Hello, World !!!");
            
            try
            {
                string? a = "С";
                //bool b = true;
                a = Console.ReadLine();
                // Do not Work !
                //a.Replace('С', ' '); a.Replace('е', ' '); a.Replace('р', ' ');
                Console.WriteLine($"Привет, {a}");
                Console.WriteLine("EEEE");
            }
            catch (DivideByZeroException nameEr)
            { Console.WriteLine(nameEr.Message); }
        }


     }
}