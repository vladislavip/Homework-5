using System;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 15)*5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.    (a)
      3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.                                     (b)
      Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.          (c)
      Cavabdan 7 reqemli ededin son 5 reqemini cix.                                                                    (d)
      Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.                     (e)
      Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.                    (f)
      Cavabin axirina 11 artir.                                                                                        (g)
      Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.                                            (h)
      Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.                                              (k)     */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////(a)

            Console.Write("type 1st 3 digits number: ");


            int num1 = NumCheck3();
   

            Console.Write("type 2nd 3 digits number: ");
            int num2 = NumCheck3();
          


            Console.Write("type 3rd 6 digits number: ");

            int num3 = NumCheck6();
         

            Console.Write("type 4th 6 digits number: ");

            int num4 = NumCheck6();
         

            Console.Write("type 5th 7 digits number: ");
            int num5 = NumCheck7();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////(b)

           double b = Math.Pow(((num1 + num2) % 100), 2);
            Console.WriteLine($"3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap netice: {b} ");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////(C)

            int c = (num1 * 1000) + num2 + (int)b;

            Console.WriteLine($"Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel netice: {c}");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////(d)

            int d = c - (num5 % 100000);

            Console.WriteLine($"Cavabdan 7 reqemli ededin son 5 reqemini cix netice: {d}");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////(e)

            int e = d + ((num4 + num3) % 1000);


            Console.WriteLine($"Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel netice: {e}");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// (f)

            int f = num5;

            int sum = 0;

            while (f>0)
            {
                int ff = f % 10;
                sum = sum + ff;
                f = f / 10;
            }
            

            int revsum=0;

            while (sum > 0)

            {
                int sum1 = sum % 10;
                revsum = sum1 + revsum*10;
                sum = sum / 10;

            }

            int ffinal = e + revsum;
 
   

            Console.WriteLine($"Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel netice: {ffinal}");


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// (g)

            int g = ffinal * 100 + 11;

           Console.WriteLine($"Cavabin axirina 11 artir netice: {g}");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// (h)


            int h1=num5;
            int h2 = 0;
            int h3;
            int h4 = 1;

            for (int i=1; i<8; i++)

            {
                if (i%2 !=0)

                {
                    h3 = h1 % 10;   
                    h2 = h2+h4*h3;   
                    h4 = h4 * 10;
                }

                h1 = h1 / 10;

            }
           

            int hfinal = g - h2;

            Console.WriteLine($" Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix netice:  {hfinal}");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////(k)
            
            int k1 = hfinal;
            int k2 = k1 % 10;
            int k3 = (((hfinal / 10) * 100) + 88) * 10 + k2;

            Console.WriteLine($" Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et netice:  {k3}");


            static int NumCheck3()

            {
                int anynumber;
            readagain:
                try
                {

                    anynumber = Convert.ToInt32(Console.ReadLine());                              /////!!!!!!!!!!!


                }
                catch
                {
                    Console.WriteLine("use only numbers");
                    goto readagain;
                }
                if (anynumber > 99 && anynumber < 1000)
                {

                    Console.WriteLine($"good , your  number: { anynumber} is 3 digits");
                    return anynumber;
                }
                else
                {
                    Console.WriteLine("wrong number");
                    goto readagain;
                }


            }

            static int NumCheck6()

            {
                int anynumber;
            readagain:
                try
                {

                    anynumber = Convert.ToInt32(Console.ReadLine());                          /////!!!!!!!!!!!


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

                    anynumber = Convert.ToInt32(Console.ReadLine());                           /////!!!!!!!!!!!


                }
                catch
                {
                    Console.WriteLine(1234567);
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


        }
    }
}


