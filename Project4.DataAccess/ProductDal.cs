using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class ProductDal
    {
        //Ado.Net
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
              new Product{ProductId = 1, ProductName ="Acer Laptop",QuantityPerUnit="32 Gb Ram", UnitPrice=10000 , UnitsInStock=2},
              new Product{ProductId = 2, ProductName ="Asus Laptop",QuantityPerUnit="32 Gb Ram", UnitPrice=10000 , UnitsInStock=1},
              new Product{ProductId = 3, ProductName ="Hp Laptop",QuantityPerUnit="32 Gb Ram", UnitPrice=10000 , UnitsInStock=0},
              new Product{ProductId = 4, ProductName ="Mac Laptop",QuantityPerUnit="32 Gb Ram", UnitPrice=10000 , UnitsInStock=3},
              new Product{ProductId = 5, ProductName ="Dell Laptop",QuantityPerUnit="32 Gb Ram", UnitPrice=10000 , UnitsInStock=10}
            };

        }

        public List<Product> GetAll()
        {
            //
            return _products;
        }
    }
}
