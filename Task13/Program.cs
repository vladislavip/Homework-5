using System;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) 3 dene 5 reqemli eded var.
            //    her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. alinan neticeleri topla
            //    yekunda alian cavabin 50%-ni hemin ededin uzerine gel.



            Console.Write("type 1st 5 digits number: ");

            int num1 = NumCheck();

            Console.Write("type 2nd 5 digits number: ");

            int num2 = NumCheck();

            Console.Write("type 3rd 5 digits number: ");

            int num3 = NumCheck();

            int FirtsLast1 = LastFirst(num1);

            Console.WriteLine($"your 1st number converted to {FirtsLast1}");


            int FirtsLast2 = LastFirst(num2);

            Console.WriteLine($"your 2nd number converted to {FirtsLast2}");


            int FirtsLast3 = LastFirst(num3);

            Console.WriteLine($"your 3rd number converted to {FirtsLast3}");


            int sumoffirstandlast = FirtsLast1 + FirtsLast2 + FirtsLast3;

            Console.WriteLine($"Sum of your conversions  {sumoffirstandlast}");

            double conversion=Convert.ToDouble(sumoffirstandlast);

            conversion = conversion + conversion * 0.5;

            Console.WriteLine($"50% plus to your conversion gives you:  { conversion}");





            static int NumCheck()

            {
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

                    Console.WriteLine($"good , your  number: { anynumber} is 5 digits");
                    return anynumber;
                }
                else
                {
                    Console.WriteLine("wrong number");
                    goto readagain;
                }


            }

            static int LastFirst (int num)

            {

                int a;
                int newnum=0;


                for (int i=1; i<6; i++)

                { if (i==1)

                    {
                        a = num % 10;
                        newnum = newnum + a;
                  
                    }

                    if (i == 5)

                    {
                        a = num % 10;
                        newnum = newnum + a*10;
                    }

                     num = num / 10;

                }

                return newnum;


            }














        }
    }
}
