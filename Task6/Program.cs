using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) verilmihs 8 reqemli ededin ilk i ve axirinci reqemlerini legv et 

            Console.Write("type 8 digits number: ");

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
            if (anynumber > 9999999 && anynumber < 100000000)
            {

                Console.WriteLine($"good , your number: { anynumber} is 8 digits");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }

            int a;

            anynumber = anynumber / 10;       //  last number out

            a = anynumber-((anynumber / 1000000 )*1000000);  // first number out



         


            Console.WriteLine($"result of removing first and last digits  is: {a}");
        }
    }
}
