using System;

namespace Taask10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            //    sonra cut yerde dayanlarinda bir eded duzlet,
            //    sonra onlari topla

            Console.Write("type 9 digits number: ");

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
            if (anynumber > 99999999 && anynumber < 1000000000)
            {

                Console.WriteLine($"good , your number: { anynumber} is 9 digits");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }

   

            int result = FirtstTransformation(anynumber);

            Console.WriteLine($"Your first transformation: {result}");

            int result2 = SecondTransformation(result);  

            Console.WriteLine($"Your first transformation: {result2}");

            Console.WriteLine($"The sum of your transformations is: {result+result2}"); ;

         static int FirtstTransformation(int number)

             {
                int a;
                int b = 1;
                int c;
                int d = 0;


                for (int i = 1; i < 10; i++)
                {

                    if (i % 2 != 0)


                    {
                        a = number % 10; // cut out last digit
                        c = a * b;         // positioning the las digit to end
                        d = c + d;         // adding next digit 
                        b = b * 10;

                    }

                    number = number / 10;
                }

                return d;
           

            }
            

            static int SecondTransformation(int number)

            {

                int e;
                int f;
                int g = 1;
                int h = 0;


                for (int i = 1; i < 6; i++)
                {

                    if (i % 2 == 0)

                    {
                        e = number % 10;
                        f = e * g;
                        h = h + f;
                        g = g * 10;

                    }

                    number = number / 10;
                }

                return h;
            

            }


   
        }
    }
}
