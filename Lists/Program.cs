using System;

namespace Lists
{

    class Program
    {

      static void Main(string[] args)

        {
            string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir" };

            Console.WriteLine(sehirler.Length);

            sehirler =  new string[4];
            sehirler[3] = "Bursa";

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Bursa");
            sehirler2.Add("Adana");
            sehirler2.Remove("İstanbul");
            sehirler2.Insert(0, "Kırklareli");
            bool sonuc = sehirler2.Contains("AA");
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine(sonuc.ToString());





        }

    }


}