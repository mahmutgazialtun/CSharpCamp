using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id= 1,FirstName ="Mahmut",
            LastName = "Altun", City = "Adıyaman"};

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Engin";
            customer3.LastName = "Demiroğ";
            customer3.City = "Ankara";
            Customer customer2 = new Customer(2,"Gazi", "Altun",
                "Adıyaman");
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();

            void Method(int Id , string FirstName,
                string LastName,String City)
            {

            }
        }
    }
    
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName,string lastName,String city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
