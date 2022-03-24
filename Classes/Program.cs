using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Adıyaman";
            customer.FirstName = "Mahmut";
            customer.LastName = "Altun";
            customer.Id = 1;

            Customer customer2 = new Customer { Id = 2, City = "Adıyaman", LastName = "Altun", FirstName = "Gazi " };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
