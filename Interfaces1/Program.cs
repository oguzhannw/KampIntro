using System;

namespace Interfaces1
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("*****************************");

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();

            Console.WriteLine("*****************************");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    } 
    interface IPersonManager //***Şablon*** belirlenir.
        // unimplemented operation
    {
        void Add();
        void Update();
    }

    //inherits = class ******************* implements=interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri yenilendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri yenilendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer yenilendi!");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
