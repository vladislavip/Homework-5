using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1) verilmish 4 reqemli ededin reqemlerinin cemini tap

            Console.Write("type 4 digit number: ");

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
            if (anynumber > 999 && anynumber < 10000)
            {
     
                Console.WriteLine($"good , your number: { anynumber} is 4 digit");
               
            } else
            {
                Console.WriteLine("wrong number");
                    goto readagain;
            }
            int a;
            
            int sum=0;
           for (int i = 0; i < 4; i++)

            {  

               
               a = anynumber % 10;

               anynumber = anynumber / 10;

              sum=sum+a;
                  
            }
            Console.WriteLine($"sum of all digits is: {sum}");
        }
    }
}
