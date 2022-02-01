using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Id = 1;
            house.City = "Ankara";

        }
    }

     class Customer // internal ( sadece bu namespace içerisinde geçerli)
    {


    }
}