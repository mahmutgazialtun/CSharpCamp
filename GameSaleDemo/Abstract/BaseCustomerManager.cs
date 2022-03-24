using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleDemo.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi");
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi");
        }
    }
}
