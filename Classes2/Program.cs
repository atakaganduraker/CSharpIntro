using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{

    class Program
    {
        // instance = örnek
        
        static void Main(string[] args)
        {
            Product product1 = new Product() { ProductName = "Laptop", UnitInStock = 5, UnitPrice=5000 };
            


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }

    }



}