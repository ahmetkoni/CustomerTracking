using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Databases.MongoDB.Collections
{
    public class MongoDB_UserCollection : ICollection
    {
        public string CollectionName { get; set; }
        public MongoDB_UserCollection()
        {
            CollectionName = "Users";
        }
    }
}
