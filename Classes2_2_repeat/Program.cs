using System;
using System.Collections.Generic;


namespace Classes2_2_repeat
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product() { ProductName = "Laptop", UnitPrice = 6000, UnitInStock = 5 };
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


         
   

        }

    }



}

