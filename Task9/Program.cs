using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  



            Console.Write("type any number: ");

           long anynumber;


        readagain:
            try
            {

                anynumber = Convert.ToInt64(Console.ReadLine());


            }
            catch
            {
                Console.WriteLine("use only numbers");
                goto readagain;
            }

            Console.WriteLine($" your number: {anynumber} is correct format");


           long a = anynumber % 1000 / 100; //// 3rd digit

            long b=0;
        Console.WriteLine($"your 3rd digit (from the end) is: {a}");
        

            while (anynumber > 0)

            {
                b = anynumber % 10;
                anynumber = anynumber / 10;
            }

            Console.WriteLine($"your last digit (from the end) is: {b}");

            long c = a + b;
            Console.WriteLine($"sum of your last and 3rd digit is: {c}");

        }
    }
}
