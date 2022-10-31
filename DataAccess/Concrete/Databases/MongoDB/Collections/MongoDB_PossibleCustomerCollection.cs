using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_PossibleCustomerCollection : ICollection
    {
        public  string CollectionName { get; set; }
        public MongoDB_PossibleCustomerCollection()
        {
            CollectionName = "PossibleCustomers";
        }
    }
}
