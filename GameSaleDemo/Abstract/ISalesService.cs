using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleDemo.Abstract
{
    public interface  ISalesService
    {
        void Sales(Customer customer,Campaign campaign);
    }
}
