using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi

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

                Console.WriteLine($"good , your number: { anynumber} is 9 digit");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }


            anynumber = anynumber / 1000;
            anynumber = anynumber % 1000;
    
            int sum = 0;
            int a;
            
            for (int j=0; j < 3; j++)

            {

                
                a = anynumber % 10;
        
                sum = sum + a;

                anynumber /= 10;    
                

            }


            Console.WriteLine($"sum of middle 3 digits is: {sum}");

        }
    }
}
