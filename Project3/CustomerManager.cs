using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CustomerManager
    {
        public CustomerManager()
        {
            //Veritabanına bağlan data'yı çek
            customers = new List<Customer>()
          {
              new Customer{Id=1,FirstName="Engin",LastName="Demir",City="Ankara",Email="Demir@gmail.com"},
              new Customer{Id=2,FirstName="Ahmet",LastName="vera",City="İstanbul",Email="Ahmet@gmail.com"},
              new Customer{Id=3,FirstName="Mehmet",LastName="asfat",City="İzmir",Email="Mehmet@gmail.com"},
              new Customer{Id=4,FirstName="Derin",LastName="eril",City="Amasya",Email="Derin@gmail.com"},
              new Customer{Id=5,FirstName="Kağan",LastName="asfasdasd",City="Kırklareli",Email="Kağan@gmail.com"}
          };

        }  


        List<Customer> customers;

        public List<Customer> GetAll() 
        {

           
            return customers;


        }

        public void Add(Customer customer)
        {
            
            customers.Add(customer);

        }



    }
}
