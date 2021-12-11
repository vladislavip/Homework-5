using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3

            Console.Write("type 6 digit number: ");

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

                Console.WriteLine($"good , your number: { anynumber} is 6 digit");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }

            anynumber = anynumber / 1000;
            int a;
           
            int sum = 0;
            for (int i = 0; i < 3; i++)

            {
                a = anynumber % 10;

                anynumber=anynumber / 10;

                sum = sum + a;


            }
            Console.WriteLine($"sum of first 3 digits is: {sum}");
        }

    }
    
}
