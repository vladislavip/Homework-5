using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)

            //4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
        {
            Console.Write("type 5 digits number: ");

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
            if (anynumber > 9999 && anynumber < 100000)
            {

                Console.WriteLine($"good , your number: { anynumber} is 5 digits");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }

            int a;
            int b;
            
          
            double power;
            a = anynumber %10;         // last number

            b = anynumber /10000;     //first number
            
          power = Math.Pow(Convert.ToDouble(a+b), 2);    

           

            Console.WriteLine($"power of sum of first and last digit is: {power}");
        }
    }
}
