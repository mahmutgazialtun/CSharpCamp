using GameSaleDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleDemo.Entities
{
    public class Customer : IEntity
    { 
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth{ get; set; }

    }
}
