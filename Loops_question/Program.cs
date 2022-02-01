using System;

namespace Loops_question
{

    class Program

    {
        static void Main(string[] args)
        {

            int sayi1;

            int sayi2;

            int toplam1 = 0;

            int toplam2 = 0;



            Console.Write("Birinci sayıyı giriniz: ");

            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");

            sayi2 = Convert.ToInt32(Console.ReadLine());



            for (int i = 1; i < sayi1; i++)

            {

                if (sayi1 % i == 0)

                {

                    toplam1 += i;

                }

            }



            for (int i2 = 1; i2 < sayi1; i2++)

            {

                if (sayi2 % i2 == 0)

                {

                    toplam2 += i2;

                }

            }



            if (toplam1 == sayi2 && toplam2 == sayi1)

            {



                Console.WriteLine("Verdiğiniz bu iki sayı Arkadaş Sayılardır.");

            }

            else

            {

                Console.WriteLine("Bu iki sayı Arkadaş Sayılar değildir.");

            }

        }
    }
}








