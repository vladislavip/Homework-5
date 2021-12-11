using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)


        {


            //9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439



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


            int a;
            int b=1 ;
            int c;
            int d=0;


            for (int i = 1; i < 10; i++)
            {

                if (i % 2 != 0)


                {
                    a = anynumber % 10; // cut out last digit
                    c = a * b;         // positioning the las digit to end
                    d = c + d;         // adding next digit
                    b = b * 10;         

                }
                
                anynumber = anynumber / 10;
            }

            Console.WriteLine($"your number transformed to: {d}");


        }


    }

}                

            


            







        
    

