using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_SessionCollection : ICollection
    {
        public string CollectionName { get; set; }
        public MongoDB_SessionCollection()
        {
            CollectionName = "Sessions";
        }
    }
}
