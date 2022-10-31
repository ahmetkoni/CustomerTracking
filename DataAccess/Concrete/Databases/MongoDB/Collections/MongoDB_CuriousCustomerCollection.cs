using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_CuriousCustomerCollection : ICollection
    {
        public string CollectionName { get; set; }
        public MongoDB_CuriousCustomerCollection()
        {
            CollectionName = "CuriousCustomers";
        }
    }
}
