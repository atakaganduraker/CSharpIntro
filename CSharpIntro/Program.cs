using System;

namespace CSharpIntro
{

    class Program

{
    static void Main(string[] args)
        {

            double aboneSayisi = 34.4;
            int yas = 35;
            short yil = 1985;           
            byte sayi = 255 ;
           
            string duyuru = "duyurumuz var ";

            bool deger = true;
            double piyasaDun = 115000.6;
            double piyasaBugun = 115000.6;
            bool sonuc = piyasaBugun >= piyasaDun;


            string mesajArtis = "Artış Oku - gri";
            string mesajAzalis = "Azalış Oku - kırmızı";
            string mesajAynı = "Sabit Oku - yeşil";

            if (piyasaBugun > piyasaDun)
            {
                Console.WriteLine(mesajArtis);
            }
            else if(piyasaBugun == piyasaDun)
            {
                Console.WriteLine(mesajAynı);
            }
            else  
            {
                Console.WriteLine(mesajAzalis);
            }

        }
   }
}