using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }

        private string _firstName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
