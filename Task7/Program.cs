using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

            Console.Write("type 4 digits number: ");

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

                Console.WriteLine($"good , your number: { anynumber} is 4 digits");

            }
            else
            {
                Console.WriteLine("wrong number");
                goto readagain;
            }

            int d=0;
            int b = 10000;
            int reversed=0;



            for (int i = 0;i<4;i++)

            {
                b = b / 10;       // b decrease
                
                d = (anynumber % 10)*b;  // x000 pass forward

                 reversed=reversed + d;  // reversed number 
         

                anynumber = anynumber / 10; // counter

                

            }

            reversed = (reversed + 80000) * 10 + 8;   //+8 at the begining and end

            Console.WriteLine($"you number after inversion and addition of 8 from the both ends turns into: {reversed}");
            


        }
    }
}
