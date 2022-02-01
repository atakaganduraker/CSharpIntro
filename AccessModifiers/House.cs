using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class House

    {
        // public ise Pascal Case

        string _suburb;

        public House()
        {
            

        }
        public int Id { get; set; }
        public string City { get; set; }  //  private = sadece ilgili class'ta geçerli // internal = sadece aynı isim uzayında
        protected string Suburb { get; set; } 

        //private = sadece kendi klasında 
        //protected = sadece kendi klasında ++ kendi classını inherit eden yerde geçerli
    }
   public class HouseTest:House
    {
        public HouseTest()
        {
            
                       
        }

    }
}
