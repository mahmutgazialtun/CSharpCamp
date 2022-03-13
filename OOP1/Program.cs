using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Category = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2,Category = 5, UnitsInStock = 5, ProductName = "kalem", UnitPrice = 24};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            

            Console.ReadLine();
        }
    }
}
