using System;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) 4 dene eded daxil et. bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.                     (a)
            //    6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.                                (b)
            //    neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel                                   (c)
            //    alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.     (d)
            //    neticenin 60 % tap. cavabin axirina 60 artir.                                                          (e)
            //    neticeden 18% cix.                                                                                     (f)



            Console.Write("type 1st 6 digits number: ");

            int num1 = NumCheck6();

            Console.Write("type 2nd 6 digits number: ");

            int num2 = NumCheck6();

            Console.Write("type 3rd 6 digits number: ");

            int num3 = NumCheck6();

            Console.Write("type 4th 7 digits number: ");

            int num4 = NumCheck7();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////(b)

            int manipulations61 = Manipulations6(num1);

            Console.WriteLine($"First 3 digits from 1st number: {manipulations61}");

            int manipulations62 = Manipulations6(num2);

            Console.WriteLine($"First 3 digits from 2nd number: {manipulations62}");

            int manipulations63 = Manipulations6(num3);

            Console.WriteLine($"First 3 digits from  3rd  number: {manipulations63}");

            int finalmanipulation6 = manipulations61 + manipulations62 + manipulations63;

            Console.WriteLine($"Sum of all previous 3 digit manipulations is:{finalmanipulation6}");

            ///////////////////////////////////////////////////////////////////////////////////(c)


            int manipulation7 = (num4 % 10000) + finalmanipulation6;

            Console.WriteLine($"yor transformaed 7 digit number plus sum of all 3 digit manipulations is: {manipulation7}");

            /////////////////////////////////////////////////////////////////////////////////////////////////(d)

            int manipulations71 = Manipulations7(num4);

            Console.WriteLine($"yout 4th number transformed to {manipulations71}");



            int nextmanipulation = manipulation7 - manipulations71;



            Console.WriteLine($"previous manipulation minus product of first 3 digits of 4th number is: {nextmanipulation}");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////(e)

          double final = nextmanipulation * 60 / 100;

            final = final * 100 + 60;

           double lastfinal = final - (final * 18 / 100);

            Console.WriteLine($"60 % with  60 added at the end: {final}");
            Console.WriteLine($"minus 18% from previous result {lastfinal}");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            static int NumCheck6()

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
                if (anynumber > 99999 && anynumber < 1000000)
                {

                    Console.WriteLine($"good , your  number: { anynumber} is 6 digits");
                    return anynumber;
                }
                else
                {
                    Console.WriteLine("wrong number");
                    goto readagain;
                }


            }


            static int NumCheck7()

            {
                int anynumber;
            readagain:
                try
                {

                    anynumber = Convert.ToInt32(1234567);


                }
                catch
                {
                    Console.WriteLine("use only numbers");
                    goto readagain;
                }
                if (anynumber > 999999 && anynumber < 10000000)
                {

                    Console.WriteLine($"good , your  number: { anynumber} is 7 digits");
                    return anynumber;
                }
                else
                {
                    Console.WriteLine("wrong number");
                    goto readagain;
                }


            }



            static int Manipulations6(int number)

          
            {

                number = number / 1000;

                return number;

            }
            

            

            static int Manipulations7(int number)

        

            {
                number = number / 10000;

                int a;
                int mul=1;



             for (int i=0; i<3; i++)


                {
                    a=number % 10;

                    mul = mul * a;

                    number= number / 10;    


                }

                return mul;


            }










         }
    }
}
