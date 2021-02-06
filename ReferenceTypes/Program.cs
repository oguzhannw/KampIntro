using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,boolean  **** DEĞER TİP(ValueTypes) ****
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2; //sayı1'in değerini sayı2 ile değiştir.
            sayi2 = 100;
            Console.WriteLine("Sayı 1 : " + sayi1);

            //arrays,class,interface   ****REFERANS TİP****
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;     //STACK-HEAP.     sayilar1{1,2,3} değerlerini hafızadan siler.
            sayilar2[0] = 1000;
            Console.WriteLine("Sayılar[0] : "+ sayilar1[0]);

            /////////***************************************************************************************///////

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2.FirstName = "Derin";
            person1 = person2;
            Console.WriteLine(person1.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();
            employee.FirstName = "Veli"; 

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCardNumber); //Person3'de CreditCardNumber gelmesi için (Customer) bloğuna aldık.

            PersonManager personmanager = new PersonManager();
            personmanager.Add(employee);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person   //base class(temelsınıf)=Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
