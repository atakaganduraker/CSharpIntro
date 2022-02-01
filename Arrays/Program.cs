using System;

namespace Arrays
{

    class Program

    {
        static void Main(string[] args)
        {

            //string kredi1 = "Hızlı Kredi";
            //string kredi2 = "Maaşını Halkban'tan Alanlara Özel";

            //Console.WriteLine(kredi1);
            //Console.WriteLine(kredi2);

            //string[] krediler = new string[7];

            //krediler[0] = "Hızlı Kredi";
            //krediler[1] = "Kredi 2";
            //krediler[2] = "Kredi 3";
            //krediler[3] = "Kredi 4";
            //krediler[4] = "Kredi 5";
            //krediler[5] = "Kredi 6";
            //krediler[6] = "Kredi 7";

            //Console.WriteLine(krediler[0]);




            int[] sayilar = new int[3];

            sayilar[0] = 10;

            sayilar[1] = 20;

            sayilar[2] = 30;

            Console.WriteLine($"En büyük sayı {sayilar[2]} 'dir.");

            Console.WriteLine($"Ortanca sayı {sayilar[1]} 'dir.");

            Console.WriteLine($"En küçük sayı {sayilar[0]} 'dir.");

        }
    }
}