using System;

namespace Constructors // Yapıcı bloktur. sadece 1 kere çalışır.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="Engin",LastName="Demiroğ",City="Ankara"};

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        public Customer() //customer1 de bu çalışır
        {

        }
        public Customer(int id,string firstName, string lastName, string city) //default constructor //Customer2 de bu çalışır.
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
