using System;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) 8 reqemli ededin reqemlerini iki -iki qruplashdir. 
            //    qruplarin cemini tap. alinan cavabin axirina 99 artir.
            //    sonra cavabin ozunden onun 18% ni cix;

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
            int sum = 0;
            for (int i = 0; i<4;i++)

            {

                a = anynumber % 100;
                Console.WriteLine($"your {i+1} number is {a}");

                sum=sum + a;
                
                anynumber=anynumber / 100;

            }
            Console.WriteLine($"sum of all numbers is {sum}");

            double conversion = Convert.ToDouble(sum);


            Console.WriteLine($"minus 18% from your sum  is {conversion-(conversion*0.18)}");


        }
    }
}
