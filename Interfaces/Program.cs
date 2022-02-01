using System;


namespace Interfaces
{
    class Program
    {
        // interface new'lenemez..... !!!!
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();
          //  customerManager.Add();

           // IPersonManager employeeManager = new EmployeeManager();
           // employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Uptade(new InternManager());


        }
    }
    /*class personmanager
    {
        //implemented operation
        public void add()
        {
            console.writeline("eklendi");

    /   }
    }
   */
    interface IPersonManager
    {
        //unimplemented operation
        void Add(); // default publictir public yazılamaz
        void Uptade();

    }
    //inherits - class ---------------------------- implements-interface
    class CustomerManager : IPersonManager // java da --CustomerManager implements IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");

        }
        public void Uptade()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");

        }

        public void Uptade()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Uptade()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }




    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {

            personManager.Add();

        }

        public void Uptade(IPersonManager personManager)
        {

            personManager.Uptade();

        }

    }
}