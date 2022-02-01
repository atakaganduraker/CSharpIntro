
using System;
using System.Collections.Generic;


namespace Methods_2_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik =new Matematik();
            int sonuc1 = matematik.Topla(5,15);
            int sonuc2 = matematik.Topla(5,18);                     
            int sonuc3 = matematik.Topla(sayi2:60 , sayi1:10);
            int sonuc4 = matematik.ToplaParams(new int[] { 1, 2, 3, 4 });
            int sonuc5 = matematik.ToplaParams( 1, 2, 3, 4 );
            8


        }
    }


    //overloading
     class Matematik
    {
        public int Topla(int sayi1 , int sayi2)
        {
            
            return sayi1 + sayi2 ;

        }

        public int Topla(int sayi1, int sayi2, int sayi3 )
        {

            return sayi1 + sayi2 + sayi3;

        }


        public int ToplaParams(params int[] sayilar)
        {
           // int sonuc = 0;
            //foreach (var sayi in sayilar)
            //{
            //    sonuc = sonuc + sayi;
            //    sonuc += sayi;

            //}
           return  sayilar.Sum();


        }

        public int Cikar(int sayi1 , int sayi2)
        {

            return sayi1 - sayi2;


        }





       
    }
}






