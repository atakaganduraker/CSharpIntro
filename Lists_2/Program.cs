namespace Lists
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] sehirler = new string[] { "Ankara" , "İstanbul" , "İzmir" };

            Console.WriteLine(sehirler.Length);

            sehirler = new string[4];
            sehirler[3] = "Bursa";

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);

            }
            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };
            
            sehirler2.Add( "İstanbul Bursa Ankara Lüleburgaz");
            Console.WriteLine(sehirler2.Count);

            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }
            sehirler2.Remove("İstanbul");
            bool result = sehirler2.Contains("İstanbul");
            Console.WriteLine(result);

        }
    }






}