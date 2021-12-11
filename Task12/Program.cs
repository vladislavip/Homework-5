using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) 2 dene 5 reqemli eded daxil et. 
            //    i ededin reqemleri ceminin usutne ii ededin reqemleri hasilini gel.
            //    neticenin axirina i ededin en axiinci reqemini artir.



            Console.Write("type 1st 5 digits number: ");



            int num1 = NumCheck();

            Console.Write("type 2nd 5 digits number: ");

            int num2 = NumCheck();


          
            int man = Num1Manipulations(num1);
            Console.WriteLine($"Sum of all digits of first number is: {man}");

            int man1 = Num2Manipulations(num2);

            Console.WriteLine($"Product of all digits of second  number is: {man1}");

            int man1Andman2 = man + man1;


            Console.WriteLine($"Sum of two previous manipulations : {man1Andman2}");

            int finalmanipulation = man1Andman2 * 10 + (num1 % 10);


            Console.WriteLine($"Adding last digit of first number to sum of two manipulations  : {finalmanipulation}");


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




            static int Num1Manipulations(int num1)
            {

                int a;
                int sum = 0;

                for (int i = 0; i < 5; i++)


                {
                    a = num1 % 10;
                    sum = sum + a;

                    num1 = num1 / 10;

                }

                return sum;

            }

            static int Num2Manipulations(int num2)
            {

                int a;
                int mul= 1;

                for (int i = 0; i < 5; i++)


                {
                    a = num2 % 10;
                    mul = mul * a;
                    
                    num2 = num2/ 10;

                }

                return mul;

            }



        }
    }
}
