using GameSaleDemo.Abstract;
using GameSaleDemo.Adapter;
using GameSaleDemo.Entities;
using GameSaleDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseCustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            //customerManager.Add(new Customer
            //{
            //    DateOfBirth = new DateTime(1985, 1, 6),
            //    FirstName = "Engin",
            //    LastName = "Demiroğ",
            //    NationalityId = "28861499108"
            //});

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Yeni kayıt kampanyası";
            campaign1.CampaignRate = 25;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Customer customer = new Customer();
            customerManager.Delete(new Customer());

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(customer,campaign1);
            Console.ReadLine();
        }
    }
}
