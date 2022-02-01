using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_2_repeat
{
    //methods
    //reusability
    internal class ProductManager // ProductService ( iş operasyonları )
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Sisteme Eklendi :" + product.ProductName);// + " " + product.UnitPrice +" "+ product.UnitInStock );

        }

    }
}
