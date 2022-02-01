using System;

namespace inheritance
{
    class Program
    {

        static void Main(string[] args)

        {
            
            PersonManeger personManager = new PersonManeger();
            personManager.Add();
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.GetBestEmployee();

        }

    }

    class PersonManeger
    {
        public void Add()
        {
            Console.WriteLine("Eklendi");

        }

        public void Uptade()
        {
            Console.WriteLine("Güncellendi");

        }


    }

    class CustomerManager:PersonManeger
    {
        public void GetBestCustomer()
        {


        }
    }
    class EmployeeManager:PersonManeger
    {
        public void GetBestEmployee()
        {


        }

    }

    class Person
    {
        public int Id { get; set; } // database id
        public string NationalIdentity { get; set; }//Tc No
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Employee:Person
    {
        public string EmployeeNumber { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

}