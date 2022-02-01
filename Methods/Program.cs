using System;


namespace Methods
{

    class Program
    {
        static void Main(string[] args)
        {
           Matematik matematik = new Matematik();

           int sonuc1 = matematik.Topla(5, 6);
           int sonuc2 = matematik.Topla(1);
           int sonuc3 = matematik.Topla(sayi2:65,sayi1:10);
            
        }

    }
    class Matematik
    {
        public int Topla(int sayi1, int sayi2 = 100)
        {
            return sayi1 + sayi2;
        }
        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

    }

     

}