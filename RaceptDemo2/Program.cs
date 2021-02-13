using System;

namespace RaceptDemo2
{
    class Program
    {
        // BİR CLASS AYNI ANDA BİRDEN FAZLA İNTERFACE IMPLAMENT EDEBİLİR.
        static void Main(string[] args)
        {
            //Interface();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());


            Console.ReadLine();
        }

        private static void Interface()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
        }
    }
    interface IPerson//Burada tanımlanmış her eşy hem customer hem de student'de gözükür.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName); 
        }
    }
}
