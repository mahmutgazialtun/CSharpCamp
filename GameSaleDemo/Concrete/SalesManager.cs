using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Customer customer, Campaign campaign)
        {
            Console.WriteLine("Satış gerçekleşti : " + customer.FirstName + campaign.CampaignName + "  Kampanyasından yararlanıldı");
        }
    }
}
