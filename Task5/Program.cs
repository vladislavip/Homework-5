using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at. 
            Console.Write("type 6 digits number: ");

            int anynumber;


        readagain:
            try
            {

                anynumber = Convert.ToInt32(Console.ReadLine());


            }
            catch
            {
                Console.WriteLine("use only numbers");
                goto readagain;
            }
            if (anynumber > 99999 && anynumber < 1000000)
            {

                Console.WriteLine($"good , your number: { anynumber} is 6 digits");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }

            int a;

            a = (anynumber% 100000)*10 +anynumber / 100000 ;


   


            Console.WriteLine($"first digit goes to the end of num: {a}");
        }
    }
}
